using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Easymodbus_Serial
{
    public partial class Settings_PLC : Form
    {
        Omron_HostLink plc_class = new Omron_HostLink();
        
        public Settings_PLC()
        {
            InitializeComponent();
        }

        private void Settings_PLC_Load(object sender, EventArgs e)
        {
            //plc_class.plc_Port = port;
            Label[] my_lamp = new Label[]
            {
                lamp_gripper_fwd1,
                lamp_gripper_bwd1,
                lamp_gripper_fwd2,
                lamp_gripper_bwd2,
                lamp_rotate_ccw,
                lamp_rotate_cw,
                lamp_cutting_off,
                lamp_cutting_on,
                lampBlow,
                lamp_part,
                lampBowl
            };

            Button[] my_button = new Button[]
            {
                buttonG1ON,
                buttonG2ON,
                buttonRotate,
                buttonCutON,
                buttonBlowON,
                buttonBowlON

            };
            plc_class.lamp = my_lamp;
            plc_class.buttons = my_button;
            plc_class.machine = Mode.Manual;
            /*
            if(plc_class == null)
            {
            plc_class.OpenPLC();
            plc_class.plc_loop = new Thread(new ThreadStart(plc_class.main));
                plc_class.plc_loop.Start();
            }
            */
            //try
            //{
            //plc_class.OpenPLC();
            plc_class.plc_loop = new Thread(new ThreadStart(plc_class.mainManual));
            plc_class.plc_loop.Start();
            /*
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }

        private void Settings_PLC_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (plc_class != null)
            {
                plc_class.close();
            }   
        }
        private void condition(Label l, bool cond)
        {
            if(cond)
            {
                l.BackColor = Color.LimeGreen;
            }
            else
            {
                l.BackColor = Color.IndianRed;
            }
        }

        bool rotate = false;
        bool gripper = false;
        private void btn_rotate_Click(object sender, EventArgs e)
        {
            plc_class.UpdateSingleCIO(207, 02);
            
        }

        private void btn_gripper_Click(object sender, EventArgs e)
        {
            //plc_class.UpdateSingleCIO(210, 3);
            if(gripper)
            {
                //plc_class.UpdateSingleCIO(200, 0);
                plc_class.WriteSingleCIO(201, 1, true);
                gripper = false;
            }
            else
            {
                plc_class.WriteSingleCIO(201, 1, false);
                //plc_class.UpdateSingleCIO(201, 0);
                gripper = true;
            }
        }

        private void btn_tool_Click(object sender, EventArgs e)
        {
            //plc_class.UpdateSingleCIO(210, 1);
            plc_class.UpdateSingleCIO(201, 2);
        }

        private void btn_lifter_Click(object sender, EventArgs e)
        {
            plc_class.UpdateSingleCIO(210, 4);
        }

        private void btn_gantry_Click(object sender, EventArgs e)
        {
            plc_class.UpdateSingleCIO(210, 2);
        }

        private void btn_pin_Click(object sender, EventArgs e)
        {
            plc_class.UpdateSingleCIO(210, 5);
        }

        private void buttonR_OFF_Click(object sender, EventArgs e)
        {
            plc_class.WriteSingleCIO(206, 11, false);
        }

        private void buttonBlowON_Click(object sender, EventArgs e)
        {
            //plc_class.WriteSingleCIO(206, 13, true);
            plc_class.UpdateSingleCIO(207, 04);
        }

        private void buttonBlowOFF_Click(object sender, EventArgs e)
        {
            plc_class.WriteSingleCIO(206, 13, false);
        }

        private void buttonG1ON_Click(object sender, EventArgs e)
        {
            //plc_class.WriteSingleCIO(206, 9, true);
            plc_class.UpdateSingleCIO(207, 0);
        }

        private void buttonG1OFF_Click(object sender, EventArgs e)
        {
            plc_class.WriteSingleCIO(206, 9, false);
        }

        private void buttonCutON_Click(object sender, EventArgs e)
        {
            //plc_class.WriteSingleCIO(206, 12, true);
            plc_class.UpdateSingleCIO(207, 3);
        }

        private void buttonCutOFF_Click(object sender, EventArgs e)
        {
            plc_class.WriteSingleCIO(206, 12, false);
        }

        private void buttonG2ON_Click(object sender, EventArgs e)
        {
            plc_class.UpdateSingleCIO(207, 1);
        }

        private void buttonG2OFF_Click(object sender, EventArgs e)
        {
            plc_class.WriteSingleCIO(206, 10, false);
        }

        private void buttonCaancel_Click(object sender, EventArgs e)
        {
            
            if(plc_class.IsOpen)
            {
                plc_class.close();
            }
            this.Hide();
        }

        private void buttonBowlON_Click(object sender, EventArgs e)
        {
            //plc_class.WriteSingleCIO(206, 14, true);
            plc_class.UpdateSingleCIO(207, 05);
        }

        private void buttonBowlOFF_Click(object sender, EventArgs e)
        {
            //plc_class.WriteSingleCIO(206, 14, false);
        }
    }
}
