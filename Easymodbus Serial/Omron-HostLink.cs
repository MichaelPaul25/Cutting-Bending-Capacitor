using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using Easymodbus_Serial.Properties;

namespace Easymodbus_Serial
{
    enum Mode
    {
        Manual,
        Auto
    }

    enum motor_Mode1
    {
        Idle,
        Home,
        Alarm,
        Run
    }


    class Omron_HostLink
    {
        public Thread plc_loop;

        //Device_Setup ds = new Device_Setup();
        //private Form1 mainForm = new Form1();

        private SerialPort omron_serial= new SerialPort();
        private string omron_port;

        private Label[] _lamp;
        private Label[] _memoryLabel;
        private Button[] _buttons;
        private bool[] _sensor;
        private bool[] _output;
        private bool[] _memory;
        private bool[] _statusReset;
        private bool[] _statusMove;
        //------Address 203-------//
        private bool _capture, _pickComponent, _resultPolarityNormal,
            _resultPolarityNegative, _moveToRotate_, _placeNormal,
            _placeWrongPolarity, _captureResult, _FinishmovePick,
            _FinishmoveToCutAfterRot, _FinishmoveToCut, _FinishmovetoRotate,
            _movetoPick;
        private bool _polarityNG, _polarityOK;

        private Color _color_pass = Color.Lime;
        private Color _color_fail = Color.Red;

        private Color _color_pressed = Color.Coral;
        private Color _color_idle = Color.White;

        private Mode _mode;
        private motor_Mode _motorMode;

        private bool[] input, output;

        private bool WriteOutput = false;
        private string CommandWrite = "";

        private bool _vision_trigger;
        private bool _vision_busy;
        private bool _vision_busy_ack;
        private bool _vision_result;
        private bool _vision_result_ack;
        private string _plcPort;
        private bool _grip1, _grip2Unclamp, _grip2, _rotate, _movetoCutAfterRotate,
            _cutting, _detect, _statusFinishMovePick,
            _statusFinishMoveRotate, _statusFinishMoveCut, _moveToRotate;
        private bool _emg, _reset;
        private bool _runStart, _runFinish;

        public bool IsOpen { get { return omron_serial.IsOpen; } }

        public bool M_runFinish
        {
            get { return _runFinish; }
            set { _runFinish = value; }
        }

        public bool M_runStart
        {
            get { return _runStart; }
            set { _runStart = value; }
        }

        public bool M_reset
        {
            get { return _reset; }
            set { _reset = value; }
        }

        public bool M_emg
        {
            get { return _emg; }
            set { _emg = value; }
        }

        public bool M_movetoPick
        {
            get { return _movetoPick; }
            set { _movetoPick = value; }
        }

        public bool M_rotate
        {
            get { return _rotate; }
            set { _rotate = value; }
        }

        public bool M_grip2Unclamp
        {
            get { return _grip2Unclamp; }
            set { _grip2Unclamp = value; }
        }

        public bool M_cutting
        {
            get { return _cutting; }
            set { _cutting = value; }
        }

        public bool M_statusFinishMovePick
        {
            get { return _statusFinishMovePick; }
            set { _statusFinishMovePick = value; }
        }

        public bool M_placeNormal
        {
            get { return _placeNormal; }
            set { _placeNormal = value; }
        }

        public bool M_moveToRotate
        {
            get { return _moveToRotate; }
            set { _moveToRotate = value; }
        }

        public bool M_movetoCutAfterRotate
        {
            get { return _movetoCutAfterRotate; }
            set { _movetoCutAfterRotate = value; }
        }


        public bool M_statusFinishMoveRotate
        {
            get { return _statusFinishMoveRotate; }
            set { _statusFinishMoveRotate = value; }
        }

        public bool M_statusFinishMoveCut
        {
            get { return _statusFinishMoveCut; }
            set { _statusFinishMoveCut = value; }
        }

        public bool M_grip1
        {
            get { return _grip1; }
            set { _grip1 = value; }
        }
        public bool M_polarityNG
        {
            get { return _polarityNG; }
            set { _polarityNG = value; }
        }

