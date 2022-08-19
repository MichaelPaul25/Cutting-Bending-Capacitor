
namespace Easymodbus_Serial
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PLCManualStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imgbox_live = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonResetCounter = new System.Windows.Forms.Button();
            this.lbl_product = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_fail = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_area = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_lamp = new System.Windows.Forms.Label();
            this.groupBoxSetPLC = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxPLCBaud = new System.Windows.Forms.ComboBox();
            this.buttonConnectPLC = new System.Windows.Forms.Button();
            this.comboBoxPLC = new System.Windows.Forms.ComboBox();
            this.groupBoxSetCam = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonCamera = new System.Windows.Forms.Button();
            this.comboBoxCam = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lamp_part = new System.Windows.Forms.Label();
            this.labelCapture = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lamp_bowl = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonRESET = new System.Windows.Forms.Button();
            this.imgbox_snap = new Emgu.CV.UI.ImageBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRUN = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.groupBoxSetMCU = new System.Windows.Forms.GroupBox();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonAlarm = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxMCUBaud = new System.Windows.Forms.ComboBox();
            this.buttonConnectMCU = new System.Windows.Forms.Button();
            this.comboBoxMCU = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.statusProcess = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxInputModel = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelarea2 = new System.Windows.Forms.Label();
            this.labelresult2 = new System.Windows.Forms.Label();
            this.imageBox4 = new Emgu.CV.UI.ImageBox();
            this.labelThreshold = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.trackBarThreshold = new System.Windows.Forms.TrackBar();
            this.label23 = new System.Windows.Forms.Label();
            this.trackBarGraymax = new System.Windows.Forms.TrackBar();
            this.label24 = new System.Windows.Forms.Label();
            this.trackBarGraymin = new System.Windows.Forms.TrackBar();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.buttonStopCam2 = new System.Windows.Forms.Button();
            this.buttonStartCam = new System.Windows.Forms.Button();
            this.checkBoxImageProc = new System.Windows.Forms.CheckBox();
            this.buttonSetROI = new System.Windows.Forms.Button();
            this.checkBoxLive = new System.Windows.Forms.CheckBox();
            this.imageBoxCreate = new Emgu.CV.UI.ImageBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonPolling = new System.Windows.Forms.Button();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label35 = new System.Windows.Forms.Label();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.textBoxStatus1 = new System.Windows.Forms.TextBox();
            this.buttonStopTest = new System.Windows.Forms.Button();
            this.buttonRunningTest = new System.Windows.Forms.Button();
            this.buttonAlarm2 = new System.Windows.Forms.Button();
            this.buttonHome2 = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.buttonClearRow = new System.Windows.Forms.Button();
            this.buttonUpload1 = new System.Windows.Forms.Button();
            this.buttonInsert1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxReceiveData = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonClearRecData = new System.Windows.Forms.Button();
            this.textBoxReceive = new System.Windows.Forms.TextBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.comboBoxRate = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.comboBoxMatric = new System.Windows.Forms.ComboBox();
            this.buttonXPlus = new System.Windows.Forms.Button();
            this.buttonXMin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox_live)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBoxSetPLC.SuspendLayout();
            this.groupBoxSetCam.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox_snap)).BeginInit();
            this.groupBoxSetMCU.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGraymax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGraymin)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxCreate)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxReceiveData.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(8, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1745, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectModelToolStripMenuItem,
            this.PLCManualStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 27);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // selectModelToolStripMenuItem
            // 
            this.selectModelToolStripMenuItem.Name = "selectModelToolStripMenuItem";
            this.selectModelToolStripMenuItem.Size = new System.Drawing.Size(192, 28);
            this.selectModelToolStripMenuItem.Text = "Select Model";
            this.selectModelToolStripMenuItem.Click += new System.EventHandler(this.selectModelToolStripMenuItem_Click);
            // 
            // PLCManualStripMenuItem1
            // 
            this.PLCManualStripMenuItem1.Name = "PLCManualStripMenuItem1";
            this.PLCManualStripMenuItem1.Size = new System.Drawing.Size(192, 28);
            this.PLCManualStripMenuItem1.Text = "PLC Manual";
            this.PLCManualStripMenuItem1.Click += new System.EventHandler(this.PLCManualStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(192, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.lblCounter);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.buttonResetCounter);
            this.groupBox2.Controls.Add(this.lbl_product);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(1313, 64);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(411, 382);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Production";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imgbox_live);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 286);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(152, 92);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // imgbox_live
            // 
            this.imgbox_live.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgbox_live.Location = new System.Drawing.Point(25, 62);
            this.imgbox_live.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgbox_live.Name = "imgbox_live";
            this.imgbox_live.Size = new System.Drawing.Size(454, 317);
            this.imgbox_live.TabIndex = 2;
            this.imgbox_live.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Camera Live";
            // 
            // lblCounter
            // 
            this.lblCounter.BackColor = System.Drawing.Color.Black;
            this.lblCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.ForeColor = System.Drawing.Color.Lime;
            this.lblCounter.Location = new System.Drawing.Point(17, 154);
            this.lblCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(377, 104);
            this.lblCounter.TabIndex = 56;
            this.lblCounter.Text = "0";
            this.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(19, 123);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(376, 31);
            this.label13.TabIndex = 55;
            this.label13.Text = "TOTAL OUTPUT";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonResetCounter
            // 
            this.buttonResetCounter.BackColor = System.Drawing.Color.Transparent;
            this.buttonResetCounter.Location = new System.Drawing.Point(215, 305);
            this.buttonResetCounter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonResetCounter.Name = "buttonResetCounter";
            this.buttonResetCounter.Size = new System.Drawing.Size(177, 55);
            this.buttonResetCounter.TabIndex = 54;
            this.buttonResetCounter.Text = "Reset Count";
            this.buttonResetCounter.UseVisualStyleBackColor = false;
            this.buttonResetCounter.Click += new System.EventHandler(this.buttonResetCounter_Click);
            // 
            // lbl_product
            // 
            this.lbl_product.BackColor = System.Drawing.Color.Black;
            this.lbl_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product.ForeColor = System.Drawing.Color.White;
            this.lbl_product.Location = new System.Drawing.Point(15, 62);
            this.lbl_product.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(377, 49);
            this.lbl_product.TabIndex = 45;
            this.lbl_product.Text = "Trial";
            this.lbl_product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(376, 31);
            this.label3.TabIndex = 34;
            this.label3.Text = "Model Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_fail
            // 
            this.lbl_fail.BackColor = System.Drawing.Color.Black;
            this.lbl_fail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_fail.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fail.ForeColor = System.Drawing.Color.Red;
            this.lbl_fail.Location = new System.Drawing.Point(484, 80);
            this.lbl_fail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fail.Name = "lbl_fail";
            this.lbl_fail.Size = new System.Drawing.Size(449, 104);
            this.lbl_fail.TabIndex = 49;
            this.lbl_fail.Text = "0";
            this.lbl_fail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(484, 49);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(448, 31);
            this.label17.TabIndex = 48;
            this.label17.Text = "Rotate";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pass
            // 
            this.lbl_pass.BackColor = System.Drawing.Color.Black;
            this.lbl_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.ForeColor = System.Drawing.Color.Lime;
            this.lbl_pass.Location = new System.Drawing.Point(12, 80);
            this.lbl_pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(449, 104);
            this.lbl_pass.TabIndex = 46;
            this.lbl_pass.Text = "0";
            this.lbl_pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(448, 31);
            this.label5.TabIndex = 29;
            this.label5.Text = "Not Rotate";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_area);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lbl_lamp);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(1313, 468);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(411, 247);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Polarity Check";
            // 
            // lbl_area
            // 
            this.lbl_area.BackColor = System.Drawing.Color.Black;
            this.lbl_area.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_area.ForeColor = System.Drawing.Color.Lime;
            this.lbl_area.Location = new System.Drawing.Point(15, 58);
            this.lbl_area.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_area.Name = "lbl_area";
            this.lbl_area.Size = new System.Drawing.Size(377, 67);
            this.lbl_area.TabIndex = 48;
            this.lbl_area.Text = "0";
            this.lbl_area.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(376, 31);
            this.label4.TabIndex = 35;
            this.label4.Text = "Vision Result";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_lamp
            // 
            this.lbl_lamp.BackColor = System.Drawing.Color.Lime;
            this.lbl_lamp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_lamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lamp.ForeColor = System.Drawing.Color.Black;
            this.lbl_lamp.Location = new System.Drawing.Point(15, 133);
            this.lbl_lamp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lamp.Name = "lbl_lamp";
            this.lbl_lamp.Size = new System.Drawing.Size(377, 93);
            this.lbl_lamp.TabIndex = 24;
            this.lbl_lamp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxSetPLC
            // 
            this.groupBoxSetPLC.Controls.Add(this.label9);
            this.groupBoxSetPLC.Controls.Add(this.label10);
            this.groupBoxSetPLC.Controls.Add(this.comboBoxPLCBaud);
            this.groupBoxSetPLC.Controls.Add(this.buttonConnectPLC);
            this.groupBoxSetPLC.Controls.Add(this.comboBoxPLC);
            this.groupBoxSetPLC.Location = new System.Drawing.Point(8, 265);
            this.groupBoxSetPLC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSetPLC.Name = "groupBoxSetPLC";
            this.groupBoxSetPLC.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSetPLC.Size = new System.Drawing.Size(287, 186);
            this.groupBoxSetPLC.TabIndex = 50;
            this.groupBoxSetPLC.TabStop = false;
            this.groupBoxSetPLC.Text = "PLC Serial Port";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Baudrate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Serial Port";
            // 
            // comboBoxPLCBaud
            // 
            this.comboBoxPLCBaud.Enabled = false;
            this.comboBoxPLCBaud.FormattingEnabled = true;
            this.comboBoxPLCBaud.Location = new System.Drawing.Point(8, 96);
            this.comboBoxPLCBaud.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxPLCBaud.Name = "comboBoxPLCBaud";
            this.comboBoxPLCBaud.Size = new System.Drawing.Size(220, 28);
            this.comboBoxPLCBaud.TabIndex = 5;
            // 
            // buttonConnectPLC
            // 
            this.buttonConnectPLC.Location = new System.Drawing.Point(8, 138);
            this.buttonConnectPLC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConnectPLC.Name = "buttonConnectPLC";
            this.buttonConnectPLC.Size = new System.Drawing.Size(137, 39);
            this.buttonConnectPLC.TabIndex = 2;
            this.buttonConnectPLC.Text = "Connect PLC";
            this.buttonConnectPLC.UseVisualStyleBackColor = true;
            this.buttonConnectPLC.Click += new System.EventHandler(this.buttonConnectPLC_Click);
            // 
            // comboBoxPLC
            // 
            this.comboBoxPLC.FormattingEnabled = true;
            this.comboBoxPLC.Location = new System.Drawing.Point(8, 47);
            this.comboBoxPLC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxPLC.Name = "comboBoxPLC";
            this.comboBoxPLC.Size = new System.Drawing.Size(220, 28);
            this.comboBoxPLC.TabIndex = 3;
            // 
            // groupBoxSetCam
            // 
            this.groupBoxSetCam.Controls.Add(this.label11);
            this.groupBoxSetCam.Controls.Add(this.buttonRefresh);
            this.groupBoxSetCam.Controls.Add(this.buttonCamera);
            this.groupBoxSetCam.Controls.Add(this.comboBoxCam);
            this.groupBoxSetCam.Location = new System.Drawing.Point(8, 64);
            this.groupBoxSetCam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSetCam.Name = "groupBoxSetCam";
            this.groupBoxSetCam.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSetCam.Size = new System.Drawing.Size(287, 193);
            this.groupBoxSetCam.TabIndex = 49;
            this.groupBoxSetCam.TabStop = false;
            this.groupBoxSetCam.Text = "Camera Setup";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Camera List";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(8, 145);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(137, 39);
            this.buttonRefresh.TabIndex = 9;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonCamera
            // 
            this.buttonCamera.Location = new System.Drawing.Point(8, 91);
            this.buttonCamera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCamera.Name = "buttonCamera";
            this.buttonCamera.Size = new System.Drawing.Size(137, 39);
            this.buttonCamera.TabIndex = 1;
            this.buttonCamera.Text = "Set Camera";
            this.buttonCamera.UseVisualStyleBackColor = true;
            this.buttonCamera.Click += new System.EventHandler(this.buttonCamera_Click);
            // 
            // comboBoxCam
            // 
            this.comboBoxCam.FormattingEnabled = true;
            this.comboBoxCam.Location = new System.Drawing.Point(8, 54);
            this.comboBoxCam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCam.Name = "comboBoxCam";
            this.comboBoxCam.Size = new System.Drawing.Size(220, 28);
            this.comboBoxCam.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox12);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.buttonRESET);
            this.groupBox6.Controls.Add(this.imgbox_snap);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.buttonRUN);
            this.groupBox6.Controls.Add(this.buttonStop);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(303, 64);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(1004, 651);
            this.groupBox6.TabIndex = 48;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Camera View";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.lbl_pass);
            this.groupBox12.Controls.Add(this.label5);
            this.groupBox12.Controls.Add(this.lbl_fail);
            this.groupBox12.Controls.Add(this.label17);
            this.groupBox12.Location = new System.Drawing.Point(25, 420);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox12.Size = new System.Drawing.Size(944, 210);
            this.groupBox12.TabIndex = 55;
            this.groupBox12.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lamp_part);
            this.groupBox7.Controls.Add(this.labelCapture);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.lamp_bowl);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Location = new System.Drawing.Point(239, 53);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(248, 329);
            this.groupBox7.TabIndex = 54;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "I/O";
            // 
            // lamp_part
            // 
            this.lamp_part.BackColor = System.Drawing.Color.Lime;
            this.lamp_part.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lamp_part.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lamp_part.Location = new System.Drawing.Point(35, 43);
            this.lamp_part.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lamp_part.Name = "lamp_part";
            this.lamp_part.Size = new System.Drawing.Size(39, 36);
            this.lamp_part.TabIndex = 49;
            // 
            // labelCapture
            // 
            this.labelCapture.BackColor = System.Drawing.Color.Lime;
            this.labelCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapture.Location = new System.Drawing.Point(35, 230);
            this.labelCapture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCapture.Name = "labelCapture";
            this.labelCapture.Size = new System.Drawing.Size(39, 36);
            this.labelCapture.TabIndex = 51;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(83, 236);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 25);
            this.label19.TabIndex = 52;
            this.label19.Text = "Capture";
            // 
            // lamp_bowl
            // 
            this.lamp_bowl.BackColor = System.Drawing.Color.Lime;
            this.lamp_bowl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lamp_bowl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lamp_bowl.Location = new System.Drawing.Point(35, 138);
            this.lamp_bowl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lamp_bowl.Name = "lamp_bowl";
            this.lamp_bowl.Size = new System.Drawing.Size(39, 36);
            this.lamp_bowl.TabIndex = 48;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(83, 144);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 25);
            this.label15.TabIndex = 51;
            this.label15.Text = "Bowl";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(83, 49);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 25);
            this.label16.TabIndex = 50;
            this.label16.Text = "Part Detection";
            // 
            // buttonRESET
            // 
            this.buttonRESET.BackColor = System.Drawing.Color.Yellow;
            this.buttonRESET.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRESET.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRESET.Location = new System.Drawing.Point(25, 300);
            this.buttonRESET.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRESET.Name = "buttonRESET";
            this.buttonRESET.Size = new System.Drawing.Size(191, 80);
            this.buttonRESET.TabIndex = 53;
            this.buttonRESET.Text = "RESET";
            this.buttonRESET.UseVisualStyleBackColor = false;
            this.buttonRESET.Click += new System.EventHandler(this.buttonRESET_Click);
            // 
            // imgbox_snap
            // 
            this.imgbox_snap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgbox_snap.Location = new System.Drawing.Point(515, 64);
            this.imgbox_snap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgbox_snap.Name = "imgbox_snap";
            this.imgbox_snap.Size = new System.Drawing.Size(454, 317);
            this.imgbox_snap.TabIndex = 4;
            this.imgbox_snap.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(648, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Image Snap";
            // 
            // buttonRUN
            // 
            this.buttonRUN.BackColor = System.Drawing.Color.Lime;
            this.buttonRUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRUN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRUN.Location = new System.Drawing.Point(25, 64);
            this.buttonRUN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRUN.Name = "buttonRUN";
            this.buttonRUN.Size = new System.Drawing.Size(191, 95);
            this.buttonRUN.TabIndex = 4;
            this.buttonRUN.Text = "RUN";
            this.buttonRUN.UseVisualStyleBackColor = false;
            this.buttonRUN.Click += new System.EventHandler(this.buttonRUN_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Red;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonStop.Location = new System.Drawing.Point(25, 190);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(191, 80);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // groupBoxSetMCU
            // 
            this.groupBoxSetMCU.Controls.Add(this.buttonHome);
            this.groupBoxSetMCU.Controls.Add(this.buttonAlarm);
            this.groupBoxSetMCU.Controls.Add(this.label7);
            this.groupBoxSetMCU.Controls.Add(this.label8);
            this.groupBoxSetMCU.Controls.Add(this.comboBoxMCUBaud);
            this.groupBoxSetMCU.Controls.Add(this.buttonConnectMCU);
            this.groupBoxSetMCU.Controls.Add(this.comboBoxMCU);
            this.groupBoxSetMCU.Location = new System.Drawing.Point(8, 468);
            this.groupBoxSetMCU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSetMCU.Name = "groupBoxSetMCU";
            this.groupBoxSetMCU.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSetMCU.Size = new System.Drawing.Size(287, 247);
            this.groupBoxSetMCU.TabIndex = 53;
            this.groupBoxSetMCU.TabStop = false;
            this.groupBoxSetMCU.Text = "MCU Serial Port";
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(147, 186);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(137, 39);
            this.buttonHome.TabIndex = 10;
            this.buttonHome.Text = "Homing";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click_1);
            // 
            // buttonAlarm
            // 
            this.buttonAlarm.Location = new System.Drawing.Point(8, 186);
            this.buttonAlarm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAlarm.Name = "buttonAlarm";
            this.buttonAlarm.Size = new System.Drawing.Size(137, 39);
            this.buttonAlarm.TabIndex = 8;
            this.buttonAlarm.Text = "Alarm";
            this.buttonAlarm.UseVisualStyleBackColor = true;
            this.buttonAlarm.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Baudrate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Serial Port";
            // 
            // comboBoxMCUBaud
            // 
            this.comboBoxMCUBaud.Enabled = false;
            this.comboBoxMCUBaud.FormattingEnabled = true;
            this.comboBoxMCUBaud.Location = new System.Drawing.Point(8, 96);
            this.comboBoxMCUBaud.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxMCUBaud.Name = "comboBoxMCUBaud";
            this.comboBoxMCUBaud.Size = new System.Drawing.Size(220, 28);
            this.comboBoxMCUBaud.TabIndex = 5;
            // 
            // buttonConnectMCU
            // 
            this.buttonConnectMCU.Location = new System.Drawing.Point(8, 139);
            this.buttonConnectMCU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConnectMCU.Name = "buttonConnectMCU";
            this.buttonConnectMCU.Size = new System.Drawing.Size(137, 39);
            this.buttonConnectMCU.TabIndex = 2;
            this.buttonConnectMCU.Text = "Connect";
            this.buttonConnectMCU.UseVisualStyleBackColor = true;
            this.buttonConnectMCU.Click += new System.EventHandler(this.buttonConnectMCU_Click);
            // 
            // comboBoxMCU
            // 
            this.comboBoxMCU.FormattingEnabled = true;
            this.comboBoxMCU.Location = new System.Drawing.Point(8, 47);
            this.comboBoxMCU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxMCU.Name = "comboBoxMCU";
            this.comboBoxMCU.Size = new System.Drawing.Size(220, 28);
            this.comboBoxMCU.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(279, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(877, 52);
            this.label12.TabIndex = 54;
            this.label12.Text = "LEAD CUTTING AND BENDING MACHINE";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // statusProcess
            // 
            this.statusProcess.BackColor = System.Drawing.Color.Transparent;
            this.statusProcess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusProcess.Enabled = false;
            this.statusProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusProcess.Location = new System.Drawing.Point(8, 751);
            this.statusProcess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusProcess.Name = "statusProcess";
            this.statusProcess.Size = new System.Drawing.Size(1745, 64);
            this.statusProcess.TabIndex = 55;
            this.statusProcess.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 36);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1755, 831);
            this.tabControl1.TabIndex = 58;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxSetCam);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.groupBoxSetPLC);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBoxSetMCU);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1747, 798);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1747, 798);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "New Model";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label18);
            this.groupBox8.Controls.Add(this.buttonSave);
            this.groupBox8.Controls.Add(this.textBoxInputModel);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(493, 668);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Size = new System.Drawing.Size(888, 102);
            this.groupBox8.TabIndex = 60;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Save New Model";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(55, 39);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 24);
            this.label18.TabIndex = 3;
            this.label18.Text = "Model Name";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(729, 28);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(141, 44);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click_1);
            // 
            // textBoxInputModel
            // 
            this.textBoxInputModel.Location = new System.Drawing.Point(239, 36);
            this.textBoxInputModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxInputModel.Name = "textBoxInputModel";
            this.textBoxInputModel.Size = new System.Drawing.Size(363, 29);
            this.textBoxInputModel.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(39, 25);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1527, 641);
            this.tabControl2.TabIndex = 59;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox9);
            this.tabPage3.Controls.Add(this.groupBox10);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(1519, 608);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Camera Setting";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.panel1);
            this.groupBox9.Controls.Add(this.labelThreshold);
            this.groupBox9.Controls.Add(this.labelMax);
            this.groupBox9.Controls.Add(this.labelMin);
            this.groupBox9.Controls.Add(this.label22);
            this.groupBox9.Controls.Add(this.trackBarThreshold);
            this.groupBox9.Controls.Add(this.label23);
            this.groupBox9.Controls.Add(this.trackBarGraymax);
            this.groupBox9.Controls.Add(this.label24);
            this.groupBox9.Controls.Add(this.trackBarGraymin);
            this.groupBox9.Controls.Add(this.label25);
            this.groupBox9.Controls.Add(this.comboBoxProduct);
            this.groupBox9.Location = new System.Drawing.Point(840, 7);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox9.Size = new System.Drawing.Size(439, 590);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Control and Filter";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelarea2);
            this.panel1.Controls.Add(this.labelresult2);
            this.panel1.Controls.Add(this.imageBox4);
            this.panel1.Location = new System.Drawing.Point(8, 332);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 198);
            this.panel1.TabIndex = 14;
            // 
            // labelarea2
            // 
            this.labelarea2.BackColor = System.Drawing.Color.Black;
            this.labelarea2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelarea2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelarea2.ForeColor = System.Drawing.Color.Lime;
            this.labelarea2.Location = new System.Drawing.Point(199, 15);
            this.labelarea2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelarea2.Name = "labelarea2";
            this.labelarea2.Size = new System.Drawing.Size(206, 66);
            this.labelarea2.TabIndex = 25;
            this.labelarea2.Text = "0";
            this.labelarea2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelresult2
            // 
            this.labelresult2.BackColor = System.Drawing.Color.Lime;
            this.labelresult2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelresult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelresult2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelresult2.Location = new System.Drawing.Point(199, 96);
            this.labelresult2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelresult2.Name = "labelresult2";
            this.labelresult2.Size = new System.Drawing.Size(206, 66);
            this.labelresult2.TabIndex = 24;
            this.labelresult2.Text = "OK";
            this.labelresult2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageBox4
            // 
            this.imageBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox4.Location = new System.Drawing.Point(16, 15);
            this.imageBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageBox4.Name = "imageBox4";
            this.imageBox4.Size = new System.Drawing.Size(139, 166);
            this.imageBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox4.TabIndex = 2;
            this.imageBox4.TabStop = false;
            // 
            // labelThreshold
            // 
            this.labelThreshold.AutoSize = true;
            this.labelThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThreshold.Location = new System.Drawing.Point(360, 262);
            this.labelThreshold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelThreshold.Name = "labelThreshold";
            this.labelThreshold.Size = new System.Drawing.Size(18, 20);
            this.labelThreshold.TabIndex = 13;
            this.labelThreshold.Text = "0";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMax.Location = new System.Drawing.Point(360, 187);
            this.labelMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(18, 20);
            this.labelMax.TabIndex = 12;
            this.labelMax.Text = "0";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.Location = new System.Drawing.Point(360, 112);
            this.labelMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(18, 20);
            this.labelMin.TabIndex = 11;
            this.labelMin.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(21, 251);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(123, 20);
            this.label22.TabIndex = 10;
            this.label22.Text = "Threshold Area";
            // 
            // trackBarThreshold
            // 
            this.trackBarThreshold.Location = new System.Drawing.Point(21, 271);
            this.trackBarThreshold.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarThreshold.Maximum = 10000;
            this.trackBarThreshold.Name = "trackBarThreshold";
            this.trackBarThreshold.Size = new System.Drawing.Size(331, 56);
            this.trackBarThreshold.TabIndex = 9;
            this.trackBarThreshold.Scroll += new System.EventHandler(this.trackBarThreshold_Scroll);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(21, 167);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 20);
            this.label23.TabIndex = 8;
            this.label23.Text = "Filter Max";
            // 
            // trackBarGraymax
            // 
            this.trackBarGraymax.Location = new System.Drawing.Point(21, 187);
            this.trackBarGraymax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarGraymax.Maximum = 255;
            this.trackBarGraymax.Name = "trackBarGraymax";
            this.trackBarGraymax.Size = new System.Drawing.Size(331, 56);
            this.trackBarGraymax.TabIndex = 7;
            this.trackBarGraymax.Value = 255;
            this.trackBarGraymax.Scroll += new System.EventHandler(this.trackBarGraymax_Scroll);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(21, 92);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(79, 20);
            this.label24.TabIndex = 6;
            this.label24.Text = "Filter Min";
            // 
            // trackBarGraymin
            // 
            this.trackBarGraymin.Location = new System.Drawing.Point(21, 112);
            this.trackBarGraymin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarGraymin.Maximum = 255;
            this.trackBarGraymin.Name = "trackBarGraymin";
            this.trackBarGraymin.Size = new System.Drawing.Size(331, 56);
            this.trackBarGraymin.TabIndex = 5;
            this.trackBarGraymin.Scroll += new System.EventHandler(this.trackBarGraymin_Scroll);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(17, 31);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(103, 20);
            this.label25.TabIndex = 4;
            this.label25.Text = "Model Name";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(17, 58);
            this.comboBoxProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(333, 28);
            this.comboBoxProduct.TabIndex = 3;
            this.comboBoxProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduct_SelectedIndexChanged);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.buttonStopCam2);
            this.groupBox10.Controls.Add(this.buttonStartCam);
            this.groupBox10.Controls.Add(this.checkBoxImageProc);
            this.groupBox10.Controls.Add(this.buttonSetROI);
            this.groupBox10.Controls.Add(this.checkBoxLive);
            this.groupBox10.Controls.Add(this.imageBoxCreate);
            this.groupBox10.Location = new System.Drawing.Point(8, 7);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox10.Size = new System.Drawing.Size(657, 590);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Camera View";
            // 
            // buttonStopCam2
            // 
            this.buttonStopCam2.Location = new System.Drawing.Point(289, 524);
            this.buttonStopCam2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStopCam2.Name = "buttonStopCam2";
            this.buttonStopCam2.Size = new System.Drawing.Size(149, 47);
            this.buttonStopCam2.TabIndex = 7;
            this.buttonStopCam2.Text = "Stop Cam";
            this.buttonStopCam2.UseVisualStyleBackColor = true;
            this.buttonStopCam2.Click += new System.EventHandler(this.buttonStopCam2_Click);
            // 
            // buttonStartCam
            // 
            this.buttonStartCam.Location = new System.Drawing.Point(475, 524);
            this.buttonStartCam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStartCam.Name = "buttonStartCam";
            this.buttonStartCam.Size = new System.Drawing.Size(149, 47);
            this.buttonStartCam.TabIndex = 6;
            this.buttonStartCam.Text = "Start Cam";
            this.buttonStartCam.UseVisualStyleBackColor = true;
            this.buttonStartCam.Click += new System.EventHandler(this.buttonStartCam_Click);
            // 
            // checkBoxImageProc
            // 
            this.checkBoxImageProc.AutoSize = true;
            this.checkBoxImageProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxImageProc.Location = new System.Drawing.Point(188, 23);
            this.checkBoxImageProc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxImageProc.Name = "checkBoxImageProc";
            this.checkBoxImageProc.Size = new System.Drawing.Size(165, 24);
            this.checkBoxImageProc.TabIndex = 4;
            this.checkBoxImageProc.Text = "Image Processing";
            this.checkBoxImageProc.UseVisualStyleBackColor = true;
            this.checkBoxImageProc.CheckedChanged += new System.EventHandler(this.checkBoxImageProc_CheckedChanged);
            // 
            // buttonSetROI
            // 
            this.buttonSetROI.Location = new System.Drawing.Point(504, 23);
            this.buttonSetROI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSetROI.Name = "buttonSetROI";
            this.buttonSetROI.Size = new System.Drawing.Size(120, 30);
            this.buttonSetROI.TabIndex = 5;
            this.buttonSetROI.Text = "Set ROI";
            this.buttonSetROI.UseVisualStyleBackColor = true;
            this.buttonSetROI.Click += new System.EventHandler(this.buttonSetROI_Click);
            // 
            // checkBoxLive
            // 
            this.checkBoxLive.AutoSize = true;
            this.checkBoxLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLive.Location = new System.Drawing.Point(25, 23);
            this.checkBoxLive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxLive.Name = "checkBoxLive";
            this.checkBoxLive.Size = new System.Drawing.Size(143, 24);
            this.checkBoxLive.TabIndex = 3;
            this.checkBoxLive.Text = "Live Streaming";
            this.checkBoxLive.UseVisualStyleBackColor = true;
            this.checkBoxLive.CheckedChanged += new System.EventHandler(this.checkBoxLive_CheckedChanged);
            // 
            // imageBoxCreate
            // 
            this.imageBoxCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxCreate.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBoxCreate.Location = new System.Drawing.Point(68, 60);
            this.imageBoxCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageBoxCreate.Name = "imageBoxCreate";
            this.imageBoxCreate.Size = new System.Drawing.Size(454, 317);
            this.imageBoxCreate.TabIndex = 2;
            this.imageBoxCreate.TabStop = false;
            this.imageBoxCreate.Paint += new System.Windows.Forms.PaintEventHandler(this.imageBoxCreate_Paint);
            this.imageBoxCreate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageBoxCreate_MouseDown);
            this.imageBoxCreate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBoxCreate_MouseMove);
            this.imageBoxCreate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBoxCreate_MouseUp);
            this.imageBoxCreate.Move += new System.EventHandler(this.imageBoxCreate_Move);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonPolling);
            this.tabPage4.Controls.Add(this.groupBox14);
            this.tabPage4.Controls.Add(this.buttonStopTest);
            this.tabPage4.Controls.Add(this.buttonRunningTest);
            this.tabPage4.Controls.Add(this.buttonAlarm2);
            this.tabPage4.Controls.Add(this.buttonHome2);
            this.tabPage4.Controls.Add(this.groupBox11);
            this.tabPage4.Controls.Add(this.groupBoxReceiveData);
            this.tabPage4.Controls.Add(this.groupBox13);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Size = new System.Drawing.Size(1519, 608);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Position Setting";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonPolling
            // 
            this.buttonPolling.Location = new System.Drawing.Point(192, 382);
            this.buttonPolling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPolling.Name = "buttonPolling";
            this.buttonPolling.Size = new System.Drawing.Size(149, 41);
            this.buttonPolling.TabIndex = 57;
            this.buttonPolling.Text = "Polling";
            this.buttonPolling.UseVisualStyleBackColor = true;
            this.buttonPolling.Click += new System.EventHandler(this.buttonPolling_Click);
            // 
            // groupBox14
            // 
            this.groupBox14.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox14.Controls.Add(this.label35);
            this.groupBox14.Controls.Add(this.textBoxX1);
            this.groupBox14.Controls.Add(this.label38);
            this.groupBox14.Controls.Add(this.textBoxStatus1);
            this.groupBox14.Location = new System.Drawing.Point(16, 23);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox14.Size = new System.Drawing.Size(435, 95);
            this.groupBox14.TabIndex = 56;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Data ";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(240, 44);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(20, 20);
            this.label35.TabIndex = 3;
            this.label35.Text = "X";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(285, 41);
            this.textBoxX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(68, 26);
            this.textBoxX1.TabIndex = 2;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(12, 44);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(57, 20);
            this.label38.TabIndex = 1;
            this.label38.Text = "Status";
            // 
            // textBoxStatus1
            // 
            this.textBoxStatus1.Location = new System.Drawing.Point(73, 41);
            this.textBoxStatus1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxStatus1.Name = "textBoxStatus1";
            this.textBoxStatus1.Size = new System.Drawing.Size(149, 26);
            this.textBoxStatus1.TabIndex = 0;
            // 
            // buttonStopTest
            // 
            this.buttonStopTest.Location = new System.Drawing.Point(16, 382);
            this.buttonStopTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStopTest.Name = "buttonStopTest";
            this.buttonStopTest.Size = new System.Drawing.Size(149, 41);
            this.buttonStopTest.TabIndex = 37;
            this.buttonStopTest.Text = "Stop";
            this.buttonStopTest.UseVisualStyleBackColor = true;
            // 
            // buttonRunningTest
            // 
            this.buttonRunningTest.Location = new System.Drawing.Point(16, 443);
            this.buttonRunningTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRunningTest.Name = "buttonRunningTest";
            this.buttonRunningTest.Size = new System.Drawing.Size(149, 41);
            this.buttonRunningTest.TabIndex = 36;
            this.buttonRunningTest.Text = "Tes Run";
            this.buttonRunningTest.UseVisualStyleBackColor = true;
            this.buttonRunningTest.Click += new System.EventHandler(this.buttonRunningTest_Click);
            // 
            // buttonAlarm2
            // 
            this.buttonAlarm2.Location = new System.Drawing.Point(16, 308);
            this.buttonAlarm2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAlarm2.Name = "buttonAlarm2";
            this.buttonAlarm2.Size = new System.Drawing.Size(149, 41);
            this.buttonAlarm2.TabIndex = 35;
            this.buttonAlarm2.Text = "Alarm";
            this.buttonAlarm2.UseVisualStyleBackColor = true;
            this.buttonAlarm2.Click += new System.EventHandler(this.buttonAlarm2_Click);
            // 
            // buttonHome2
            // 
            this.buttonHome2.Location = new System.Drawing.Point(192, 308);
            this.buttonHome2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonHome2.Name = "buttonHome2";
            this.buttonHome2.Size = new System.Drawing.Size(149, 41);
            this.buttonHome2.TabIndex = 34;
            this.buttonHome2.Text = "Homing";
            this.buttonHome2.UseVisualStyleBackColor = true;
            this.buttonHome2.Click += new System.EventHandler(this.buttonHome2_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.buttonGo);
            this.groupBox11.Controls.Add(this.label26);
            this.groupBox11.Controls.Add(this.comboBoxID);
            this.groupBox11.Controls.Add(this.buttonClearRow);
            this.groupBox11.Controls.Add(this.buttonUpload1);
            this.groupBox11.Controls.Add(this.buttonInsert1);
            this.groupBox11.Controls.Add(this.dataGridView1);
            this.groupBox11.Location = new System.Drawing.Point(597, 7);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox11.Size = new System.Drawing.Size(740, 586);
            this.groupBox11.TabIndex = 32;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Pick Poss";
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(608, 526);
            this.buttonGo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(52, 37);
            this.buttonGo.TabIndex = 26;
            this.buttonGo.Text = "GO";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(149, 481);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(36, 20);
            this.label26.TabIndex = 27;
            this.label26.Text = "ID :";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxID
            // 
            this.comboBoxID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxID.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(205, 478);
            this.comboBoxID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(160, 28);
            this.comboBoxID.TabIndex = 28;
            // 
            // buttonClearRow
            // 
            this.buttonClearRow.Location = new System.Drawing.Point(537, 473);
            this.buttonClearRow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClearRow.Name = "buttonClearRow";
            this.buttonClearRow.Size = new System.Drawing.Size(123, 37);
            this.buttonClearRow.TabIndex = 30;
            this.buttonClearRow.Text = "Remove Row";
            this.buttonClearRow.UseVisualStyleBackColor = true;
            this.buttonClearRow.Click += new System.EventHandler(this.buttonClearRow_Click);
            // 
            // buttonUpload1
            // 
            this.buttonUpload1.Location = new System.Drawing.Point(419, 526);
            this.buttonUpload1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUpload1.Name = "buttonUpload1";
            this.buttonUpload1.Size = new System.Drawing.Size(108, 37);
            this.buttonUpload1.TabIndex = 26;
            this.buttonUpload1.Text = "UPLOAD";
            this.buttonUpload1.UseVisualStyleBackColor = true;
            this.buttonUpload1.Visible = false;
            // 
            // buttonInsert1
            // 
            this.buttonInsert1.Location = new System.Drawing.Point(419, 474);
            this.buttonInsert1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonInsert1.Name = "buttonInsert1";
            this.buttonInsert1.Size = new System.Drawing.Size(108, 37);
            this.buttonInsert1.TabIndex = 21;
            this.buttonInsert1.Text = "Insert";
            this.buttonInsert1.UseVisualStyleBackColor = true;
            this.buttonInsert1.Click += new System.EventHandler(this.buttonInsert1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.X,
            this.Speed});
            this.dataGridView1.Location = new System.Drawing.Point(16, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(703, 426);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 125;
            // 
            // Speed
            // 
            this.Speed.HeaderText = "Speed";
            this.Speed.MinimumWidth = 6;
            this.Speed.Name = "Speed";
            this.Speed.Width = 125;
            // 
            // groupBoxReceiveData
            // 
            this.groupBoxReceiveData.Controls.Add(this.checkBox1);
            this.groupBoxReceiveData.Controls.Add(this.buttonClearRecData);
            this.groupBoxReceiveData.Controls.Add(this.textBoxReceive);
            this.groupBoxReceiveData.Location = new System.Drawing.Point(12, 514);
            this.groupBoxReceiveData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxReceiveData.Name = "groupBoxReceiveData";
            this.groupBoxReceiveData.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxReceiveData.Size = new System.Drawing.Size(295, 55);
            this.groupBoxReceiveData.TabIndex = 30;
            this.groupBoxReceiveData.TabStop = false;
            this.groupBoxReceiveData.Text = "Received Data";
            this.groupBoxReceiveData.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(4, 146);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Verbose";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonClearRecData
            // 
            this.buttonClearRecData.Location = new System.Drawing.Point(128, 144);
            this.buttonClearRecData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClearRecData.Name = "buttonClearRecData";
            this.buttonClearRecData.Size = new System.Drawing.Size(100, 28);
            this.buttonClearRecData.TabIndex = 1;
            this.buttonClearRecData.Text = "Clear";
            this.buttonClearRecData.UseVisualStyleBackColor = true;
            // 
            // textBoxReceive
            // 
            this.textBoxReceive.AllowDrop = true;
            this.textBoxReceive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxReceive.Location = new System.Drawing.Point(4, 23);
            this.textBoxReceive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxReceive.Multiline = true;
            this.textBoxReceive.Name = "textBoxReceive";
            this.textBoxReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceive.Size = new System.Drawing.Size(409, 101);
            this.textBoxReceive.TabIndex = 0;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label29);
            this.groupBox13.Controls.Add(this.comboBoxRate);
            this.groupBox13.Controls.Add(this.label30);
            this.groupBox13.Controls.Add(this.comboBoxMatric);
            this.groupBox13.Controls.Add(this.buttonXPlus);
            this.groupBox13.Controls.Add(this.buttonXMin);
            this.groupBox13.Location = new System.Drawing.Point(12, 137);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox13.Size = new System.Drawing.Size(439, 149);
            this.groupBox13.TabIndex = 29;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "JOG Control";
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(25, 79);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(86, 20);
            this.label29.TabIndex = 12;
            this.label29.Text = "Feed Rate";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxRate
            // 
            this.comboBoxRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxRate.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRate.FormattingEnabled = true;
            this.comboBoxRate.Location = new System.Drawing.Point(23, 103);
            this.comboBoxRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxRate.Name = "comboBoxRate";
            this.comboBoxRate.Size = new System.Drawing.Size(160, 28);
            this.comboBoxRate.TabIndex = 13;
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(25, 20);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(56, 20);
            this.label30.TabIndex = 7;
            this.label30.Text = "Matric";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxMatric
            // 
            this.comboBoxMatric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxMatric.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxMatric.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMatric.FormattingEnabled = true;
            this.comboBoxMatric.Location = new System.Drawing.Point(23, 44);
            this.comboBoxMatric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxMatric.Name = "comboBoxMatric";
            this.comboBoxMatric.Size = new System.Drawing.Size(160, 28);
            this.comboBoxMatric.TabIndex = 7;
            // 
            // buttonXPlus
            // 
            this.buttonXPlus.Location = new System.Drawing.Point(348, 58);
            this.buttonXPlus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonXPlus.Name = "buttonXPlus";
            this.buttonXPlus.Size = new System.Drawing.Size(47, 43);
            this.buttonXPlus.TabIndex = 2;
            this.buttonXPlus.Text = "X+";
            this.buttonXPlus.UseVisualStyleBackColor = true;
            this.buttonXPlus.Click += new System.EventHandler(this.buttonXPlus_Click);
            // 
            // buttonXMin
            // 
            this.buttonXMin.Location = new System.Drawing.Point(248, 58);
            this.buttonXMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonXMin.Name = "buttonXMin";
            this.buttonXMin.Size = new System.Drawing.Size(47, 43);
            this.buttonXMin.TabIndex = 1;
            this.buttonXMin.Text = "X-";
            this.buttonXMin.UseVisualStyleBackColor = true;
            this.buttonXMin.Click += new System.EventHandler(this.buttonXMin_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(1599, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 112);
            this.panel2.TabIndex = 57;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1753, 817);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusProcess);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox_live)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBoxSetPLC.ResumeLayout(false);
            this.groupBoxSetPLC.PerformLayout();
            this.groupBoxSetCam.ResumeLayout(false);
            this.groupBoxSetCam.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox_snap)).EndInit();
            this.groupBoxSetMCU.ResumeLayout(false);
            this.groupBoxSetMCU.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGraymax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGraymin)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxCreate)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxReceiveData.ResumeLayout(false);
            this.groupBoxReceiveData.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_area;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_lamp;
        private System.Windows.Forms.GroupBox groupBoxSetPLC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxPLCBaud;
        private System.Windows.Forms.Button buttonConnectPLC;
        private System.Windows.Forms.ComboBox comboBoxPLC;
        private System.Windows.Forms.GroupBox groupBoxSetCam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonCamera;
        private System.Windows.Forms.ComboBox comboBoxCam;
        private System.Windows.Forms.GroupBox groupBox6;
        private Emgu.CV.UI.ImageBox imgbox_snap;
        private System.Windows.Forms.Label label2;
        private Emgu.CV.UI.ImageBox imgbox_live;
        private System.Windows.Forms.Button buttonRUN;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.GroupBox groupBoxSetMCU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxMCUBaud;
        private System.Windows.Forms.Button buttonConnectMCU;
        private System.Windows.Forms.ComboBox comboBoxMCU;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonAlarm;
        private System.Windows.Forms.Button statusProcess;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lamp_part;
        private System.Windows.Forms.Label lamp_bowl;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label lbl_fail;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelarea2;
        private System.Windows.Forms.Label labelresult2;
        private Emgu.CV.UI.ImageBox imageBox4;
        private System.Windows.Forms.Label labelThreshold;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TrackBar trackBarThreshold;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TrackBar trackBarGraymax;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TrackBar trackBarGraymin;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.CheckBox checkBoxImageProc;
        private System.Windows.Forms.Button buttonSetROI;
        private System.Windows.Forms.CheckBox checkBoxLive;
        private Emgu.CV.UI.ImageBox imageBoxCreate;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.Button buttonClearRow;
        private System.Windows.Forms.Button buttonUpload1;
        private System.Windows.Forms.Button buttonInsert1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.GroupBox groupBoxReceiveData;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonClearRecData;
        private System.Windows.Forms.TextBox textBoxReceive;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox comboBoxRate;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox comboBoxMatric;
        private System.Windows.Forms.Button buttonXPlus;
        private System.Windows.Forms.Button buttonXMin;
        private System.Windows.Forms.Button buttonStartCam;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxInputModel;
        private System.Windows.Forms.Button buttonHome2;
        private System.Windows.Forms.Button buttonAlarm2;
        private System.Windows.Forms.Button buttonStopTest;
        private System.Windows.Forms.Button buttonRunningTest;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelCapture;
        private System.Windows.Forms.Button buttonStopCam2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label label35;
        public System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.Label label38;
        public System.Windows.Forms.TextBox textBoxStatus1;
        private System.Windows.Forms.Button buttonPolling;
        private System.Windows.Forms.Button buttonRESET;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonResetCounter;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ToolStripMenuItem PLCManualStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selectModelToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

