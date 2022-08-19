using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DirectShowLib;
using System.IO;
using System.IO.Ports;
using Easymodbus_Serial.Properties;
using Emgu.CV.UI;

namespace Easymodbus_Serial
{
    enum motor_Mode
    {
        Idle,
        Home,
        Alarm,
        Jog,
        Run
    }
    public partial class Form1 : Form
    {
        #region VARIABLE
        //Device_Setup ds = new Device_Setup();
        private SerialPort serialPort = new SerialPort();
        private SerialPort portPLC = new SerialPort();
        //MySerialPort Port = new MySerialPort();
        private Serial _Port = new Serial();
        private Omron_HostLink omron = new Omron_HostLink();

        public string port_plc;
        public string port_mcu;
        private string _status, _xpos;

        DsDevice[] _systemCamera;
        VideoDevice[] _cameras;

        private int _cam_number;
        Camera cam;
        int cam_number;
        private int _cam_port;
        private string _port_plc;
        private string _port_mcu;
        private string _baudrate;
        bool cam_trigger = false;
        bool trigger_difu = false;
        private bool _verbose = false;
        private bool[] _sensorInput;
        private bool[] _outputAkuator;
        private bool[] _memoryAdd;
        DataTable dt = new DataTable();
        string _pick, _placeNormal, _movetoRotate, _placePolarity;
        string[] send_Data;
        bool tab0 = false, tab1 = false;
        bool setCam = false, setPLC = false, setMCU = false, _run = false,
            _reset = false, _stop = false, _polarityNG = false, _alarm = false;

        Thread my_thread;

        Label[] my_lamp;
        Label[] my_memory;

        bool import_Data = false;
        int index_Row;
        private bool _startPolling = false;

        bool setROI = false;
        bool mouse = false;
        Point start_point = new Point(0, 0);
        Point end_point = new Point(0, 0);
        Size roi_size = new Size(0, 0);
        Rectangle roi_rect;

        #endregion VARIABLE

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; //Disable cross-thread checking
        }
        #region Device Setup

        private void Serial_Init()
        {
            serialPort.Close();
            portPLC.Close();
            my_lamp = new Label[]
            {
                lamp_part,
                lamp_bowl

            };

            my_memory = new Label[]
            {
                labelCapture,
            };

            omron.lamp = my_lamp;
            omron.labelMemory = my_memory;
            omron.machine = Mode.Auto;
            omron.portPLC = portPLC;
            omron.inputSensor = _sensorInput;
            omron.outputAkuator = _outputAkuator;
            omron.memoryPLC = _memoryAdd;

            _Port.serial_Port = serialPort;
            _Port.textbox_receive_Data = textBoxReceive;
            _Port.checkBox_Verbose = checkBox1;
            _Port.verbose = _verbose;
            _Port.textbox_Status1 = textBoxStatus1;
            _Port.textBox_Xpos1 = textBoxX1;

            _Port.button_Home = buttonAlarm;
            _Port.textbox_receive_Data = textBoxReceive;


        }



        private void Init_Port_Confs()
        {
            _reset = omron.M_reset;
            comboBoxPLC.Items.Clear();
            //comboBoxMCU.Text = "";
            comboBoxMCU.Items.Clear();
            //comboBoxCam.Text = "";
            comboBoxCam.Items.Clear();

            //---------------CAMERA--------------//
            _systemCamera = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            _cameras = new VideoDevice[_systemCamera.Length];
            for (int i = 0; i < _systemCamera.Length; i++)
            {
                _cameras[i] = new VideoDevice(i, _systemCamera[i].Name, _systemCamera[i].ClassID);
                comboBoxCam.Items.Add(_cameras[i].Device_Name);
            }
            comboBoxCam.SelectedIndex = 0;


            string[] str = SerialPort.GetPortNames();
            if (str == null)
            {
                MessageBox.Show("The machine has no serial port！", "Error");
                return;
            }

            //COM Ports
            foreach (string s in str)
            {
                comboBoxPLC.Items.Add(s);
                comboBoxMCU.Items.Add(s);
            }

            //comboBoxMCU.SelectedIndex = 0;
            //comboBoxPLC.SelectedIndex = 0;


            string[] baudRate = { "115200", "9600", "19200", "38400", "57600" };
            foreach (string s in baudRate)
            {
                comboBoxPLCBaud.Items.Add(s);
                comboBoxMCUBaud.Items.Add(s);
            }
            comboBoxPLCBaud.SelectedIndex = 1;
            comboBoxMCUBaud.SelectedIndex = 0;

            for (int i = 0; i < comboBoxCam.Items.Count; i++)
            {
                if (_cam_port > 0)
                {
                    comboBoxCam.SelectedIndex = _cam_port;
                }
                else
                {
                    comboBoxCam.SelectedIndex = 0;
                }
            }


            for (int i = 0; i < comboBoxPLC.Items.Count; i++)
            {
                if (_port_plc == comboBoxPLC.Items[i].ToString())
                {
                    comboBoxPLC.SelectedIndex = i;
                }
                else
                {
                    comboBoxPLC.SelectedIndex = 0;
                }
            }

            //---------------------- CREATE NEW PRODUCT------------------------------//

            comboBoxMatric.Items.Clear();
            comboBoxRate.Items.Clear();
            comboBoxID.Items.Clear();
            comboBoxProduct.Items.Clear();

            string[] matric = { "100", "50", "10", "1", "0.1", "0.01" };
            //comboBoxMatric.SelectedIndex = 1;
            foreach (string s in matric)
            {

                comboBoxMatric.Items.Add(s);
            }
            comboBoxMatric.SelectedIndex = 3;

            //Feed Rate Configuration
            string[] feed_Rate = { "100", "500", "1000", "5000", "10000" };
            //comboBoxMatric.SelectedIndex = 1;
            foreach (string s in feed_Rate)
            {
                comboBoxRate.Items.Add(s);
            }
            comboBoxRate.SelectedIndex = 1;

            //Pick
            string[] marking = { "Pick", "Place Normal", "Move to Rotate", "Place Polarity" };
            foreach (string s in marking)
            {
                comboBoxID.Items.Add(s);
            }
            comboBoxID.SelectedIndex = 0;

            string[] product_list = File_Handler.PopulateProduct();
            comboBoxProduct.Items.Clear();
            comboBoxProduct.Items.AddRange(product_list);

            groupBoxSetPLC.Enabled = false;
            groupBoxSetMCU.Enabled = false;
            buttonRUN.Enabled = false;
            buttonRESET.Enabled = false;
            buttonStop.Enabled = false;
            buttonHome.Enabled = false;
            buttonAlarm.Enabled = false;
            buttonResetCounter.Enabled = false;

            comboBoxMCU.SelectedText = "COM4";
        }