        public bool M_polarityOK
        {
            get { return _polarityOK; }
            set { _polarityOK = value; }
        }

        public bool M_captureResult
        {
            get { return _captureResult; }
            set { _captureResult = value; }
        }
        public bool M_pickComponent
        {
            get { return _pickComponent; }
            set { _pickComponent = value; }
        }

        public bool M_FinishmovePick
        {
            get { return _FinishmovePick; }
            set { _FinishmovePick = value; }
        }

        public bool M_FinishmoveToCut
        {
            get { return _FinishmoveToCut; }
            set { _FinishmoveToCut = value; }
        }

        public bool M_FinishmoveToCutAfterRot
        { 
            get { return _FinishmoveToCutAfterRot; }
            set { _FinishmoveToCutAfterRot = value; }
        }

        public bool M_FinishmovetoRotate
        {
            get { return _FinishmovetoRotate; }
            set { _FinishmovetoRotate = value; }
        }

        public SerialPort portPLC
        {
            get { return omron_serial; }
            set { omron_serial = value; }
        }

        public bool[] memoryPLC
        {
            get { return _memory; }
            set { _memory = value; }
        }

        public bool[] inputSensor
        {
            get{ return _sensor; }
            set { _sensor = value; }
        }

        public bool[] outputAkuator
        {
            get { return _output; }
            set { _output = value; }
        }

        public Label[] lamp
        {
            get { return _lamp; }
            set { _lamp = value; }
        }

        public Label[] labelMemory
        {
            get { return _memoryLabel; }
            set { _memoryLabel = value; }
        }

        public Button[] buttons
        {
            get { return _buttons; }
            set { _buttons = value; }
        }

        public bool vision_trigger
        {
            get { return _vision_trigger; }
            set { _vision_trigger = value; }
        }
        public bool vision_busy
        {
            get { return _vision_busy; }
            set { _vision_busy = value; }
        }
        public bool vision_busy_ack
        {
            get { return _vision_busy_ack; }
            set { _vision_busy_ack = value; }
        }
        public bool vision_result
        {
            get { return _vision_result; }
            set { _vision_result = value; }
        }

        public string plc_Port
        {
            get;set;
            //get { return _plcPort; }
            //set { _plcPort = value; }
        }

        public Mode machine
        {
            get { return _mode; }
            set { _mode = value; }
        }

        public motor_Mode Motor
        {
            get { return _motorMode; }
            set { _motorMode = value; }
        }

        enum CommandMode
        {
            Write,
            Read
        }
        enum CommandMemory
        {
            CIO,
            LR,
            HR,
            DM
        }

