using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading.Tasks;
using Easymodbus_Serial.Properties;

namespace Easymodbus_Serial
{
    class Serial
    {
        #region Variable
        private SerialPort _serialport;// = new SerialPort();
        private TextBox _textBoxStatus, _textBoxStatus1;
        private TextBox _textBoxXpos, _textBoxXpos1;
        private Button _buttonhome;
        private TextBox _textboxreceivedata;
        private CheckBox _checkboxverbose;
        private string _xpos, _status;
        private bool _polling = false;
        private bool _verbose = false;
        private bool _moveDone;
        String[] input_Split;
        private StreamWriter Log;
        private Thread WorkerThread;
        private Stream Connection;
        int BufferState = 0;
        public bool IsOpen { get { return _serialport.IsOpen; } }

        private void RecordLog(string message)
        {
            if(Log != null)
            {
                try
                {
                    Log.WriteLine(message);
                }
                catch { throw; }
            }
        }

        public bool moveDone
        {
            get { return _moveDone; }
            set { _moveDone = value; }
        }

        public void readStatus(TextBox tx1)
        {
            tx1.Text = _status;
        }

        public bool verbose
        {
            get { return _verbose; }
            set { _verbose = value; }
        }


        public string XPOS
        {
            get { return textBox_Xpos.Text; }
            set { textBox_Xpos.Text = value; }
        }

        public string STATUSMCU
        {
            get { return _status; }
            set { _status = value; }
        }

        public TextBox textBox_Xpos1
        {
            get { return _textBoxXpos1; }
            set { _textBoxXpos1 = value; }
        }

        public TextBox textBox_Xpos
        {
            get { return _textBoxXpos; }
            set { _textBoxXpos = value; }
        }

        public TextBox textbox_Status
        {
            get { return _textBoxStatus; }
            set { _textBoxStatus = value; }
        }
        public TextBox textbox_Status1
        {
            get { return _textBoxStatus1; }
            set { _textBoxStatus1 = value; }
        }
        public SerialPort serial_Port
        {
            get { return _serialport; }
            set { _serialport = value; }
        }

        public bool M_Polling
        {
            get { return _polling; }
            set { _polling = value; }
        }

        public Button button_Home
        {
            get { return _buttonhome; }
            set { _buttonhome = value; }
        }

        public TextBox textbox_receive_Data
        {
            get { return _textboxreceivedata; }
            set { _textboxreceivedata = value; }
        }

        public CheckBox checkBox_Verbose
        {
            get { return _checkboxverbose; }
            set { _checkboxverbose = value; }
        }

        Queue Sent = Queue.Synchronized(new Queue());
        Queue ToSent = Queue.Synchronized(new Queue());
        Queue ToSendPriority = Queue.Synchronized(new Queue());
        Queue ToSendMacro = Queue.Synchronized(new Queue());

        #endregion Variable

        public void data_received()
        {
            _serialport.DataReceived += new SerialDataReceivedEventHandler(dataReceived);
        }
        
        public void hardResetCommand(string cmd)
        {

            if (!serial_Port.IsOpen)
            {
                MessageBox.Show("Serial Port Is Close!");
                return;
            }
            serial_Port.WriteLine(cmd);
        }

        public void sendCommand(string cmd)
        {
            
            if(!serial_Port.IsOpen)
            {
                MessageBox.Show("Serial Port Is Close!");
                return;
            }
            StreamWriter writer = new StreamWriter(Connection);
            while (ToSendPriority.Count>0)
            {
                writer.Write((char)ToSendPriority.Dequeue());
                writer.Flush();
            }

            writer.Write(cmd + "\n");
            writer.Flush();
            BufferState += cmd.Length + 1;
            Sent.Enqueue(cmd);
        }

        public void moveToPick(string cord)
        {
            
            if (!serial_Port.IsOpen)
            {
                return;
            }
            StreamWriter writer = new StreamWriter(Connection);
            while (ToSendPriority.Count > 0)
            {
                writer.Write((char)ToSendPriority.Dequeue());
                writer.Flush();
            }
            while (true)
            {
                //writer.WriteLine("G01G21X" + cord + "F7000");
                //cord = ((string)ToSent.Dequeue()).Replace(" ", "");
                writer.Write("G0X" + cord + "\n");
                writer.Write("M62P2" + "\n");
                writer.Write("G4P0.5" + "\n");
                writer.Write("M63P2" + "\n");
                writer.Flush();
                //_serialport.WriteLine("G01G21X" + cord + "F1000" + "\r" + "\n");
                BufferState += cord.Length + 1;
                Sent.Enqueue(cord);
                moveDone = true;
                break;
            }
        }

        public void moveTo(string cord)
        {
           
            if (!serial_Port.IsOpen)
            {
                return;
            }

            StreamWriter writer = new StreamWriter(Connection);
            while (ToSendPriority.Count > 0)
            {
                writer.Write((char)ToSendPriority.Dequeue());
                writer.Flush();
            }
            while (true)
            {
                writer.Write("G0X" + cord + "\n");
                writer.Flush();
                BufferState += cord.Length + 1;
                Sent.Enqueue(cord);
                moveDone = true;
                break;
            }
        }