        private void buttonCamera_Click(object sender, EventArgs e)
        {
            setCam = true;
            _cam_number = comboBoxCam.SelectedIndex;
            setupCam();
            omron.Displaytext("Camera Has Been Set", statusProcess, Color.AliceBlue);

            groupBoxSetPLC.Enabled = true;
        }


        bool connectPLC = false;
        private void buttonConnectPLC_Click(object sender, EventArgs e)
        {

            try
            {
                if (!omron.IsOpen)
                {
                    /*
                    _port_plc = comboBoxPLC.SelectedItem.ToString();
                    omron.plc_Port = _port_plc;
                    omron.OpenPLC();
                    buttonConnectPLC.Text = "Disconnect";
                    connectPLC = true;
                    omron.Displaytext("PLC Was Connect", statusProcess, Color.LimeGreen);
                    setPLC = true;
                    Settings.Default.portPLC = _port_plc;
                    Settings.Default.Save();
                    
                    groupBox1.Enabled = true;
                    */
                    startPLCandCAM();
                }
                else
                {
                    /*
                    omron.close();
                    buttonConnectPLC.Text = "Connect";
                    connectPLC = false;

                    omron.Displaytext("PLC Was Disconnect", statusProcess, Color.IndianRed);
                    setPLC = false;

                    if (cam.cam_connect)
                    {
                        cam.Disconnect();
                    }
                    */
                    disconnectPLCandCAM();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void disconnectPLCandCAM()
        {
            omron.close();
            buttonConnectPLC.Text = "Connect";
            connectPLC = false;

            omron.Displaytext("PLC and Camera Was Disconnect", statusProcess, Color.Red);
            setPLC = false;

            

            buttonConnectPLC.Text = "Connect";
            connectPLC = false;

            lamp_part.BackColor = Color.Red;
            lamp_bowl.BackColor = Color.Red;

            labelCapture.BackColor = Color.Red;

            if (cam == null)
            {
                return;
            }

            if (cam.cam_connect)
            {
                cam.Disconnect();
            }

        }

        private void buttonConnectMCU_Click(object sender, EventArgs e)
        {
            if (comboBoxMCU.SelectedText == null)
            {
                omron.Displaytext("Please Select Com First", statusProcess, Color.IndianRed);
                return;
            }

            if (comboBoxMCU.SelectedItem == comboBoxPLC.SelectedItem)
            {
                omron.Displaytext("Cannot Connect Same COM as PLC!", statusProcess, Color.OrangeRed);
                comboBoxMCU.Text = "";
                return;
            }

            _port_mcu = comboBoxMCU.Text.ToString();
            _baudrate = comboBoxMCUBaud.SelectedItem.ToString();


            if (!setMCU)
            {
                connectMCU();
                
            }
            else
            {
                disconnectMCU();
                
            }

        }

        private void connectMCU()
        {
            setMCU = true;
            Settings.Default.portMCU = _port_mcu;
            Settings.Default.Save();

            _Port.connectSerial();

            buttonConnectMCU.Text = "Disconnect";
            omron.Displaytext("Please Press Alarm", statusProcess, Color.LimeGreen);
            Thread.Sleep(100);
            buttonAlarm.BackColor = Color.Red;
            buttonAlarm.Enabled = true;
            buttonHome.Enabled = true;

        }

        private void disconnectMCU()
        {
            _Port.disconnectSerial();
            buttonConnectMCU.Text = "Connect";
            omron.Displaytext("MCU Was Disconnect", statusProcess, Color.IndianRed);
            setMCU = false;
        }

        #endregion Device Setup
        private void buttonRUN_Click(object sender, EventArgs e)
        {
            if (cam == null)
            {
                MessageBox.Show("Please Start Cam First!", "Camera Not Connected",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!omron.IsOpen)
            {
                MessageBox.Show("Please Connect PLC First!", "PLC Not Connected",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!setMCU)
            {
                MessageBox.Show("Please Connect MCU First!", "MCU Not Connected",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lbl_product.Text == "" || lbl_product.Text == "Trial")
            {
                MessageBox.Show("Please Select Model First!", "Model Not Selected",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (cam != null && omron.IsOpen && setMCU)
            {
                _run = true;
                buttonStop.Enabled = true;
                buttonRUN.Enabled = false;
                buttonResetCounter.Enabled = true;
                omron.Displaytext("System Running", statusProcess, Color.LimeGreen);
                //groupBoxSetCam.Enabled = false;
                groupBoxSetMCU.Enabled = false;
                groupBoxSetPLC.Enabled = false;
                _alarm = false;
            }
        }


        bool has_capture = false;
        private void main_loop()
        {
            while (true)
            {
                /*
                _reset = omron.M_reset;
                if (omron.M_reset && !_alarm)
                {
                    omron.Displaytext("Please Select Reset Button To Release!", statusProcess, Color.Red);
                    buttonRUN.Enabled = false;
                    buttonRUN.Enabled = false;
                    hardReset();
                }
                */
                if (_run)
                {


                    if (omron.M_reset)
                    {
                        trigger_difu = false;
                        has_capture = false;
                        omron.Displaytext("Reset System", statusProcess, Color.Transparent);
                    }
                    if (lbl_product.Text != "" && lbl_product.Text != "Trial")
                    {
                        //Part detection
                        if (omron.vision_trigger && !trigger_difu)
                        {
                            cam_trigger = true;
                            trigger_difu = true;
                            imgbox_snap.Image = imgbox_live.Image;  //img snap = img live
                            //_moveto = false;
                            Thread.Sleep(10);

                        }
                        else if (!omron.vision_trigger && trigger_difu)
                        {
                            trigger_difu = false;
                        }
                    }

                    //Capture object
                    if (cam_trigger && !has_capture && trigger_difu && omron.M_grip2Unclamp)
                    {
                        cam.Capture();
                        cam_trigger = false;
                        omron.M_captureResult = true;
                        has_capture = true;
                        Thread.Sleep(100);
                    }
                    rotateCond();

                    try
                    {
                        if (cam.vision_busy)
                        {
                            omron.vision_busy = true;
                            //lamp_busy.BackColor = Color.Lime;
                        }

                        if (omron.vision_busy_ack)
                        {
                            cam.vision_busy = false;
                            //lamp_busy.BackColor = Color.Red;
                            omron.vision_busy_ack = false;
                        }


                        omron.vision_result = cam.vision_result;
                        UpdateCounter(cam.cntr_pass, cam.cntr_fail, cam.cntr_all);

                    }

                    catch (Exception ex) { }
                    Thread.Sleep(10);
                }
            }

        }

        
        private void rotateCond()
        {
            int delyAll = 15;
            bool _moveto = false;
            bool _go = false, _go1 = false, _go2 = false;
            if (setMCU && _run)
            {
                string _result = lbl_lamp.Text;

                while (has_capture)
                {
                    omron.M_runStart = true;
                    omron.M_runFinish = false;
                    if (_result == "OK")
                    {
                        omron.M_polarityOK = true;
                        omron.M_polarityNG = false;
                        break;
                    }
                    if (_result == "ROTATE")
                    {
                        omron.M_polarityOK = false;
                        omron.M_polarityNG = true;
                        break;
                    }
                }

                while (_polarityNG && trigger_difu && !_moveto && has_capture && omron.M_grip2Unclamp && !omron.M_rotate)
                {
                    if (!omron.M_rotate )
                    {
                        _polarityNG = false;
                        break;
                    }
                }

                //-----------Move To Rotate (Release) -------//
                while (_polarityNG && trigger_difu && !_moveto && has_capture && omron.M_grip2Unclamp )//&& omron.M_rotate)
                {
                    while (!_go1)
                    {
                        _Port.moveTopickAfterRotate(_movetoRotate);
                        _go1 = true;
                        break; 
                    }
                    if (!omron.M_rotate && _go1)
                    {
                        _polarityNG = false;
                        _go1 = false;
                        break;
                    }
                    else if (_reset)
                    {
                        _reset = false;
                        _go1 = false;
                        break;
                    }

                }

                


                    while (_result == "OK" && trigger_difu && !_moveto && has_capture && omron.M_grip2Unclamp && !_polarityNG)
                {
                    while (!_go)
                    {
                        _Port.moveToPick(_pick);
                        _go = true;
                        break;
                    }

                    Thread.Sleep(delyAll);
                    while (omron.M_grip1)
                    {
                        while (!_go1)
                        {
                            //Thread.Sleep(delyAll);
                            _Port.moveToCutFinish(_placeNormal);
                            _go1 = true;
                            break;
                        }
                        Thread.Sleep(delyAll);
                        if (omron.M_cutting)
                        {
                            //omron.M_movetoPick = true;
                            trigger_difu = false;
                            _moveto = true;
                            has_capture = false;

                            omron.M_runStart = false;
                            omron.M_runFinish = true;

                            omron.M_polarityOK = false;
                            omron.M_polarityNG = false;
                            _polarityNG = false;
                            Thread.Sleep(delyAll);


                            break;
                        }

                    }
                    if (_moveto || _reset) {
                        _reset = false;
                        break; }
                }

                //Rotate Condition
                while (_result == "ROTATE" && trigger_difu && !_moveto && has_capture && omron.M_grip2Unclamp && !_polarityNG)
                {
                    while (!_go)
                    {
                        Thread.Sleep(100);
                        _Port.moveToPick(_pick);
                        //Thread.Sleep(20);
                        _go = true;
                        break;
                    }
                    Thread.Sleep(delyAll);
                    //while (omron.M_grip1)
                    while (!omron.M_grip2Unclamp)
                    {
                        while (!_go1)
                        {
                            _Port.moveTopickAfterRotate(_movetoRotate);
                            _go1 = true;
                            break;
                        }
                        Thread.Sleep(delyAll);
                        while (omron.M_rotate)
                        {
                            Thread.Sleep(delyAll);
                            while (!_go2)
                            {
                                _Port.moveToCutFinish(_placePolarity);
                                _go2 = true;

                                break;
                            }

                            if (omron.M_cutting)
                            {

                                trigger_difu = false;
                                _moveto = true;
                                has_capture = false;

                                omron.M_runStart = false;
                                omron.M_runFinish = true;

                                omron.M_polarityOK = false;
                                omron.M_polarityNG = false;
                                //Thread.Sleep(delyAll);
                                _polarityNG = true;
                                break;
                            }

                        }
                        if (_moveto || _reset)
                        {
                            break;
                        }

                    }
                    if (_moveto || _reset)
                    {
                        _reset = false;
                        break;
                    }

                }
            }
        }

        async Task PutTaskDelay(int ms)
        {
            await Task.Delay(ms);
        }

        private delegate void UpdateCounterDelegate(int _pass, int _fail, int _all);
        private void UpdateCounter(int _pass, int _fail, int _all)
        {
            if (lbl_pass.InvokeRequired || lbl_fail.InvokeRequired)
            {
                try
                {
                    UpdateCounterDelegate uid = new UpdateCounterDelegate(UpdateCounter);
                    this.BeginInvoke(uid, new object[] { _pass, _fail, _all });
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                lbl_pass.Text = _pass.ToString("D5");
                lbl_fail.Text = _fail.ToString("D5");
                lblCounter.Text = _all.ToString("D5");
            }
        }

        /*
        private void cameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            CameraSetting cs = new CameraSetting();
            cs.Owner = this;
            cs.Show();
        }
        */
        private void buttonStop_Click(object sender, EventArgs e)
        {
            omron.Displaytext("Stop Running", statusProcess, Color.Red);
            buttonRUN.Enabled = true;
            buttonStop.Enabled = false;
            imgbox_snap.Image = null;
            _run = false;
            groupBoxSetCam.Enabled = true;
            groupBoxSetMCU.Enabled = true;
            groupBoxSetPLC.Enabled = true;
        }
        
        private void Frm_plc_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (omron == null)
            {
                omron.lamp = my_lamp;
                omron.machine = Mode.Auto;
                omron.OpenPLC();
                omron.plc_loop = new Thread(new ThreadStart(omron.main));
                omron.plc_loop.Start();
            }
        }

        private void selectProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cam == null)
            {
                MessageBox.Show("Please Start Camera First!", "Camera Not Start",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Selected_Product frm_product = new Selected_Product();
                var result = frm_product.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string product_name = frm_product.product;
                    lbl_product.Text = product_name;
                    int[] value = File_Handler.LoadProduct(product_name);
                    Rectangle loaded_rect = new Rectangle(value[0], value[1], value[2], value[3]);
                    cam.roi_rect = loaded_rect;
                    cam.filter_min = value[4];
                    cam.filter_max = value[5];
                    cam.area_min = value[6];
                    File_Handler.LoadcsvData(product_name, dataGridView1, dt, index_Row);
                    getXpos();
                    omron.Displaytext("Product Has Been Selected", statusProcess, Color.AliceBlue);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do You Want Exit The Application?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            /*
            try
            {

                if (setMCU)
                {
                    _Port.disconnectSerial();
                    setMCU = false;
                }

                if (cam != null)
                {
                    cam.Disconnect();
                }

                if (connectPLC)
                {
                    omron.close();
                }

                if (cam != null && connectPLC)
                {
                    omron.plc_loop.Abort();
                    my_thread.Abort();
                }


            }
            catch
            {
                //MessageBox.Show(ex.Message);
            }
            */
            this.Close();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Serial_Init();
                Init_Port_Confs();

                //my_thread = new Thread(new ThreadStart(main_loop));
                //my_thread.Start();


                Control.CheckForIllegalCrossThreadCalls = false;

                //serialPort.DataReceived += new SerialDataReceivedEventHandler(dataReceived);

                //Ready              
                serialPort.DtrEnable = true;
                serialPort.RtsEnable = true;
                //Set data read timeout to 1 second
                serialPort.WriteTimeout = 2500;
                serialPort.ReadTimeout = 2500;

                serialPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            omron.Displaytext("Welcome" + " " + "Please Set Camera", statusProcess, Color.AliceBlue);
        }



        /*
        private void microcontrollerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingMCU st = new SettingMCU();
            st.Owner = this;
            st.Show();
        }
        */

        //Button Alarm
        private void buttonHome_Click(object sender, EventArgs e)
        {
            _alarm = true;
            Reset_Cond();
            buttonRUN.Enabled = true;
            buttonRESET.Enabled = true;

            
            omron.M_reset = true;

            buttonAlarm.BackColor = Color.Transparent;
            //_alarm = false;
        }

        private void Reset_Cond()
        {
            _Port.sendCommand("$X");
            Thread.Sleep(500);
            _Port.sendCommand("$H");
            _Port.moveTo("120");
            omron.Displaytext("Wait Until Robot Ready", statusProcess, Color.LimeGreen);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //serialPort.Close();
            /*
            if(serialPort.IsOpen)
            {
                serialPort.Close();
                _Port.Close();
            }
            */
            /*
            if(_Port.IsOpen)
            {
                serialPort.Close();
                _Port.Close();
            }
            */
            //_Port.closing();
            //_Port.Close();

            try
            {

                if (setMCU)
                {
                    _Port.disconnectSerial();
                    setMCU = false;
                }

                if (cam != null)
                {
                    cam.Disconnect();
                }

                if (connectPLC)
                {
                    omron.close();
                }
                /*
                if (cam != null && connectPLC)
                {
                    omron.plc_loop.Abort();
                    my_thread.Abort();
                }
                */
                if(omron.plc_loop != null)
                {
                    if(omron.plc_loop.IsAlive)
                    {
                        omron.plc_loop.Abort();
                    }
                }

                if(my_thread != null)
                {
                    if(my_thread.IsAlive)
                    {
                        my_thread.Abort();
                    }
                }


            }
            catch
            {
                //MessageBox.Show(ex.Message);
            }
        }


        private void textBoxReceive_TextChanged_1(object sender, EventArgs e)
        {
            textBoxReceive.SelectionStart = textBoxReceive.Text.Length;
            textBoxReceive.ScrollToCaret();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            omron.plc_loop = new Thread(new ThreadStart(omron.main));
            omron.plc_loop.Start();
        }

        private void buttonHome_Click_1(object sender, EventArgs e)
        {
            _Port.sendCommand("$H");
            omron.Displaytext("Robot Homing", statusProcess, Color.LimeGreen);
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }


        private void buttonStartCam_Click(object sender, EventArgs e)
        {

            if (cam.cam_connect)
            {
                cam.Disconnect();
            }

            cam.M_streamCam = true;
            Thread.Sleep(500);

            //cam.my_grabbox = imgbox_live;
            cam = new Camera(_cam_number);

            cam.my_imagebox = imageBoxCreate;
            cam.my_filterbox = imageBox4;
            cam.lbl_result_area = labelarea2;
            cam.lbl_result_lamp = labelresult2;
            cam.vision_process = true;
            cam.show_filterbox = true;
            cam.setup = true;
            cam.Connect();
            checkBoxLive.Checked = cam.cam_live;
            checkBoxImageProc.Checked = cam.vision_process;

        }

        private void imageBoxCreate_MouseDown(object sender, MouseEventArgs e)
        {
            if (setROI)
            {
                start_point.X = e.X;
                start_point.Y = e.Y;
                mouse = true;
            }
        }

        private void imageBoxCreate_Move(object sender, EventArgs e)
        {

        }

        private void imageBoxCreate_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                end_point.X = e.X;
                end_point.Y = e.Y;
                roi_size.Width = end_point.X - start_point.X;
                roi_size.Height = end_point.Y - start_point.Y;
                roi_rect = new Rectangle(start_point, roi_size);
                ((ImageBox)sender).Invalidate();
            }
        }

        private void imageBoxCreate_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                cam.roi_rect = roi_rect;
                mouse = false;
                setROI = false;
                buttonSetROI.FlatAppearance.BorderColor = Color.White;
            }
        }

        private void buttonSetROI_Click(object sender, EventArgs e)
        {
            setROI = true;
            buttonSetROI.FlatAppearance.BorderColor = Color.Orange;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void trackBarGraymin_Scroll(object sender, EventArgs e)
        {
            cam.filter_min = trackBarGraymin.Value;
            labelMin.Text = trackBarGraymin.Value.ToString();
        }

        private void trackBarGraymax_Scroll(object sender, EventArgs e)
        {
            cam.filter_max = trackBarGraymax.Value;
            labelMax.Text = trackBarGraymax.Value.ToString();
        }

        private void trackBarThreshold_Scroll(object sender, EventArgs e)
        {
            cam.area_min = trackBarThreshold.Value;
            labelThreshold.Text = trackBarThreshold.Value.ToString();
        }

        private void checkBoxImageProc_CheckedChanged(object sender, EventArgs e)
        {
            cam.vision_process = checkBoxImageProc.Checked;
        }

        private void checkBoxLive_CheckedChanged(object sender, EventArgs e)
        {
            cam.cam_live = checkBoxLive.Checked;
        }

        private void imageBoxCreate_Paint(object sender, PaintEventArgs e)
        {
            if (imageBoxCreate.Image != null)
            {
                if (roi_rect != null && roi_rect.Width > 0 && roi_rect.Height > 0)
                {

                    e.Graphics.SetClip(roi_rect, System.Drawing.Drawing2D.CombineMode.Exclude);
                    e.Graphics.DrawRectangle(new Pen(Color.GreenYellow, 4), roi_rect);
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(128, 64, 64, 64)), new Rectangle(0, 0, ((ImageBox)sender).Width, ((ImageBox)sender).Height));
                }
            }
        }

        private void buttonXMin_Click(object sender, EventArgs e)
        {

            _Port.sendCommand("$J=G91G21X-" + comboBoxMatric.Text + "F" + comboBoxRate.Text);
        }

        private void buttonXPlus_Click(object sender, EventArgs e)
        {
            //Thread.Sleep(100);
            _Port.sendCommand("$J=G91G21X" + comboBoxMatric.Text + "F" + comboBoxRate.Text);
        }
        int count = 0;

        private void buttonInsert1_Click(object sender, EventArgs e)
        {
            string id = comboBoxID.Text;
            string x = textBoxX1.Text;
            string speed = comboBoxRate.Text;


            if (import_Data)
            {
                //index_Row = index_Row + 1;
                DataRow row;

                try
                {
                    row = dt.NewRow();
                    row[index_Row] = dt.Rows.Add(id, x, speed);
                }
                catch { }

                index_Row++;
                row = dt.NewRow();
                //index_Row += index_Row;
                dataGridView1.DataSource = dt;
                //import_Data = false;
            }
            else
            {
                dataGridView1.DataSource = null;

                if (dataGridView1.RowCount == 0)
                {
                    dataGridView1.ColumnCount = 3;
                    dataGridView1.Columns[0].Name = "ID";
                    dataGridView1.Columns[1].Name = "X";
                    dataGridView1.Columns[2].Name = "Speed";
                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[1].HeaderText = "X";
                    dataGridView1.Columns[2].HeaderText = "Speed";
                }

                count++;
                if (count == 1)
                {
                    id = "Pick";
                }
                if (count == 2)
                {
                    id = "Place Normal";
                }
                if (count == 3)
                {
                    id = "Move to Rotate";
                }
                if (count == 4)
                {
                    id = "Place Polarity";
                    count = 0;
                }

                dataGridView1.Rows.Add(id, x, speed);
            }
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                _verbose = true;
            }
            else
            {
                _verbose = false;
            }
        }

        private void buttonClearRow_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            string x, speed;

            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            x = dr.Cells[1].Value.ToString();
            speed = dr.Cells[2].Value.ToString();

            string[] colums = { x, speed };
            send_Data = colums;
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            new_modelSave();
        }

        string[] array = new string[3];

        private void new_modelSave()
        {

            int[] value = new int[] {
                cam.roi_rect.X,
                cam.roi_rect.Y,
                cam.roi_rect.Width,
                cam.roi_rect.Height,
                cam.filter_min,
                cam.filter_max,
                cam.area_min
            };



            File_Handler.SaveProduct(textBoxInputModel.Text, value);
            File_Handler.SaveToCSV(dataGridView1, textBoxInputModel.Text);
            string[] product_list = File_Handler.PopulateProduct();
            textBoxInputModel.Clear();
            comboBoxProduct.Items.AddRange(product_list);
        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cam == null)
            {
                MessageBox.Show("Please Start Camera First!");
            }
            else
            {
                //LoadProduct();
                int[] value = File_Handler.LoadProduct(comboBoxProduct.SelectedItem.ToString());
                trackBarGraymin.Value = value[4];
                trackBarGraymax.Value = value[5];
                trackBarThreshold.Value = value[6];
                Rectangle loaded_rect = new Rectangle(value[0], value[1], value[2], value[3]);
                cam.roi_rect = loaded_rect;
                cam.filter_min = trackBarGraymin.Value;
                cam.filter_max = trackBarGraymax.Value;
                cam.area_min = trackBarThreshold.Value;

                labelMin.Text = trackBarGraymin.Value.ToString();
                labelMax.Text = trackBarGraymax.Value.ToString();
                labelThreshold.Text = trackBarThreshold.Value.ToString();

                File_Handler.LoadcsvData(comboBoxProduct.SelectedItem.ToString(), dataGridView1, dt, index_Row);
                getXpos();
            }
        }

