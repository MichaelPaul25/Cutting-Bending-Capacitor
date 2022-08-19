using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Util;
using System.Windows.Forms;
using System.Threading;

namespace Easymodbus_Serial
{
    class Camera
    {
        private ImageBox _my_imagebox;
        private ImageBox _my_filterbox;
        private ImageBox _my_grabbox;
        private VideoCapture _video_live;
        private Mat _video_grab;

        private Image<Bgr, byte> _image_grabbed;
        private Image<Bgr, byte> _image_grabbed1;
        private Image<Bgr, byte> _image_snap;
        private Image<Bgr, byte> _image_process;

        private Label _lbl_result_area;
        private Label _lbl_result_lamp;

        private bool _setup;

        private bool _vision_busy = false;
        private bool _vision_result = false;

        private Rectangle _roi_rect;
        private int _cam_number;
        private bool _cam_connect = false;
        private bool _cam_live = false;
        private bool _vision_process = false;
        private bool _show_filterbox;
        private bool _streamCam = false;

        private int _filter_min = 0;
        private int _filter_max = 255;
        private int _area_min;

        private int _cntr_pass = 0;
        private int _cntr_fail = 0;
        private int _cntr_all = 0;

        private int result_area;

        private Color _color_pass = Color.Lime;
        private Color _color_fail = Color.Red;

        private MCvScalar _scalar_pass = new MCvScalar(0, 255, 0);
        private MCvScalar _scalar_fail = new MCvScalar(0, 0, 255);

        //Device_Setup ds = new Device_Setup();

        public bool M_streamCam
        {
            get { return _streamCam; }
            set { _streamCam = value; }
        }
        public Rectangle roi_rect
        {
            get { return _roi_rect; }
            set { _roi_rect = value; }
        }
        public int cam_number
        {
            get { return _cam_number; }
            set { _cam_number = value; }
        }
        public bool cam_live
        {
            get { return _cam_live; }
            set { _cam_live = value; }
        }
        public bool vision_process
        {
            get { return _vision_process; }
            set { _vision_process = value; }
        }
        public ImageBox my_imagebox
        {
            get { return _my_imagebox; }
            set { _my_imagebox = value; }
        }
        public ImageBox my_filterbox
        {
            get { return _my_filterbox; }
            set { _my_filterbox = value; }
        }
        public ImageBox my_grabbox
        {
            get { return _my_grabbox; }
            set { _my_grabbox = value; }
        }
        public int filter_min
        {
            get { return _filter_min; }
            set { _filter_min = value; }
        }
        public int filter_max
        {
            get { return _filter_max; }
            set { _filter_max = value; }
        }
        public int area_min
        {
            get { return _area_min; }
            set { _area_min = value; }
        }
        public Label lbl_result_area
        {
            get { return _lbl_result_area; }
            set { _lbl_result_area = value; }
        }
        public Label lbl_result_lamp
        {
            get { return _lbl_result_lamp; }
            set { _lbl_result_lamp = value; }
        }
        public bool show_filterbox
        {
            get { return _show_filterbox; }
            set { _show_filterbox = value; }
        }
        public bool cam_connect
        {
            get { return _cam_connect; }
            set { _cam_connect = value; }
        }
        public bool setup
        {
            get { return _setup; }
            set { _setup = value; }
        }
        public bool vision_busy
        {
            get { return _vision_busy; }
            set { _vision_busy = value; }
        }
        public bool vision_result
        {
            get { return _vision_result; }
            set { _vision_result = value; }
        }
        public int cntr_pass
        {
            get { return _cntr_pass; }
            set { _cntr_pass = value; }
        }
        public int cntr_fail
        {
            get { return _cntr_fail; }
            set { _cntr_fail = value; }
        }

        public int cntr_all
        {
            get { return _cntr_all; }
            set { _cntr_all = value; }
        }