        public void moveTopickAfterRotate(string cord)
        {
            
            if (!serial_Port.IsOpen)
            {
                return;
            }
            StreamWriter writer = new StreamWriter(Connection);
            while (ToSendPriority.Count > 0)
            {
                writer.Write((char)ToSendPriority.Dequeue());
                writer.Flush();
            }
            while (true)
            {
                //writer.WriteLine("G01G21X" + cord + "F7000");
                //cord = ((string)ToSent.Dequeue()).Replace(" ", "");
                writer.Write("G0X" + cord + "\n");
                writer.Write("M62P1" + "\n");
                writer.Write("G4P0.5" + "\n");
                writer.Write("M63P1" + "\n");
                writer.Flush();
                //_serialport.WriteLine("G01G21X" + cord + "F1000" + "\r" + "\n");
                BufferState += cord.Length + 1;
                Sent.Enqueue(cord);
                moveDone = true;
                break;
            }
        }

        public void moveToCutFinish(string cord)
        {
            
            if (!serial_Port.IsOpen)
            {
                return;
            }
            StreamWriter writer = new StreamWriter(Connection);
            while (ToSendPriority.Count > 0)
            {
                writer.Write((char)ToSendPriority.Dequeue());
                writer.Flush();
            }
            while (true)
            {
                //writer.WriteLine("G01G21X" + cord + "F7000");
                //cord = ((string)ToSent.Dequeue()).Replace(" ", "");
                writer.Write("G0X" + cord + "\n");
                writer.Write("M62P0" + "\n");
                writer.Write("G4P0.5" + "\n");
                writer.Write("M63P0" + "\n");
                writer.Flush();
                //_serialport.WriteLine("G01G21X" + cord + "F1000" + "\r" + "\n");
                BufferState += cord.Length + 1;
                Sent.Enqueue(cord);
                moveDone = true;
                break;
            }
        }

        private void _checkboxverbose_CheckStateChanged(object sender, EventArgs e)
        {
            if (_checkboxverbose.Checked)
            {
                _verbose = true;
            }
            else
                _verbose = false;
        }


        private void dataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (_serialport.IsOpen)
            {
                
                string input1 = string.Empty;
                //input1 = _serialport.ReadLine();
                input1 = _serialport.ReadLine();

                if (_verbose)
                {
                    _textboxreceivedata.ForeColor = Color.Black;
                    _textboxreceivedata.Text += input1 + "\r\n";
                }
                
                if (input1.StartsWith("Grbl"))
                {
                    MessageBox.Show("Initialization");

                    _polling = true;
                }
                /*
                if (Sent.Count != 0)
                {
                    BufferState -= ((string)Sent.Dequeue()).Length + 1;
                }
                */
                if (M_Polling)
                {
                    pollingFunction();
                }
                

                //string input = serialPort.ReadLine();
                input_Split = input1.Split(new Char[] { ',', '|', ':', '<', '>' });
                Console.WriteLine(input1);
                Console.WriteLine("Buffer before= " + BufferState);
                if (input1.Contains('<'))
                {
                    //MessageBox.Show("Start Split");
                    foreach (string split_ in input_Split)
                    {
                        split_Data(input_Split);
                        //split_Data();
                    }

                    if (_status == "Alarm")
                    {
                        _buttonhome.BackColor = Color.Red;

                    }
                    else
                    {
                        _buttonhome.BackColor = Color.Transparent;
                        
                    }
                }

                if (input1.StartsWith("ok"))
                {
                    if (Sent.Count != 0)
                    {
                        BufferState -= ((string)Sent.Dequeue()).Length + 1;
                        Sent.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Received OK without anything in the Sent Buffer");
                        BufferState = 0;
                    }
                }

                Console.WriteLine("Buffer After= " + BufferState);
                

            }
            else
            {
                MessageBox.Show("Please open a serial port");
            }
        }
        bool Connected = false;
        public void connectSerial()
        {
            try
            {
                _serialport = new SerialPort(Settings.Default.portMCU, 115200);
                _serialport.DtrEnable = false;
                _serialport.Open();
                Connection = _serialport.BaseStream;
                Connected = true;

                if (!Connected)
                {
                    return;
                }

                WorkerThread = new Thread(data_received);
                WorkerThread.Priority = ThreadPriority.AboveNormal;
                WorkerThread.Start();
                pollingFunction();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void disconnectSerial()
        {
            if(!_serialport.IsOpen)
            {
                return;
            }
            try
            {
                Connection.Close();
            }
            catch { }
            Connection.Dispose();
            Connection = null;


        }

        public void pollingFunction()
        {
            try
            {
                if (!_serialport.IsOpen)
                {
                    return;
                }

                StreamWriter writer = new StreamWriter(Connection);
                TimeSpan waitTime = TimeSpan.FromMilliseconds(0.5);
                DateTime LastStatusPoll = DateTime.Now + TimeSpan.FromSeconds(0.5);
                DateTime Now = DateTime.Now;

                

                if(!M_Polling)
                {
                    return;
                }

                while (ToSendPriority.Count > 0)
                {
                    writer.Write((char)ToSendPriority.Dequeue());
                    writer.Flush();
                }
                
                writer.Write('?');
                writer.Flush();
                Console.WriteLine("Sent Polling");
                LastStatusPoll = Now;

                Thread.Sleep(waitTime);
                //Thread.Sleep(1000);
                //}

                //}
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*
            if (_serialport.IsOpen)
            {
                Thread.Sleep(500);
                _serialport.WriteLine("?");
            }
            */
        }

        private void split_Data(string[] datainput)
        {
            string[] input = datainput;
            _status = input[1];
            _xpos = input[3];
            //_textBoxStatus.Text = _status;
            //_textBoxXpos.Text = _xpos;
            _textBoxXpos1.Text = _xpos;
            _textBoxStatus1.Text = _status;
            
        }

    }
}