        private void buttonRESET_Click(object sender, EventArgs e)
        {
            hardReset();
        }

        private void hardReset()
        {
            omron.Displaytext("Reset System", statusProcess, Color.YellowGreen);
            //buttonRUN.Enabled = true;
            buttonStop.Enabled = false;
            imgbox_snap.Image = null;
            _run = false;
            _reset = true;
            groupBoxSetCam.Enabled = true;
            groupBoxSetMCU.Enabled = true;
            groupBoxSetPLC.Enabled = true;

            omron.M_reset = true;
            Thread.Sleep(50);
            _Port.hardResetCommand("$X");
            Thread.Sleep(250);
            _Port.hardResetCommand("$H");
            Thread.Sleep(500);
            omron.Displaytext("Press Alarm and PLC Reset Button!", statusProcess, Color.YellowGreen);
            omron.Displaytext("Please Press Alarm", statusProcess, Color.LimeGreen);
            buttonAlarm.BackColor = Color.Red;
            buttonRUN.Enabled = false;
        }

        private void setupCam()
        {
            //Start Camera
            cam = new Camera(_cam_number);
            //cam = new Camera(1);
            cam.my_grabbox = imgbox_live;
            //cam.my_grabbox = imageBoxCreate;
            cam.my_imagebox = imgbox_snap;
            cam.my_filterbox = imageBox4;
            cam.lbl_result_area = lbl_area;
            cam.lbl_result_lamp = lbl_lamp;
            cam.vision_process = true;
            cam.setup = false;
            cam.Connect();
        }

