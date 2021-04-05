namespace Compass
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
            this.picCompass = new System.Windows.Forms.PictureBox();
            this.hbarDegrees = new System.Windows.Forms.HScrollBar();
            this.picHeading = new System.Windows.Forms.PictureBox();
            this.txtbx_heading = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_compass = new System.Windows.Forms.TabPage();
            this.tab_rs232 = new System.Windows.Forms.TabPage();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.rbHex = new System.Windows.Forms.RadioButton();
            this.gbPortSettings = new System.Windows.Forms.GroupBox();
            this.chkCD = new System.Windows.Forms.CheckBox();
            this.chkRTS = new System.Windows.Forms.CheckBox();
            this.chkDSR = new System.Windows.Forms.CheckBox();
            this.btn_OpenPort = new System.Windows.Forms.Button();
            this.chkCTS = new System.Windows.Forms.CheckBox();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.chkDTR = new System.Windows.Forms.CheckBox();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.lblComPort = new System.Windows.Forms.Label();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_magnetic_declination = new System.Windows.Forms.TabPage();
            this.btn_set_in_compass = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_decimal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_minutes = new System.Windows.Forms.TextBox();
            this.txtbx_degrees = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdobtn_decimal = new System.Windows.Forms.RadioButton();
            this.rdobtn_deg_min = new System.Windows.Forms.RadioButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tmrCheckComPorts = new System.Windows.Forms.Timer(this.components);
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCompass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeading)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tab_compass.SuspendLayout();
            this.tab_rs232.SuspendLayout();
            this.gbMode.SuspendLayout();
            this.gbPortSettings.SuspendLayout();
            this.tab_magnetic_declination.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCompass
            // 
            this.picCompass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picCompass.BackColor = System.Drawing.Color.White;
            this.picCompass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCompass.Location = new System.Drawing.Point(15, 356);
            this.picCompass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picCompass.Name = "picCompass";
            this.picCompass.Size = new System.Drawing.Size(345, 98);
            this.picCompass.TabIndex = 0;
            this.picCompass.TabStop = false;
            this.picCompass.Paint += new System.Windows.Forms.PaintEventHandler(this.picCompass_Paint);
            // 
            // hbarDegrees
            // 
            this.hbarDegrees.Location = new System.Drawing.Point(15, 8);
            this.hbarDegrees.Maximum = 369;
            this.hbarDegrees.Name = "hbarDegrees";
            this.hbarDegrees.Size = new System.Drawing.Size(285, 17);
            this.hbarDegrees.TabIndex = 1;
            this.hbarDegrees.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hbarDegrees_Scroll);
            // 
            // picHeading
            // 
            this.picHeading.BackColor = System.Drawing.Color.White;
            this.picHeading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picHeading.Location = new System.Drawing.Point(15, 35);
            this.picHeading.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picHeading.Name = "picHeading";
            this.picHeading.Size = new System.Drawing.Size(345, 319);
            this.picHeading.TabIndex = 3;
            this.picHeading.TabStop = false;
            this.picHeading.Paint += new System.Windows.Forms.PaintEventHandler(this.picHeading_Paint);
            // 
            // txtbx_heading
            // 
            this.txtbx_heading.Location = new System.Drawing.Point(311, 8);
            this.txtbx_heading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbx_heading.MaxLength = 4;
            this.txtbx_heading.Name = "txtbx_heading";
            this.txtbx_heading.Size = new System.Drawing.Size(62, 22);
            this.txtbx_heading.TabIndex = 4;
            this.txtbx_heading.Text = "0°";
            this.txtbx_heading.TextChanged += new System.EventHandler(this.txtbx_heading_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_compass);
            this.tabControl1.Controls.Add(this.tab_rs232);
            this.tabControl1.Controls.Add(this.tab_magnetic_declination);
            this.tabControl1.Location = new System.Drawing.Point(11, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(385, 483);
            this.tabControl1.TabIndex = 5;
            // 
            // tab_compass
            // 
            this.tab_compass.Controls.Add(this.picCompass);
            this.tab_compass.Controls.Add(this.txtbx_heading);
            this.tab_compass.Controls.Add(this.picHeading);
            this.tab_compass.Controls.Add(this.hbarDegrees);
            this.tab_compass.Location = new System.Drawing.Point(4, 25);
            this.tab_compass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_compass.Name = "tab_compass";
            this.tab_compass.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_compass.Size = new System.Drawing.Size(377, 454);
            this.tab_compass.TabIndex = 0;
            this.tab_compass.Text = "Compass";
            this.tab_compass.UseVisualStyleBackColor = true;
            // 
            // tab_rs232
            // 
            this.tab_rs232.Controls.Add(this.gbMode);
            this.tab_rs232.Controls.Add(this.gbPortSettings);
            this.tab_rs232.Location = new System.Drawing.Point(4, 25);
            this.tab_rs232.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_rs232.Name = "tab_rs232";
            this.tab_rs232.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_rs232.Size = new System.Drawing.Size(377, 454);
            this.tab_rs232.TabIndex = 1;
            this.tab_rs232.Text = "RS232 Setup";
            this.tab_rs232.UseVisualStyleBackColor = true;
            // 
            // gbMode
            // 
            this.gbMode.Controls.Add(this.rbText);
            this.gbMode.Controls.Add(this.rbHex);
            this.gbMode.Location = new System.Drawing.Point(77, 398);
            this.gbMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMode.Name = "gbMode";
            this.gbMode.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMode.Size = new System.Drawing.Size(197, 53);
            this.gbMode.TabIndex = 12;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "Data &Mode";
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.Location = new System.Drawing.Point(16, 23);
            this.rbText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(56, 21);
            this.rbText.TabIndex = 0;
            this.rbText.Text = "Text";
            this.rbText.CheckedChanged += new System.EventHandler(this.rbText_CheckedChanged);
            // 
            // rbHex
            // 
            this.rbHex.AutoSize = true;
            this.rbHex.Checked = true;
            this.rbHex.Location = new System.Drawing.Point(107, 23);
            this.rbHex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbHex.Name = "rbHex";
            this.rbHex.Size = new System.Drawing.Size(53, 21);
            this.rbHex.TabIndex = 1;
            this.rbHex.TabStop = true;
            this.rbHex.Text = "Hex";
            this.rbHex.CheckedChanged += new System.EventHandler(this.rbHex_CheckedChanged);
            // 
            // gbPortSettings
            // 
            this.gbPortSettings.Controls.Add(this.chkCD);
            this.gbPortSettings.Controls.Add(this.chkRTS);
            this.gbPortSettings.Controls.Add(this.chkDSR);
            this.gbPortSettings.Controls.Add(this.btn_OpenPort);
            this.gbPortSettings.Controls.Add(this.chkCTS);
            this.gbPortSettings.Controls.Add(this.cmbPortName);
            this.gbPortSettings.Controls.Add(this.cmbBaudRate);
            this.gbPortSettings.Controls.Add(this.cmbStopBits);
            this.gbPortSettings.Controls.Add(this.chkDTR);
            this.gbPortSettings.Controls.Add(this.cmbParity);
            this.gbPortSettings.Controls.Add(this.cmbDataBits);
            this.gbPortSettings.Controls.Add(this.lblComPort);
            this.gbPortSettings.Controls.Add(this.lblStopBits);
            this.gbPortSettings.Controls.Add(this.lblBaudRate);
            this.gbPortSettings.Controls.Add(this.lblDataBits);
            this.gbPortSettings.Controls.Add(this.label1);
            this.gbPortSettings.Location = new System.Drawing.Point(77, 45);
            this.gbPortSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPortSettings.Name = "gbPortSettings";
            this.gbPortSettings.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPortSettings.Size = new System.Drawing.Size(197, 322);
            this.gbPortSettings.TabIndex = 6;
            this.gbPortSettings.TabStop = false;
            this.gbPortSettings.Text = "RS232 Port Settings";
            // 
            // chkCD
            // 
            this.chkCD.AutoSize = true;
            this.chkCD.Enabled = false;
            this.chkCD.Location = new System.Drawing.Point(131, 219);
            this.chkCD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkCD.Name = "chkCD";
            this.chkCD.Size = new System.Drawing.Size(49, 21);
            this.chkCD.TabIndex = 14;
            this.chkCD.Text = "CD";
            this.chkCD.UseVisualStyleBackColor = true;
            // 
            // chkRTS
            // 
            this.chkRTS.AutoSize = true;
            this.chkRTS.Location = new System.Drawing.Point(131, 132);
            this.chkRTS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkRTS.Name = "chkRTS";
            this.chkRTS.Size = new System.Drawing.Size(58, 21);
            this.chkRTS.TabIndex = 11;
            this.chkRTS.Text = "RTS";
            this.chkRTS.UseVisualStyleBackColor = true;
            this.chkRTS.CheckedChanged += new System.EventHandler(this.chkRTS_CheckedChanged);
            // 
            // chkDSR
            // 
            this.chkDSR.AutoSize = true;
            this.chkDSR.Enabled = false;
            this.chkDSR.Location = new System.Drawing.Point(131, 190);
            this.chkDSR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDSR.Name = "chkDSR";
            this.chkDSR.Size = new System.Drawing.Size(59, 21);
            this.chkDSR.TabIndex = 13;
            this.chkDSR.Text = "DSR";
            this.chkDSR.UseVisualStyleBackColor = true;
            // 
            // btn_OpenPort
            // 
            this.btn_OpenPort.Location = new System.Drawing.Point(13, 281);
            this.btn_OpenPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_OpenPort.Name = "btn_OpenPort";
            this.btn_OpenPort.Size = new System.Drawing.Size(100, 28);
            this.btn_OpenPort.TabIndex = 10;
            this.btn_OpenPort.Text = "&Open Port";
            this.btn_OpenPort.Click += new System.EventHandler(this.btn_OpenPort_Click);
            // 
            // chkCTS
            // 
            this.chkCTS.AutoSize = true;
            this.chkCTS.Enabled = false;
            this.chkCTS.Location = new System.Drawing.Point(131, 162);
            this.chkCTS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkCTS.Name = "chkCTS";
            this.chkCTS.Size = new System.Drawing.Size(57, 21);
            this.chkCTS.TabIndex = 12;
            this.chkCTS.Text = "CTS";
            this.chkCTS.UseVisualStyleBackColor = true;
            // 
            // cmbPortName
            // 
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.cmbPortName.Location = new System.Drawing.Point(18, 43);
            this.cmbPortName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(88, 24);
            this.cmbPortName.TabIndex = 10;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600",
            "1000000"});
            this.cmbBaudRate.Location = new System.Drawing.Point(18, 94);
            this.cmbBaudRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(91, 24);
            this.cmbBaudRate.TabIndex = 3;
            this.cmbBaudRate.Validating += new System.ComponentModel.CancelEventHandler(this.cmbBaudRate_Validating);
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbStopBits.Location = new System.Drawing.Point(18, 242);
            this.cmbStopBits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(86, 24);
            this.cmbStopBits.TabIndex = 9;
            // 
            // chkDTR
            // 
            this.chkDTR.AutoSize = true;
            this.chkDTR.Location = new System.Drawing.Point(131, 103);
            this.chkDTR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDTR.Name = "chkDTR";
            this.chkDTR.Size = new System.Drawing.Size(59, 21);
            this.chkDTR.TabIndex = 10;
            this.chkDTR.Text = "DTR";
            this.chkDTR.UseVisualStyleBackColor = true;
            this.chkDTR.CheckedChanged += new System.EventHandler(this.chkDTR_CheckedChanged);
            // 
            // cmbParity
            // 
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.cmbParity.Location = new System.Drawing.Point(18, 142);
            this.cmbParity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(79, 24);
            this.cmbParity.TabIndex = 5;
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cmbDataBits.Location = new System.Drawing.Point(18, 192);
            this.cmbDataBits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(79, 24);
            this.cmbDataBits.TabIndex = 7;
            this.cmbDataBits.Validating += new System.ComponentModel.CancelEventHandler(this.cmbDataBits_Validating);
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(13, 23);
            this.lblComPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(73, 17);
            this.lblComPort.TabIndex = 0;
            this.lblComPort.Text = "COM Port:";
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(19, 220);
            this.lblStopBits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(68, 17);
            this.lblStopBits.TabIndex = 8;
            this.lblStopBits.Text = "Stop Bits:";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(13, 73);
            this.lblBaudRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(79, 17);
            this.lblBaudRate.TabIndex = 2;
            this.lblBaudRate.Text = "Baud Rate:";
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(13, 171);
            this.lblDataBits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(69, 17);
            this.lblDataBits.TabIndex = 6;
            this.lblDataBits.Text = "Data Bits:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parity:";
            // 
            // tab_magnetic_declination
            // 
            this.tab_magnetic_declination.Controls.Add(this.btn_set_in_compass);
            this.tab_magnetic_declination.Controls.Add(this.label4);
            this.tab_magnetic_declination.Controls.Add(this.txtbx_decimal);
            this.tab_magnetic_declination.Controls.Add(this.label3);
            this.tab_magnetic_declination.Controls.Add(this.label2);
            this.tab_magnetic_declination.Controls.Add(this.txtbx_minutes);
            this.tab_magnetic_declination.Controls.Add(this.txtbx_degrees);
            this.tab_magnetic_declination.Controls.Add(this.groupBox1);
            this.tab_magnetic_declination.Location = new System.Drawing.Point(4, 25);
            this.tab_magnetic_declination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_magnetic_declination.Name = "tab_magnetic_declination";
            this.tab_magnetic_declination.Size = new System.Drawing.Size(377, 454);
            this.tab_magnetic_declination.TabIndex = 2;
            this.tab_magnetic_declination.Text = "Magnetic Declination";
            this.tab_magnetic_declination.UseVisualStyleBackColor = true;
            // 
            // btn_set_in_compass
            // 
            this.btn_set_in_compass.Location = new System.Drawing.Point(235, 202);
            this.btn_set_in_compass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_set_in_compass.Name = "btn_set_in_compass";
            this.btn_set_in_compass.Size = new System.Drawing.Size(104, 42);
            this.btn_set_in_compass.TabIndex = 9;
            this.btn_set_in_compass.Text = "Set in Compass";
            this.btn_set_in_compass.UseVisualStyleBackColor = true;
            this.btn_set_in_compass.Click += new System.EventHandler(this.btn_set_in_compass_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "decimal";
            // 
            // txtbx_decimal
            // 
            this.txtbx_decimal.Location = new System.Drawing.Point(34, 177);
            this.txtbx_decimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbx_decimal.Name = "txtbx_decimal";
            this.txtbx_decimal.Size = new System.Drawing.Size(94, 22);
            this.txtbx_decimal.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "minutes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "degrees";
            // 
            // txtbx_minutes
            // 
            this.txtbx_minutes.Location = new System.Drawing.Point(197, 138);
            this.txtbx_minutes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbx_minutes.Name = "txtbx_minutes";
            this.txtbx_minutes.Size = new System.Drawing.Size(65, 22);
            this.txtbx_minutes.TabIndex = 4;
            // 
            // txtbx_degrees
            // 
            this.txtbx_degrees.Location = new System.Drawing.Point(34, 138);
            this.txtbx_degrees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbx_degrees.Name = "txtbx_degrees";
            this.txtbx_degrees.Size = new System.Drawing.Size(94, 22);
            this.txtbx_degrees.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdobtn_decimal);
            this.groupBox1.Controls.Add(this.rdobtn_deg_min);
            this.groupBox1.Location = new System.Drawing.Point(21, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(226, 83);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data input type";
            // 
            // rdobtn_decimal
            // 
            this.rdobtn_decimal.AutoSize = true;
            this.rdobtn_decimal.Location = new System.Drawing.Point(25, 49);
            this.rdobtn_decimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdobtn_decimal.Name = "rdobtn_decimal";
            this.rdobtn_decimal.Size = new System.Drawing.Size(79, 21);
            this.rdobtn_decimal.TabIndex = 1;
            this.rdobtn_decimal.Text = "Decimal";
            this.rdobtn_decimal.UseVisualStyleBackColor = true;
            // 
            // rdobtn_deg_min
            // 
            this.rdobtn_deg_min.AutoSize = true;
            this.rdobtn_deg_min.Checked = true;
            this.rdobtn_deg_min.Location = new System.Drawing.Point(25, 25);
            this.rdobtn_deg_min.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdobtn_deg_min.Name = "rdobtn_deg_min";
            this.rdobtn_deg_min.Size = new System.Drawing.Size(164, 21);
            this.rdobtn_deg_min.TabIndex = 0;
            this.rdobtn_deg_min.TabStop = true;
            this.rdobtn_deg_min.Text = "Degrees and Minutes";
            this.rdobtn_deg_min.UseVisualStyleBackColor = true;
            this.rdobtn_deg_min.CheckedChanged += new System.EventHandler(this.rdobtn_deg_min_CheckedChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(this.serialPort1_PinChanged);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // tmrCheckComPorts
            // 
            this.tmrCheckComPorts.Enabled = true;
            this.tmrCheckComPorts.Interval = 500;
            this.tmrCheckComPorts.Tick += new System.EventHandler(this.tmrCheckComPorts_Tick);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(325, 494);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(67, 28);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 526);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "compass";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCompass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeading)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tab_compass.ResumeLayout(false);
            this.tab_compass.PerformLayout();
            this.tab_rs232.ResumeLayout(false);
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            this.gbPortSettings.ResumeLayout(false);
            this.gbPortSettings.PerformLayout();
            this.tab_magnetic_declination.ResumeLayout(false);
            this.tab_magnetic_declination.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCompass;
        private System.Windows.Forms.HScrollBar hbarDegrees;
        private System.Windows.Forms.PictureBox picHeading;
        private System.Windows.Forms.TextBox txtbx_heading;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_compass;
        private System.Windows.Forms.TabPage tab_rs232;
        private System.Windows.Forms.GroupBox gbPortSettings;
        private System.Windows.Forms.CheckBox chkCD;
        private System.Windows.Forms.CheckBox chkRTS;
        private System.Windows.Forms.CheckBox chkDSR;
        private System.Windows.Forms.Button btn_OpenPort;
        private System.Windows.Forms.CheckBox chkCTS;
        private System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.CheckBox chkDTR;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.Label lblStopBits;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer tmrCheckComPorts;
        private System.Windows.Forms.GroupBox gbMode;
        private System.Windows.Forms.RadioButton rbText;
        private System.Windows.Forms.RadioButton rbHex;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TabPage tab_magnetic_declination;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdobtn_decimal;
        private System.Windows.Forms.RadioButton rdobtn_deg_min;
        private System.Windows.Forms.Button btn_set_in_compass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_decimal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_minutes;
        private System.Windows.Forms.TextBox txtbx_degrees;
    }
}