        public void OpenPLC()
        {
            try
            {
                //omron_port = "COM13";
                omron_port = plc_Port;
                if (plc_Port == null)
                {
                    omron_port = Settings.Default.portPLC;
                }
                omron_serial = new SerialPort(omron_port, 9600, Parity.Even, 7, StopBits.Two);
                
                omron_serial.Handshake = Handshake.None;
                omron_serial.DtrEnable = true;
                omron_serial.RtsEnable = true;
                omron_serial.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        //MANUAL
        public void mainManual()
        {
            
            try
            {
                omron_port = Settings.Default.portPLC;
                if(omron_port == "")
                {
                    MessageBox.Show("Please Select PLC Com First!");
                    return;
                }
                omron_serial = new SerialPort(omron_port, 9600, Parity.Even, 7, StopBits.Two);
                omron_serial.Open();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return;
            }
            
            try
            {
                while (true)
                {
                    input = ReadSingleCIO(206);
                    //UpdateLamp(input);
                    bool[] temp = new bool[11];
                    temp[0] = input[0];
                    temp[1] = input[1];
                    temp[2] = input[2];
                    temp[3] = input[3];
                    temp[4] = input[4];
                    temp[5] = input[5];
                    temp[6] = input[6];
                    temp[7] = input[7];
                    temp[8] = input[8];
                    temp[9] = input[9];
                    temp[10] = input[10];
                    UpdateLamp(temp);
                    //output = ReadSingleCIO(100);
                    output = ReadSingleCIO(207);
                    UpdateButton(output);

                    if (WriteOutput)
                    {

                        omron_serial.Write(CommandWrite);
                        bool[] _result = WaitResponse(CommandWrite, false);
                        CommandWrite = "";
                        WriteOutput = false;
                    }

                    Thread.Sleep(10);
                }
            }
            catch 
            { //MessageBox.Show(ex.Message);
            }
            
          
        }

        int delaySent = 5;
        int sentPLC = 0;
        //AUTO
        public void main()
        {
            
            try
            {
                while (true)
                {
                    /*
                    if (machine == Mode.Manual)
                    {
                        WriteSingleCIO(211, 0, true);
                        input = ReadSingleCIO(206);
                        //UpdateLamp(input);
                        bool[] temp = new bool[10];
                        temp[0] = input[0];
                        temp[1] = input[1];
                        temp[2] = input[2];
                        temp[3] = input[3];
                        temp[4] = input[4];
                        temp[5] = input[5];
                        temp[6] = input[6];
                        temp[7] = input[7];
                        temp[8] = input[8];
                        temp[9] = input[9];
                        UpdateLamp(temp);
                        output = ReadSingleCIO(207);
                        UpdateButton(output);

                        if (WriteOutput)
                        {

                            omron_serial.Write(CommandWrite);
                            bool[] _result = WaitResponse(CommandWrite, false);
                            CommandWrite = "";
                            WriteOutput = false;
                        }
                    }
                    */
                    if (machine == Mode.Auto)
                    {

                        read_all_address();

                        vision_trigger = _capture;

                        if (_capture)
                        {

                        }

                        //M_runFinish
                        //M_runStart
                        

                        if (M_reset)
                        {
                            WriteSingleCIO(201, 8, true);
                            Thread.Sleep(delaySent);
                            M_reset = false;
                        }

                        if (M_runStart && !M_runFinish)
                        {
                            while (M_polarityNG && sentPLC == 0)
                            {
                                WriteSingleCIO(203, 7, true);
                                sentPLC = 1;
                                break;
                            }

                            while (!M_polarityNG && sentPLC == 1)
                            {
                                WriteSingleCIO(203, 7, false);
                                sentPLC = 2;
                                break;
                            }
                        }

                        if (M_runStart && !M_runFinish)
                        {
                            while (M_polarityOK && sentPLC == 0)
                            {
                                WriteSingleCIO(203, 6, true);
                                sentPLC = 1;
                                break;
                            }

                            while (!M_polarityOK && sentPLC == 1)
                            {
                                WriteSingleCIO(203, 6, false);
                                sentPLC = 2;
                                break;
                            }
                        }
                        /*
                        //Reset Condition of Polarity Result
                        if (!M_runStart && M_runFinish)
                        {
                            while (!M_polarityNG && sentPLC == 2)
                            {
                                WriteSingleCIO(203, 7, false);
                                //sentPLC = 0;
                                break;
                            }

                            while (!M_polarityOK && sentPLC == 2)
                            {
                                WriteSingleCIO(203, 6, false);
                                //sentPLC = 0;
                                break;
                            }
                        }
                        */

                        if (!M_runStart && M_runFinish)
                        {
                            sentPLC = 0;
                        }
                        Thread.Sleep(1);
                    }

                }
            }
            catch(Exception ex) 
            {
                //MessageBox.Show(ex.Message);
            }
            
        }

        private void read_all_address()
        {
            try
            {
                //-------------SENSOR--------------//
                _sensor = ReadSingleCIO(206);
                if(_sensor==null)
                {
                    return;
                }
                bool[] _sens = new bool[11];
                //M_grip1 = _sensor[1];
                _sens[0] = _sensor[0];
                _sens[1] = _sensor[1];
                _sens[2] = _sensor[2];
                _sens[3] = _sensor[3];
                _sens[4] = _sensor[4];
                _sens[5] = _sensor[5];
                _sens[6] = _sensor[6];
                _sens[7] = _sensor[7];
                _sens[8] = _sensor[8];
                _sens[9] = _sensor[9];
                _sens[10] = _sensor[10];
                

                bool[] temp1 = new bool[2];
                temp1[0] = _sens[9];
                temp1[1] = _sens[10];
                UpdateLamp(temp1);


                _grip2Unclamp = _sens[2];
                _grip1 = _sens[1];
                _cutting = _sens[7];
                _rotate = _sens[4];
                
                M_grip2Unclamp = _grip2Unclamp;
                M_grip1 = _grip1;
                M_cutting = _cutting;
                M_rotate = _rotate;
                
                _memory = ReadSingleCIO(203);

                bool kosong;
                if (_memory.Length < 16)
                {
                    return;
                }
                kosong = _memory[0];
                _capture = _memory[1];
                
                bool[] temp = new bool[11];
                kosong = _memory[0];
                temp[0] = _memory[1];
                
                UpdateMemory(temp);

                //_statusReset = ReadSingleCIO(201);
                //M_reset = _statusReset[8];

            }
            catch//(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void RunningMCU(DataGridView dt, SerialPort sp)
        {
            //---------------TABLE PNP---------------//
            #region Table PNP

            for (int r = 0; r < dt.Rows.Count - 1; r++)
            {
                string _id = "", x = "", _speed = "";
                int count = 0;
                bool _pickDown = false, _placeDown = false;

                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    if (c == 0)
                    {
                        _id = dt.Rows[r].Cells[0].Value.ToString();
                        
                    }

                    if (c == 1)
                    {
                        x = dt.Rows[r].Cells[1].Value.ToString();
                    }

                    if (c == 2)
                    {
                        _speed = dt.Rows[r].Cells[2].Value.ToString();
                    }


                    if (c == 2 && x != null && _speed != null)
                    {
                        //_move = true;

                        if (_pickDown)
                        {
                            sp.WriteLine("M42" + "\n");
                        }

                        //sp.WriteLine("G90G21G01" + "X" + x
                        sp.WriteLine("G91G21" + "X" + x
                            + "F" + _speed + "\n");
                        //Thread.Sleep(100);
                        if (_placeDown)
                        {
                            sp.WriteLine("M43");
                        }
                        if (_pickDown == true || _placeDown == true)
                        {
                            //Send Delay
                            sp.WriteLine("G4P0.3" + "\n");
                        }


                        count++;
                        //labelCount.Text = count.ToString();
                        _pickDown = false;
                        _placeDown = false;
                    }
                }
                #endregion PNP


            }
        }

        public void Displaytext(string text, Button b, Color c)
        {
            b.Text = text;
            b.BackColor = c;
        }

        private delegate void UpdateMemoryDelegate(bool[] _value);
        private void UpdateMemory(bool[] _value)
        {
            if (_memoryLabel.Length > _value.Length)
            {
                return;
            }
            for (int i = 0; i < _memoryLabel.Length; i++)
            {
                if (_memoryLabel[i].InvokeRequired)
                {
                    try
                    {
                        UpdateMemoryDelegate urd = new UpdateMemoryDelegate(UpdateMemory);
                        _memoryLabel[i].BeginInvoke(urd, new object[] { _value });
                    }
                    catch (Exception ex) { }
                }
                else
                {
                    if (_value[i])
                    {
                        _memoryLabel[i].BackColor = _color_pass;
                    }
                    else
                    {
                        _memoryLabel[i].BackColor = _color_fail;
                    }
                }
            }
        }


        private delegate void UpdateLampDelegate(bool[] _value);
        private void UpdateLamp(bool[] _value)
        {
            if (_lamp.Length > _value.Length)
            {
                return;
            }
            for (int i = 0; i < _lamp.Length; i++)
            {
                if (_lamp[i].InvokeRequired)
                {
                    try
                    {
                        UpdateLampDelegate urd = new UpdateLampDelegate(UpdateLamp);
                        _lamp[i].BeginInvoke(urd, new object[] { _value });
                    }
                    catch (Exception ex) { }
                }
                else
                {
                    if (_value[i])
                    {
                        _lamp[i].BackColor = _color_pass;
                    }
                    else
                    {
                        _lamp[i].BackColor = _color_fail;
                    }
                }
            }
        }

        private delegate void UpdateButtonDelegate(bool[] _value);
        private void UpdateButton(bool[] _value)
        {
            if (_buttons.Length > _value.Length)
            {
                return;
            }
            for (int i = 0; i < _buttons.Length; i++)
            {
                if (_buttons[i].InvokeRequired)
                {
                    try
                    {
                        UpdateButtonDelegate urd = new UpdateButtonDelegate(UpdateButton);
                        _buttons[i].BeginInvoke(urd, new object[] { _value });
                    }
                    catch (Exception ex) { }
                }
                else
                {
                    if (_value[i])
                    {
                        _buttons[i].FlatAppearance.BorderColor = _color_pressed;
                    }
                    else
                    {
                        _buttons[i].FlatAppearance.BorderColor = _color_idle;
                    }
                }
            }
        }

        

        public void close()
        {
            
            if (omron_serial.IsOpen)
            {
                omron_serial?.Close();
                omron_serial?.Dispose();

            }
            if (plc_loop != null)
            //if (plc_loop.IsAlive)
            {
                plc_loop.Abort();

            }
            
            //omron_serial.Close();
        }

        public bool[] ReadSingleCIO(int _address)
        {
            string _cmd = CommandBuilder(CommandMode.Read, CommandMemory.CIO, _address, "1");
            omron_serial.Write(_cmd);
            bool[] _result = WaitResponse(_cmd, true);
            return _result;
        }

        public void UpdateSingleCIO(int _address, int _bit)
        {
            if(!omron_serial.IsOpen)
            {
                MessageBox.Show("PLC Not Connect");
                return;
            }
            WriteOutput = true;
            bool[] curr_mem = output;
            curr_mem[_bit] = !curr_mem[_bit];
            byte[] _bytes = BoolArrayToByteArray(curr_mem);
            string _hex = ByteArrayToHexString(_bytes);
            CommandWrite = CommandBuilder(CommandMode.Write, CommandMemory.CIO, _address, _hex);
        }

        public void WriteSingleCIO(int _address, int _bit, bool _value)
        {
            bool[] curr_mem = new bool[16];
            curr_mem[_bit] = _value;
            byte[] _bytes = BoolArrayToByteArray(curr_mem);
            string _hex = ByteArrayToHexString(_bytes);
            string _cmd = CommandBuilder(CommandMode.Write, CommandMemory.CIO, _address, _hex);
            omron_serial.Write(_cmd);
            bool[] _result = WaitResponse(_cmd, false);
        }

        private bool[] WaitResponse(string _cmd, bool _parse)
        {
            int timeout = 0;
            bool serial = false;
            string response_data = "";
            List<string> parsed_data = new List<string>();
            bool[] _result = new bool[1];
            while (true)
            {
                try
                {
                    char data = (char)omron_serial.ReadChar();
                    if (data == '@')
                    {
                        serial = true;
                    }
                    if (serial)
                    {
                        response_data += data;
                    }
                    if (data == '\r')
                    {
                        serial = false;
                        //if (_parse)
                        if (_parse)
                        {
                            bool result = ResponseParse(_cmd, response_data, ref parsed_data);
                            byte[] arr = HexStringToByteArray(parsed_data.ElementAt(0));
                            bool[] bit = ByteArrayToBoolArray(arr);
                            return bit;
                            if (!result)
                            {
                                MessageBox.Show("RESULT = FALSE!");
                            }
                            else
                            {
                                MessageBox.Show("RESULT = TRUE!");
                            }
                        }
                        else
                        {
                            return _result;
                        }
                    }

                    if (timeout >= 3000)
                    {
                        return _result;
                        break;
                    }
                    Thread.Sleep(8);
                    //Thread.Sleep(7);
                    timeout++;
                }
                catch 
                {
                    //MessageBox.Show(ex.Message);
                    return _result;
                    break;
                }
            }
        }

        string ReadSingleLine(string path)
        {
            string data;
            try
            {
                StreamReader sr = new StreamReader(path);
                data = sr.ReadLine();
                sr.Close();
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //Read
        byte[] HexStringToByteArray(string raw)
        {
            byte[] byte_array = new byte[raw.Length / 2];
            for (int i = 0; i < byte_array.Length; i++)
            {
                string raw_split = raw.Substring(raw.Length - (2 * (i + 1)), 2);
                byte_array[i] = byte.Parse(raw_split, System.Globalization.NumberStyles.AllowHexSpecifier);
            }
            return byte_array;
        }

        bool[] ByteArrayToBoolArray(byte[] raw)
        {

            bool[] b = new bool[raw.Length * 8];
            for (int j = 0; j < raw.Length; j++)
            {
                for (int i = 0; i < 8; ++i)
                {
                    b[i + (j * 8)] = (raw[j] & (1 << i)) != 0;
                }

            }
            return b;
        }


        //Write
        byte[] BoolArrayToByteArray(bool[] raw)
        {
            byte[] b = new byte[raw.Length / 8];
            for (int j = 0; j < b.Length; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    b[b.Length - 1 - j] |= Convert.ToByte((Convert.ToByte(raw[(j * 8) + i]) << (byte)i));
                }
            }
            return b;
        }

        string ByteArrayToHexString(byte[] raw)
        {
            string hex = "";
            for (int i = 0; i < raw.Length; i++)
            {
                hex += raw[i].ToString("X2");
            }
            return hex;
        }
        string CommandBuilder(CommandMode mode, CommandMemory mem, int start_address, string data)
        {
            string str_mode = "", str_mem = "", str_cmd = "";
            string cmd_header = "@00";
            string str_count = "";
            string str_fcs = "00";
            switch (mode)
            {
                case CommandMode.Read: str_mode = "R"; break;
                case CommandMode.Write: str_mode = "W"; break;
                default: str_mode = "R"; break;
            }
            switch (mem)
            {
                case CommandMemory.CIO: str_mem = "R"; break;
                case CommandMemory.DM: str_mem = "D"; break;
                case CommandMemory.HR: str_mem = "H"; break;
                case CommandMemory.LR: str_mem = "L"; break;
                default: str_mem = "R"; break;
            }

            str_cmd = cmd_header + str_mode + str_mem + start_address.ToString("D4");

            if (mode == CommandMode.Read)
            {
                int int_data = Convert.ToInt32(data);
                str_count = int_data.ToString("D4");
                str_cmd += str_count;
            }
            else if (mode == CommandMode.Write)
            {
                str_cmd += data;
            }
            str_fcs = FCSCalculation(str_cmd);
            str_cmd += (str_fcs + "*\r\n");

            return str_cmd;
        }

        bool ResponseParse(string cmd, string response, ref List<string> data_out)
        {
            List<string> result = new List<string>();
            string response_fcs = FCSCalculation(response.Substring(0, response.Length - 4));
            if (response.Substring(response.Length - 4, 2) != response_fcs)
            {
                return true;
            }
            if (cmd.Substring(0, 5) != response.Substring(0, 5))
            {
                return true;
            }
            if (response.Substring(5, 2) != "00")
            {
                return true;
            }
            int count = Convert.ToInt32(cmd.Substring(9, 4));
            string raw_data = response.Substring(7, 4 * count);
            for (int i = 0; i < count; i++)
            {
                result.Add(raw_data.Substring(i * 4, 4));
            }

            //---------Tambahan
            //if(data_out.Count != 1)
            ///{
            if (result.Count == 0)
            {
                MessageBox.Show("Data == 0");
            }
            data_out = result;   
            //}
            
            return false;
        }

        private string FCSCalculation(string cmd)
        {
            char[] cmd_charArray = cmd.ToCharArray();
            byte FCSCheck = 0x00;
            string FCSHex = "";
            for (int i = 0; i < cmd_charArray.Length; i++)
            {

                FCSCheck ^= Convert.ToByte(cmd_charArray[i]);
            }
            FCSHex = FCSCheck.ToString("X2");
            if (FCSHex.Length < 2)
            {
                FCSHex = "0" + FCSHex;
                return FCSHex;
            }
            else if (FCSHex.Length > 2)
            {
                FCSHex = "00";
            }

            return FCSHex;
        }
    }
}