        private void startPLCandCAM()
        {
            _port_plc = comboBoxPLC.SelectedItem.ToString();
            if(_port_plc == "COM4")
            {
                omron.Displaytext("Cannot Connect To MCU PORT!", statusProcess, Color.Red);
                return;
            }
            omron.plc_Port = _port_plc;
            omron.OpenPLC();
            buttonConnectPLC.Text = "Disconnect";
            connectPLC = true;
            omron.Displaytext("PLC Was Connect", statusProcess, Color.LimeGreen);
            setPLC = true;
            Settings.Default.portPLC = _port_plc;
            Settings.Default.Save();

            groupBoxSetMCU.Enabled = true;

            //Start Camera
            cam = new Camera(_cam_number);
            cam.my_grabbox = imgbox_live;
            cam.my_imagebox = imgbox_snap;
            cam.my_filterbox = imageBox4;
            cam.lbl_result_area = lbl_area;
            cam.lbl_result_lamp = lbl_lamp;
            cam.vision_process = true;
            cam.setup = false;
            cam.Connect();

            if (cam != null && omron.IsOpen)
            {
                omron.plc_loop = new Thread(new ThreadStart(omron.main));
                omron.plc_loop.Start();
                my_thread = new Thread(new ThreadStart(main_loop));
                my_thread.Start();
            }
            
            else if (cam == null)
            {
                MessageBox.Show("Please Setting Cam First!", "Camera Not Connected",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!omron.IsOpen)
            {
                MessageBox.Show("Please Setting PLC First!", "PLC Not Connected",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //timer1.Enabled = true;
            //timer1.Start();
            omron.Displaytext("Camera And PLC Ready", statusProcess, Color.AliceBlue);
            Thread.Sleep(2000);
            //await PutTaskDelay(2500);
            omron.Displaytext("Please Connect MCU", statusProcess, Color.AliceBlue);
        }
        
        private void buttonResetCounter_Click(object sender, EventArgs e)
        {
            cam.cntr_fail = 0;
            cam.cntr_pass = 0;
            cam.cntr_all = 0;
        }

        private void PLCManualStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*
            if (omron == null)
            {
                MessageBox.Show("Please Connect PLC First!", "PLC Not Connected",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            */

            if (connectPLC || setMCU)
            {
                DialogResult result;
                result = MessageBox.Show("Switch To Manual Mode?", "Warning!", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
            }


            if (_port_plc == null)
            {
                _port_plc = Settings.Default.portPLC;
            }

            if(omron != null)
            {
                omron.close();
                connectPLC = false;
            }


            if (cam != null)
            {
                cam.Disconnect();
            }

            disconnectPLCandCAM();
            disconnectMCU();
            groupBoxSetMCU.Enabled = false;
            
            omron.plc_Port = _port_plc;
            Settings.Default.portPLC = _port_plc;
            Settings.Default.Save();
            
            Settings_PLC sPLC = new Settings_PLC();
            sPLC.Owner = this;
            //sPLC.FormClosed += Frm_plc_FormClosed;
            sPLC.Show();
        }

        private void selectModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cam == null)
            {
                //MessageBox.Show("Please Start Camera First!", "Camera Not Start",
                //MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Selected_Product frm_product = new Selected_Product();
                var result = frm_product.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string product_name = frm_product.product;
                    lbl_product.Text = product_name;
                    int[] value = File_Handler.LoadProduct(product_name);
                    Rectangle loaded_rect = new Rectangle(value[0], value[1], value[2], value[3]);
                    cam.roi_rect = loaded_rect;
                    cam.filter_min = value[4];
                    cam.filter_max = value[5];
                    cam.area_min = value[6];
                    File_Handler.LoadcsvData(product_name, dataGridView1, dt, index_Row);
                    getXpos();
                    omron.Displaytext("Product Has Been Selected", statusProcess, Color.AliceBlue);
                }
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonPolling_Click(object sender, EventArgs e)
        {
            if(_startPolling)
            {
                buttonPolling.Text = "Start Polling";
                _Port.M_Polling = false;
                _startPolling = false;
            }
            else
            {
                _Port.M_Polling = true;
                _Port.pollingFunction();
                buttonPolling.Text = "Stop Polling";
                _startPolling = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*
            try
            {

                if (setMCU)
                {
                    _Port.disconnectSerial();
                    setMCU = false;
                }

                if (cam != null)
                {
                    cam.Disconnect();
                }

                if (connectPLC)
                {
                    omron.close();
                }

                if (cam != null && connectPLC)
                {
                    omron.plc_loop.Abort();
                    my_thread.Abort();
                }


            }
            catch
            {
                //MessageBox.Show(ex.Message);
            }
            */
        }

        private void buttonStopCam2_Click(object sender, EventArgs e)
        {
            if (cam.cam_connect)
            {
                
                cam.Disconnect();
                //imageBoxCreate.Image = null;
            }
            //imageBoxCreate.Image = null;
            
        }

        private void buttonHome2_Click(object sender, EventArgs e)
        {
            _Port.sendCommand("$H");
        }
        int _switchTab = 0;
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            /*
            if (tabControl1.SelectedTab == tabPage1)
            {
                MessageBox.Show("TASK LIST PAGE");

            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                MessageBox.Show("SCHEDULE PAGE");
                return;
            }
            */
            if(_switchTab == 1)
            {
                _switchTab = 0;
                return;
            }

            if ((connectPLC || setMCU) && tabControl1.SelectedTab == tabPage2)
            {
                if(tabControl1.SelectedTab == tabPage1)
                {
                    return;
                }
                DialogResult result;
                result = MessageBox.Show("Create New Model?", "Warning!", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    _switchTab = 1;
                    tabControl1.SelectedTab = tabPage1;
                    return;                    
                }
            }

            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        //Your Changes
                        Init_Port_Confs();
                        disconnectPLCandCAM();
                        disconnectMCU();
                        omron.Displaytext("Please Connect Device!", statusProcess, Color.IndianRed);
                        //tab0 = true;
                        break;
                    }
                case 1:
                    {
                        /*
                        if (connectPLC || setMCU)
                        {
                            DialogResult result;
                            result = MessageBox.Show("Create New Model?", "Warning!", MessageBoxButtons.OKCancel);
                            if (result == DialogResult.Cancel)
                            {
                                tabControl1.SelectedTab = tabPage1;
                                return;
                            }
                        }
                        */
                        tabControl2.Enabled = false;
                        groupBox8.Enabled = false;
                        if(cam == null)
                        {
                            MessageBox.Show("Camera Was'nt Set");
                        }
                        if(!setMCU)
                        {
                            MessageBox.Show("MCU Port Was'nt Connect!");
                        }
                        
                        if(cam == null || !setMCU)
                        {
                            omron.Displaytext("Please Connect Camera OR MCU First!", statusProcess, Color.MediumVioletRed);
                            //return;
                        }

                        tabControl2.Enabled = true;
                        groupBox8.Enabled = true;
                        //Your Changes
                        
                        //tab1 = true;
                        break;
                    }
                
            }
            
        }

        private void buttonAlarm2_Click(object sender, EventArgs e)
        {
            _Port.sendCommand("$X");
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            _Port.sendCommand("G01" + "X" + send_Data[1] + "F" + send_Data[2]);
        }

        private void getXpos()
        {

            DataGridView dt1 = dataGridView1;

            for (int r = 0; r < dt1.Rows.Count - 1; r++)
            {
                string x = "";

                for (int c = 0; c < dt1.Columns.Count; c++)
                {

                    if (c == 1)
                    {
                        x = dt1.Rows[r].Cells[1].Value.ToString();

                        if (r == 0)
                        {
                            _pick = x;
                        }
                        if (r == 1)
                        {
                            _placeNormal = x;
                        }
                        if (r == 2)
                        {
                            _movetoRotate = x;
                        }
                        if (r == 3)
                        {
                            _placePolarity = x;
                        }
                    }

                }

            }
            
        }
        

        private void buttonRunningTest_Click(object sender, EventArgs e)
        {
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            
            //comboBoxPLC.Text = "";
            comboBoxPLC.Items.Clear();
            //comboBoxMCU.Text = "";
            comboBoxMCU.Items.Clear();
            //comboBoxCam.Text = "";
            comboBoxCam.Items.Clear();


            _systemCamera = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            _cameras = new VideoDevice[_systemCamera.Length];
            for (int i = 0; i < _systemCamera.Length; i++)
            {
                _cameras[i] = new VideoDevice(i, _systemCamera[i].Name, _systemCamera[i].ClassID);
                comboBoxCam.Items.Add(_cameras[i].Device_Name);
            }

            string[] str = SerialPort.GetPortNames();
            if (str == null)
            {
                MessageBox.Show("The machine has no serial port！", "Error");
                return;
            }


            foreach (string s in str)
            {
                comboBoxMCU.Items.Add(s);
                comboBoxPLC.Items.Add(s);
            }

        }
        
    }
}