        public Camera(int cam_number)
        {
            _cam_number = cam_number;
            _video_grab = new Mat();
        }
        /*
        public Camera()
        {
            //_cam_number = Settings.Default.port_camera;
            _cam_number = ds.cam_set;
            _video_grab = new Mat();
        }

        */
        private delegate void UpdateImageDelegate(Image<Bgr, byte> _img, bool _invalid);
        private void UpdateImage(Image<Bgr, byte> _img, bool _invalid)
        {
            if (_my_imagebox.InvokeRequired)
            {
                try
                {
                    UpdateImageDelegate uid = new UpdateImageDelegate(UpdateImage);
                    _my_imagebox.BeginInvoke(uid, new object[] { _img, _invalid });
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                
                _my_imagebox.Image = _img.Resize(_my_imagebox.ClientSize.Width, _my_imagebox.ClientSize.Height, Emgu.CV.CvEnum.Inter.Nearest);
                
                if (_invalid)
                {
                    _my_imagebox.Invalidate();
                }

            }
        }

        private delegate void UpdateGrabbedDelegate(Image<Bgr, byte> _img);
        private void UpdateGrabbed(Image<Bgr, byte> _img)
        {
            if (_my_grabbox.InvokeRequired)
            {
                try
                {
                    UpdateGrabbedDelegate ugd = new UpdateGrabbedDelegate(UpdateGrabbed);
                    _my_grabbox.BeginInvoke(ugd, new object[] { _img });
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                //Streaming Video
                //_my_grabbox.Image = _img.Resize(_my_grabbox.ClientSize.Width, _my_grabbox.ClientSize.Height, Emgu.CV.CvEnum.Inter.Nearest);



            }
        }

        private delegate void UpdateFilterDelegate(Image<Gray, byte> _img);
        private void UpdateFilter(Image<Gray, byte> _img)
        {
            if (_my_filterbox.InvokeRequired)
            {
                try
                {
                    UpdateFilterDelegate ufd = new UpdateFilterDelegate(UpdateFilter);
                    _my_filterbox.BeginInvoke(ufd, new object[] { _img });
                }
                catch { }
            }
            else
            {
                _my_filterbox.Image = _img;
            }
        }

        private bool CheckResult(int _area)
        {
            bool _result = false;
            if (_area > 0)
            {
                if (_area >= _area_min)
                {
                    _result = false;    //Tanda putih
                }
                else
                {
                    _result = true;     //Ga ada Tanda putih
                }
            }
            else
            {
                _result = false;    //Ga ada product karna harusnya detect tulisannya
            }
            UpdateResult(_area, _result);
            return _result;
        }
        private delegate void UpdateResultDelegate(int _area, bool _result);
        private void UpdateResult(int _area, bool _result)
        {
            
            if (_lbl_result_area.InvokeRequired || _lbl_result_lamp.InvokeRequired)
            {
                try
                {
                    UpdateResultDelegate urd = new UpdateResultDelegate(UpdateResult);
                    _lbl_result_area.BeginInvoke(urd, new object[] { _area, _result });
                    _lbl_result_lamp.BeginInvoke(urd, new object[] { _area, _result });
                }
                catch { }
            }
            else
            {
                _lbl_result_area.Text = _area.ToString();
                if (_result)
                {
                    _lbl_result_lamp.Text = "OK";
                    _lbl_result_lamp.BackColor = _color_pass;
                    _lbl_result_area.ForeColor = _color_pass;
                }
                else
                {
                    _lbl_result_lamp.Text = "ROTATE";
                    _lbl_result_lamp.BackColor = _color_fail;
                    _lbl_result_area.ForeColor = _color_fail;
                }
            }
            
        }
        public void Connect()
        {
            if (_video_live == null)
            {
                if (!_cam_connect)
                {
                    try
                    {
                        SetupCapture();
                        //_video_live.Start();
                        _video_live.Start();
                        _video_live.ImageGrabbed += ImageGrab; 
                        _cam_connect = true;
                        _cam_live = true;
                        _vision_busy = false;
                        _vision_result = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                Disconnect();
            }
        }

        /*
         * Thread Running for Grab Image-------------------------------------------------------------------
         */
        bool _resizeImg = false;
        private void ImageGrab(object sender, EventArgs e)
        {
            if (_video_live != null && _video_live.Ptr != IntPtr.Zero)
            {
                try
                {
                    if (_vision_process)
                    {

                        _video_live.Retrieve(_video_grab, 0);
                       // _video_grab = new _video_live.QueryFrame();
                        _image_grabbed1 = _video_grab.ToImage<Bgr, byte>();
                        _image_grabbed = _image_grabbed1.Resize(_my_imagebox.ClientSize.Width, _my_imagebox.ClientSize.Height, Emgu.CV.CvEnum.Inter.Nearest);
                        //_image_grabbed = _image_grabbed.Resize(_my_imagebox.ClientSize.Width, _my_imagebox.ClientSize.Height, Emgu.CV.CvEnum.Inter.Nearest);
                    }

                    if (_vision_process)
                    {
                        if (_setup)
                        {
                            if (_cam_live)
                            {
                                _image_snap = _image_grabbed;
                            }
                            if (_roi_rect != Rectangle.Empty && _image_snap != null)
                            //if (_roi_rect == roi_rect && _image_snap != null)
                            {
                                ProcessImage();
                            }
                            else
                            {
                                UpdateImage(_image_snap, false);
                            }
                        }
                        else
                        {
                            UpdateGrabbed(_image_grabbed);
                        }

                    }
                    else
                    {
                        if (!_setup)
                        {
                            UpdateGrabbed(_image_grabbed);
                        }
                        else
                        {
                            if (_cam_live)
                            {
                                _image_snap = _image_grabbed;
                            }
                            if (_image_snap != null)
                            {
                                UpdateImage(_image_snap, false);
                            }
                        }

                    }
                }
                catch { }
            }
        }

        public void Capture()
        {
            Thread.Sleep(10);
            
            _image_snap = _image_grabbed;
            if (_roi_rect != Rectangle.Empty && _image_snap != null)
            {
                if (_roi_rect == roi_rect)
                {
                    ProcessImage();
                }
            }
        }

        public void Disconnect()
        {
            if (_video_live != null)
            {
                if (_cam_connect)
                {
                    try
                    {
                        _video_live.Pause();
                        _cam_connect = false;
                        _video_live.Dispose();
                        _cam_live = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void SetupCapture()
        {
            if (_video_live != null) _video_live.Dispose();
            try
            {
                _video_live = new VideoCapture(_cam_number, VideoCapture.API.DShow);
                _video_live.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.AutoExposure, 0.25);
                _video_live.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.Exposure, -1);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Image<Bgr, byte> img_snap;
        Image<Gray, byte> img_gray;
        Image<Gray, byte> threshold;
        Mat mat_result = new Mat();
        VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
        public void ProcessImage()
        {
            //if (_roi_rect == Rectangle.Empty && _roi_rect == roi_rect)
            if (_roi_rect == Rectangle.Empty || _roi_rect != roi_rect)
            {
                return;
            }
            try
            {
                Thread.Sleep(60);
                _vision_busy = true;
                _image_process = _image_snap.Copy();
                

                Gray gray_min = new Gray(_filter_min);
                Gray gray_max = new Gray(_filter_max);
                _image_process.ROI = _roi_rect;

                img_snap = _image_process.Copy();
                //img_snap = img_snap.SmoothGaussian(5);

                img_gray = img_snap.Convert<Gray, byte>();
                CvInvoke.Threshold(img_gray, img_gray, area_min, 255, Emgu.CV.CvEnum.ThresholdType.Otsu);
                threshold = img_gray.InRange(gray_min, gray_max);


                var filtered = threshold.SmoothGaussian(1);
                
                if (_setup)
                {
                    UpdateFilter(filtered);
                } 

                CvInvoke.FindContours(filtered, contours, mat_result, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
                double[] areas = new double[contours.Size];
                for (int i = 0; i < contours.Size; i++)
                {
                    double area = CvInvoke.ContourArea(contours[i]);
                    areas[i] = area;
                }

                double max = areas.Max();
                int pos = Array.IndexOf(areas, max);
                result_area = Convert.ToInt32(max);

                bool check = CheckResult(result_area);

                var img_result = img_gray.Convert<Bgr, byte>();

                if (check)
                {
                    CvInvoke.DrawContours(img_result, contours, pos, _scalar_pass, 2);
                    _vision_result = true;
                    if (!_setup)
                    {
                        _cntr_pass++;
                    }
                }
                else
                {
                    CvInvoke.DrawContours(img_result, contours, pos, _scalar_fail, 2);
                    _vision_result = false;
                    if (!_setup)
                    {
                        _cntr_fail++;
                    }
                }

                _cntr_all++;

                _image_process.SetValue(new Bgr(1, 1, 1));
                _image_process._Mul(img_result);
                _image_process.ROI = Rectangle.Empty;
                //_image_process.ROI = _roi_rect;

                if (!_setup)
                {
                    _image_process.Draw(_roi_rect, new Bgr(Color.DeepSkyBlue), 2);
                }
                UpdateImage(_image_process, true);
                
            }
            catch //(Exception ex)
            {

            }
        }
    }
}
