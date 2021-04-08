namespace SetArduinoRTC
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
            this.rchtxbx_output = new System.Windows.Forms.RichTextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.chkCD = new System.Windows.Forms.CheckBox();
            this.chkRTS = new System.Windows.Forms.CheckBox();
            this.chkDSR = new System.Windows.Forms.CheckBox();
            this.btnOpenPort = new System.Windows.Forms.Button();
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tmrCheckComPorts = new System.Windows.Forms.Timer(this.components);
            this.btn_get_data = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.num_up_down_delay = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.chkbx_constant = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_readings = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_temp_in = new System.Windows.Forms.Label();
            this.aGauge_temp_in = new AGaugeApp.AGauge();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbl_humid_in = new System.Windows.Forms.Label();
            this.aGauge_humid_in = new AGaugeApp.AGauge();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lbl_temp_out = new System.Windows.Forms.Label();
            this.aGauge_temp_out = new AGaugeApp.AGauge();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lbl_humid_out = new System.Windows.Forms.Label();
            this.aGauge_humid_out = new AGaugeApp.AGauge();
            this.tab_data = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tab_rs232 = new System.Windows.Forms.TabPage();
            this.grpbx_constant = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_up_down_delay)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_readings.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.tab_data.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tab_rs232.SuspendLayout();
            this.grpbx_constant.SuspendLayout();
            this.SuspendLayout();
            // 
            // rchtxbx_output
            // 
            this.rchtxbx_output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchtxbx_output.Location = new System.Drawing.Point(0, 0);
            this.rchtxbx_output.Margin = new System.Windows.Forms.Padding(4);
            this.rchtxbx_output.Name = "rchtxbx_output";
            this.rchtxbx_output.ReadOnly = true;
            this.rchtxbx_output.Size = new System.Drawing.Size(516, 497);
            this.rchtxbx_output.TabIndex = 1;
            this.rchtxbx_output.Text = "";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(254, 19);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(67, 36);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // chkCD
            // 
            this.chkCD.AutoSize = true;
            this.chkCD.Enabled = false;
            this.chkCD.Location = new System.Drawing.Point(289, 106);
            this.chkCD.Margin = new System.Windows.Forms.Padding(4);
            this.chkCD.Name = "chkCD";
            this.chkCD.Size = new System.Drawing.Size(49, 21);
            this.chkCD.TabIndex = 14;
            this.chkCD.Text = "CD";
            this.chkCD.UseVisualStyleBackColor = true;
            // 
            // chkRTS
            // 
            this.chkRTS.AutoSize = true;
            this.chkRTS.Location = new System.Drawing.Point(91, 106);
            this.chkRTS.Margin = new System.Windows.Forms.Padding(4);
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
            this.chkDSR.Location = new System.Drawing.Point(222, 106);
            this.chkDSR.Margin = new System.Windows.Forms.Padding(4);
            this.chkDSR.Name = "chkDSR";
            this.chkDSR.Size = new System.Drawing.Size(59, 21);
            this.chkDSR.TabIndex = 13;
            this.chkDSR.Text = "DSR";
            this.chkDSR.UseVisualStyleBackColor = true;
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(356, 91);
            this.btnOpenPort.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(121, 48);
            this.btnOpenPort.TabIndex = 10;
            this.btnOpenPort.Text = "&Open Port";
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // chkCTS
            // 
            this.chkCTS.AutoSize = true;
            this.chkCTS.Enabled = false;
            this.chkCTS.Location = new System.Drawing.Point(157, 106);
            this.chkCTS.Margin = new System.Windows.Forms.Padding(4);
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
            this.cmbPortName.Location = new System.Drawing.Point(23, 55);
            this.cmbPortName.Margin = new System.Windows.Forms.Padding(4);
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
            this.cmbBaudRate.Location = new System.Drawing.Point(119, 55);
            this.cmbBaudRate.Margin = new System.Windows.Forms.Padding(4);
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
            this.cmbStopBits.Location = new System.Drawing.Point(392, 55);
            this.cmbStopBits.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(85, 24);
            this.cmbStopBits.TabIndex = 9;
            // 
            // chkDTR
            // 
            this.chkDTR.AutoSize = true;
            this.chkDTR.Location = new System.Drawing.Point(24, 106);
            this.chkDTR.Margin = new System.Windows.Forms.Padding(4);
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
            this.cmbParity.Location = new System.Drawing.Point(218, 55);
            this.cmbParity.Margin = new System.Windows.Forms.Padding(4);
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
            this.cmbDataBits.Location = new System.Drawing.Point(305, 55);
            this.cmbDataBits.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(79, 24);
            this.cmbDataBits.TabIndex = 7;
            this.cmbDataBits.Validating += new System.ComponentModel.CancelEventHandler(this.cmbDataBits_Validating);
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(29, 35);
            this.lblComPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(73, 17);
            this.lblComPort.TabIndex = 0;
            this.lblComPort.Text = "COM Port:";
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(401, 34);
            this.lblStopBits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(68, 17);
            this.lblStopBits.TabIndex = 8;
            this.lblStopBits.Text = "Stop Bits:";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(124, 34);
            this.lblBaudRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(79, 17);
            this.lblBaudRate.TabIndex = 2;
            this.lblBaudRate.Text = "Baud Rate:";
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(310, 34);
            this.lblDataBits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(69, 17);
            this.lblDataBits.TabIndex = 6;
            this.lblDataBits.Text = "Data Bits:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parity:";
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
            // btn_get_data
            // 
            this.btn_get_data.Location = new System.Drawing.Point(10, 19);
            this.btn_get_data.Margin = new System.Windows.Forms.Padding(4);
            this.btn_get_data.Name = "btn_get_data";
            this.btn_get_data.Size = new System.Drawing.Size(96, 36);
            this.btn_get_data.TabIndex = 7;
            this.btn_get_data.Text = "Get Data";
            this.btn_get_data.UseVisualStyleBackColor = true;
            this.btn_get_data.Click += new System.EventHandler(this.btn_getdata_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(14, 4);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(67, 36);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(633, 680);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpbx_constant);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_get_data);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 130);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "seconds";
            // 
            // num_up_down_delay
            // 
            this.num_up_down_delay.Location = new System.Drawing.Point(153, 16);
            this.num_up_down_delay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_up_down_delay.Name = "num_up_down_delay";
            this.num_up_down_delay.Size = new System.Drawing.Size(56, 22);
            this.num_up_down_delay.TabIndex = 10;
            this.num_up_down_delay.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "every";
            // 
            // chkbx_constant
            // 
            this.chkbx_constant.AutoSize = true;
            this.chkbx_constant.Location = new System.Drawing.Point(12, 17);
            this.chkbx_constant.Name = "chkbx_constant";
            this.chkbx_constant.Size = new System.Drawing.Size(86, 21);
            this.chkbx_constant.TabIndex = 8;
            this.chkbx_constant.Text = "Constant";
            this.chkbx_constant.UseVisualStyleBackColor = true;
            this.chkbx_constant.CheckedChanged += new System.EventHandler(this.chkbx_constant_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 538);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_readings);
            this.tabControl1.Controls.Add(this.tab_data);
            this.tabControl1.Controls.Add(this.tab_rs232);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(627, 538);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_readings
            // 
            this.tab_readings.Controls.Add(this.tableLayoutPanel3);
            this.tab_readings.Location = new System.Drawing.Point(4, 25);
            this.tab_readings.Name = "tab_readings";
            this.tab_readings.Padding = new System.Windows.Forms.Padding(3);
            this.tab_readings.Size = new System.Drawing.Size(619, 509);
            this.tab_readings.TabIndex = 0;
            this.tab_readings.Text = "Current Readings";
            this.tab_readings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel6, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.panel7, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel8, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel9, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel10, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel11, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.panel12, 2, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(613, 503);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(55, 220);
            this.panel5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "In";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 279);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(55, 221);
            this.panel6.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Out";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbl_temp_in);
            this.panel7.Controls.Add(this.aGauge_temp_in);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(64, 53);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(269, 220);
            this.panel7.TabIndex = 2;
            // 
            // lbl_temp_in
            // 
            this.lbl_temp_in.AutoSize = true;
            this.lbl_temp_in.Location = new System.Drawing.Point(99, 162);
            this.lbl_temp_in.Name = "lbl_temp_in";
            this.lbl_temp_in.Size = new System.Drawing.Size(16, 17);
            this.lbl_temp_in.TabIndex = 1;
            this.lbl_temp_in.Text = "0";
            // 
            // aGauge_temp_in
            // 
            this.aGauge_temp_in.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge_temp_in.BaseArcRadius = 80;
            this.aGauge_temp_in.BaseArcStart = 135;
            this.aGauge_temp_in.BaseArcSweep = 270;
            this.aGauge_temp_in.BaseArcWidth = 2;
            this.aGauge_temp_in.Cap_Idx = ((byte)(1));
            this.aGauge_temp_in.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge_temp_in.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge_temp_in.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge_temp_in.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge_temp_in.CapText = "";
            this.aGauge_temp_in.Center = new System.Drawing.Point(100, 100);
            this.aGauge_temp_in.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aGauge_temp_in.Location = new System.Drawing.Point(0, 0);
            this.aGauge_temp_in.MaxValue = 50F;
            this.aGauge_temp_in.MinValue = -20F;
            this.aGauge_temp_in.Name = "aGauge_temp_in";
            this.aGauge_temp_in.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge_temp_in.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge_temp_in.NeedleRadius = 80;
            this.aGauge_temp_in.NeedleType = 0;
            this.aGauge_temp_in.NeedleWidth = 2;
            this.aGauge_temp_in.Range_Idx = ((byte)(0));
            this.aGauge_temp_in.RangeColor = System.Drawing.Color.Transparent;
            this.aGauge_temp_in.RangeEnabled = true;
            this.aGauge_temp_in.RangeEndValue = 50F;
            this.aGauge_temp_in.RangeInnerRadius = 70;
            this.aGauge_temp_in.RangeOuterRadius = 80;
            this.aGauge_temp_in.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.Transparent,
        System.Drawing.Color.Transparent,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge_temp_in.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.aGauge_temp_in.RangesEndValue = new float[] {
        50F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge_temp_in.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge_temp_in.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge_temp_in.RangesStartValue = new float[] {
        -20F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge_temp_in.RangeStartValue = -20F;
            this.aGauge_temp_in.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge_temp_in.ScaleLinesInterInnerRadius = 73;
            this.aGauge_temp_in.ScaleLinesInterOuterRadius = 80;
            this.aGauge_temp_in.ScaleLinesInterWidth = 1;
            this.aGauge_temp_in.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge_temp_in.ScaleLinesMajorInnerRadius = 70;
            this.aGauge_temp_in.ScaleLinesMajorOuterRadius = 80;
            this.aGauge_temp_in.ScaleLinesMajorStepValue = 5F;
            this.aGauge_temp_in.ScaleLinesMajorWidth = 2;
            this.aGauge_temp_in.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge_temp_in.ScaleLinesMinorInnerRadius = 75;
            this.aGauge_temp_in.ScaleLinesMinorNumOf = 9;
            this.aGauge_temp_in.ScaleLinesMinorOuterRadius = 80;
            this.aGauge_temp_in.ScaleLinesMinorWidth = 1;
            this.aGauge_temp_in.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge_temp_in.ScaleNumbersFormat = null;
            this.aGauge_temp_in.ScaleNumbersRadius = 95;
            this.aGauge_temp_in.ScaleNumbersRotation = 0;
            this.aGauge_temp_in.ScaleNumbersStartScaleLine = 0;
            this.aGauge_temp_in.ScaleNumbersStepScaleLines = 1;
            this.aGauge_temp_in.Size = new System.Drawing.Size(269, 220);
            this.aGauge_temp_in.TabIndex = 0;
            this.aGauge_temp_in.Text = "Temp_in";
            this.aGauge_temp_in.Value = 0F;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lbl_humid_in);
            this.panel8.Controls.Add(this.aGauge_humid_in);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(339, 53);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(271, 220);
            this.panel8.TabIndex = 3;
            // 
            // lbl_humid_in
            // 
            this.lbl_humid_in.AutoSize = true;
            this.lbl_humid_in.Location = new System.Drawing.Point(99, 162);
            this.lbl_humid_in.Name = "lbl_humid_in";
            this.lbl_humid_in.Size = new System.Drawing.Size(16, 17);
            this.lbl_humid_in.TabIndex = 3;
            this.lbl_humid_in.Text = "0";
            // 
            // aGauge_humid_in
            // 
            this.aGauge_humid_in.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge_humid_in.BaseArcRadius = 80;
            this.aGauge_humid_in.BaseArcStart = 135;
            this.aGauge_humid_in.BaseArcSweep = 270;
            this.aGauge_humid_in.BaseArcWidth = 2;
            this.aGauge_humid_in.Cap_Idx = ((byte)(1));
            this.aGauge_humid_in.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge_humid_in.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge_humid_in.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge_humid_in.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge_humid_in.CapText = "";
            this.aGauge_humid_in.Center = new System.Drawing.Point(100, 100);
            this.aGauge_humid_in.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aGauge_humid_in.Location = new System.Drawing.Point(0, 0);
            this.aGauge_humid_in.MaxValue = 100F;
            this.aGauge_humid_in.MinValue = 0F;
            this.aGauge_humid_in.Name = "aGauge_humid_in";
            this.aGauge_humid_in.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge_humid_in.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge_humid_in.NeedleRadius = 80;
            this.aGauge_humid_in.NeedleType = 0;
            this.aGauge_humid_in.NeedleWidth = 2;
            this.aGauge_humid_in.Range_Idx = ((byte)(0));
            this.aGauge_humid_in.RangeColor = System.Drawing.Color.Transparent;
            this.aGauge_humid_in.RangeEnabled = true;
            this.aGauge_humid_in.RangeEndValue = 100F;
            this.aGauge_humid_in.RangeInnerRadius = 70;
            this.aGauge_humid_in.RangeOuterRadius = 80;
            this.aGauge_humid_in.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.Transparent,
        System.Drawing.Color.Transparent,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge_humid_in.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.aGauge_humid_in.RangesEndValue = new float[] {
        100F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge_humid_in.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge_humid_in.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge_humid_in.RangesStartValue = new float[] {
        0F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge_humid_in.RangeStartValue = 0F;
            this.aGauge_humid_in.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge_humid_in.ScaleLinesInterInnerRadius = 73;
            this.aGauge_humid_in.ScaleLinesInterOuterRadius = 80;
            this.aGauge_humid_in.ScaleLinesInterWidth = 1;
            this.aGauge_humid_in.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge_humid_in.ScaleLinesMajorInnerRadius = 70;
            this.aGauge_humid_in.ScaleLinesMajorOuterRadius = 80;
            this.aGauge_humid_in.ScaleLinesMajorStepValue = 10F;
            this.aGauge_humid_in.ScaleLinesMajorWidth = 2;
            this.aGauge_humid_in.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge_humid_in.ScaleLinesMinorInnerRadius = 75;
            this.aGauge_humid_in.ScaleLinesMinorNumOf = 9;
            this.aGauge_humid_in.ScaleLinesMinorOuterRadius = 80;
            this.aGauge_humid_in.ScaleLinesMinorWidth = 1;
            this.aGauge_humid_in.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge_humid_in.ScaleNumbersFormat = null;
            this.aGauge_humid_in.ScaleNumbersRadius = 95;
            this.aGauge_humid_in.ScaleNumbersRotation = 0;
            this.aGauge_humid_in.ScaleNumbersStartScaleLine = 0;
            this.aGauge_humid_in.ScaleNumbersStepScaleLines = 1;
            this.aGauge_humid_in.Size = new System.Drawing.Size(271, 220);
            this.aGauge_humid_in.TabIndex = 2;
            this.aGauge_humid_in.Text = "Humid_in";
            this.aGauge_humid_in.Value = 0F;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(64, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(269, 44);
            this.panel9.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Temperature";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label3);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(339, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(271, 44);
            this.panel10.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Humidity";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.lbl_temp_out);
            this.panel11.Controls.Add(this.aGauge_temp_out);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(64, 279);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(269, 221);
            this.panel11.TabIndex = 6;
            // 
            // lbl_temp_out
            // 
            this.lbl_temp_out.AutoSize = true;
            this.lbl_temp_out.Location = new System.Drawing.Point(99, 162);
            this.lbl_temp_out.Name = "lbl_temp_out";
            this.lbl_temp_out.Size = new System.Drawing.Size(16, 17);
            this.lbl_temp_out.TabIndex = 3;
            this.lbl_temp_out.Text = "0";
            // 
            // aGauge_temp_out
            // 
            this.aGauge_temp_out.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge_temp_out.BaseArcRadius = 80;
            this.aGauge_temp_out.BaseArcStart = 135;
            this.aGauge_temp_out.BaseArcSweep = 270;
            this.aGauge_temp_out.BaseArcWidth = 2;
            this.aGauge_temp_out.Cap_Idx = ((byte)(1));
            this.aGauge_temp_out.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge_temp_out.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge_temp_out.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge_temp_out.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge_temp_out.CapText = "";
            this.aGauge_temp_out.Center = new System.Drawing.Point(100, 100);
            this.aGauge_temp_out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aGauge_temp_out.Location = new System.Drawing.Point(0, 0);
            this.aGauge_temp_out.MaxValue = 50F;
            this.aGauge_temp_out.MinValue = -20F;
            this.aGauge_temp_out.Name = "aGauge_temp_out";
            this.aGauge_temp_out.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge_temp_out.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge_temp_out.NeedleRadius = 80;
            this.aGauge_temp_out.NeedleType = 0;
            this.aGauge_temp_out.NeedleWidth = 2;
            this.aGauge_temp_out.Range_Idx = ((byte)(0));
            this.aGauge_temp_out.RangeColor = System.Drawing.Color.Transparent;
            this.aGauge_temp_out.RangeEnabled = true;
            this.aGauge_temp_out.RangeEndValue = 50F;
            this.aGauge_temp_out.RangeInnerRadius = 70;
            this.aGauge_temp_out.RangeOuterRadius = 80;
            this.aGauge_temp_out.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.Transparent,
        System.Drawing.Color.Transparent,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge_temp_out.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.aGauge_temp_out.RangesEndValue = new float[] {
        50F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge_temp_out.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge_temp_out.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge_temp_out.RangesStartValue = new float[] {
        -20F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge_temp_out.RangeStartValue = -20F;
            this.aGauge_temp_out.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge_temp_out.ScaleLinesInterInnerRadius = 73;
            this.aGauge_temp_out.ScaleLinesInterOuterRadius = 80;
            this.aGauge_temp_out.ScaleLinesInterWidth = 1;
            this.aGauge_temp_out.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge_temp_out.ScaleLinesMajorInnerRadius = 70;
            this.aGauge_temp_out.ScaleLinesMajorOuterRadius = 80;
            this.aGauge_temp_out.ScaleLinesMajorStepValue = 5F;
            this.aGauge_temp_out.ScaleLinesMajorWidth = 2;
            this.aGauge_temp_out.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge_temp_out.ScaleLinesMinorInnerRadius = 75;
            this.aGauge_temp_out.ScaleLinesMinorNumOf = 9;
            this.aGauge_temp_out.ScaleLinesMinorOuterRadius = 80;
            this.aGauge_temp_out.ScaleLinesMinorWidth = 1;
            this.aGauge_temp_out.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge_temp_out.ScaleNumbersFormat = null;
            this.aGauge_temp_out.ScaleNumbersRadius = 95;
            this.aGauge_temp_out.ScaleNumbersRotation = 0;
            this.aGauge_temp_out.ScaleNumbersStartScaleLine = 0;
            this.aGauge_temp_out.ScaleNumbersStepScaleLines = 1;
            this.aGauge_temp_out.Size = new System.Drawing.Size(269, 221);
            this.aGauge_temp_out.TabIndex = 2;
            this.aGauge_temp_out.Text = "Temp_in";
            this.aGauge_temp_out.Value = 0F;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.lbl_humid_out);
            this.panel12.Controls.Add(this.aGauge_humid_out);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(339, 279);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(271, 221);
            this.panel12.TabIndex = 7;
            // 
            // lbl_humid_out
            // 
            this.lbl_humid_out.AutoSize = true;
            this.lbl_humid_out.Location = new System.Drawing.Point(99, 162);
            this.lbl_humid_out.Name = "lbl_humid_out";
            this.lbl_humid_out.Size = new System.Drawing.Size(16, 17);
            this.lbl_humid_out.TabIndex = 5;
            this.lbl_humid_out.Text = "0";
            // 
            // aGauge_humid_out
            // 
            this.aGauge_humid_out.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge_humid_out.BaseArcRadius = 80;
            this.aGauge_humid_out.BaseArcStart = 135;
            this.aGauge_humid_out.BaseArcSweep = 270;
            this.aGauge_humid_out.BaseArcWidth = 2;
            this.aGauge_humid_out.Cap_Idx = ((byte)(1));
            this.aGauge_humid_out.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge_humid_out.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge_humid_out.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge_humid_out.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge_humid_out.CapText = "";
            this.aGauge_humid_out.Center = new System.Drawing.Point(100, 100);
            this.aGauge_humid_out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aGauge_humid_out.Location = new System.Drawing.Point(0, 0);
            this.aGauge_humid_out.MaxValue = 100F;
            this.aGauge_humid_out.MinValue = 0F;
            this.aGauge_humid_out.Name = "aGauge_humid_out";
            this.aGauge_humid_out.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge_humid_out.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge_humid_out.NeedleRadius = 80;
            this.aGauge_humid_out.NeedleType = 0;
            this.aGauge_humid_out.NeedleWidth = 2;
            this.aGauge_humid_out.Range_Idx = ((byte)(0));
            this.aGauge_humid_out.RangeColor = System.Drawing.Color.Transparent;
            this.aGauge_humid_out.RangeEnabled = true;
            this.aGauge_humid_out.RangeEndValue = 100F;
            this.aGauge_humid_out.RangeInnerRadius = 70;
            this.aGauge_humid_out.RangeOuterRadius = 80;
            this.aGauge_humid_out.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.Transparent,
        System.Drawing.Color.Transparent,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge_humid_out.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.aGauge_humid_out.RangesEndValue = new float[] {
        100F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge_humid_out.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge_humid_out.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge_humid_out.RangesStartValue = new float[] {
        0F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge_humid_out.RangeStartValue = 0F;
            this.aGauge_humid_out.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge_humid_out.ScaleLinesInterInnerRadius = 73;
            this.aGauge_humid_out.ScaleLinesInterOuterRadius = 80;
            this.aGauge_humid_out.ScaleLinesInterWidth = 1;
            this.aGauge_humid_out.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge_humid_out.ScaleLinesMajorInnerRadius = 70;
            this.aGauge_humid_out.ScaleLinesMajorOuterRadius = 80;
            this.aGauge_humid_out.ScaleLinesMajorStepValue = 10F;
            this.aGauge_humid_out.ScaleLinesMajorWidth = 2;
            this.aGauge_humid_out.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge_humid_out.ScaleLinesMinorInnerRadius = 75;
            this.aGauge_humid_out.ScaleLinesMinorNumOf = 9;
            this.aGauge_humid_out.ScaleLinesMinorOuterRadius = 80;
            this.aGauge_humid_out.ScaleLinesMinorWidth = 1;
            this.aGauge_humid_out.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge_humid_out.ScaleNumbersFormat = null;
            this.aGauge_humid_out.ScaleNumbersRadius = 95;
            this.aGauge_humid_out.ScaleNumbersRotation = 0;
            this.aGauge_humid_out.ScaleNumbersStartScaleLine = 0;
            this.aGauge_humid_out.ScaleNumbersStepScaleLines = 1;
            this.aGauge_humid_out.Size = new System.Drawing.Size(271, 221);
            this.aGauge_humid_out.TabIndex = 4;
            this.aGauge_humid_out.Text = "Temp_in";
            this.aGauge_humid_out.Value = 0F;
            // 
            // tab_data
            // 
            this.tab_data.Controls.Add(this.tableLayoutPanel2);
            this.tab_data.Location = new System.Drawing.Point(4, 25);
            this.tab_data.Name = "tab_data";
            this.tab_data.Padding = new System.Windows.Forms.Padding(3);
            this.tab_data.Size = new System.Drawing.Size(619, 509);
            this.tab_data.TabIndex = 1;
            this.tab_data.Text = "Data";
            this.tab_data.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.16261F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.8374F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(613, 503);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rchtxbx_output);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(516, 497);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_clear);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(525, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(85, 497);
            this.panel4.TabIndex = 1;
            // 
            // tab_rs232
            // 
            this.tab_rs232.Controls.Add(this.chkCD);
            this.tab_rs232.Controls.Add(this.chkRTS);
            this.tab_rs232.Controls.Add(this.lblBaudRate);
            this.tab_rs232.Controls.Add(this.chkDSR);
            this.tab_rs232.Controls.Add(this.label1);
            this.tab_rs232.Controls.Add(this.btnOpenPort);
            this.tab_rs232.Controls.Add(this.lblDataBits);
            this.tab_rs232.Controls.Add(this.chkCTS);
            this.tab_rs232.Controls.Add(this.lblStopBits);
            this.tab_rs232.Controls.Add(this.cmbPortName);
            this.tab_rs232.Controls.Add(this.lblComPort);
            this.tab_rs232.Controls.Add(this.cmbBaudRate);
            this.tab_rs232.Controls.Add(this.cmbDataBits);
            this.tab_rs232.Controls.Add(this.cmbStopBits);
            this.tab_rs232.Controls.Add(this.cmbParity);
            this.tab_rs232.Controls.Add(this.chkDTR);
            this.tab_rs232.Location = new System.Drawing.Point(4, 25);
            this.tab_rs232.Name = "tab_rs232";
            this.tab_rs232.Size = new System.Drawing.Size(619, 509);
            this.tab_rs232.TabIndex = 2;
            this.tab_rs232.Text = "RS232 Settings";
            this.tab_rs232.UseVisualStyleBackColor = true;
            // 
            // grpbx_constant
            // 
            this.grpbx_constant.Controls.Add(this.label7);
            this.grpbx_constant.Controls.Add(this.num_up_down_delay);
            this.grpbx_constant.Controls.Add(this.label6);
            this.grpbx_constant.Controls.Add(this.chkbx_constant);
            this.grpbx_constant.Location = new System.Drawing.Point(19, 62);
            this.grpbx_constant.Name = "grpbx_constant";
            this.grpbx_constant.Size = new System.Drawing.Size(284, 55);
            this.grpbx_constant.TabIndex = 12;
            this.grpbx_constant.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 680);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Humidity and Temperature";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_up_down_delay)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab_readings.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.tab_data.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tab_rs232.ResumeLayout(false);
            this.tab_rs232.PerformLayout();
            this.grpbx_constant.ResumeLayout(false);
            this.grpbx_constant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rchtxbx_output;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.CheckBox chkCD;
        private System.Windows.Forms.CheckBox chkRTS;
        private System.Windows.Forms.CheckBox chkDSR;
        private System.Windows.Forms.Button btnOpenPort;
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
        private System.Windows.Forms.Button btn_get_data;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_readings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TabPage tab_data;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabPage tab_rs232;
        private AGaugeApp.AGauge aGauge_temp_in;
        private System.Windows.Forms.Label lbl_temp_in;
        private System.Windows.Forms.Label lbl_humid_in;
        private AGaugeApp.AGauge aGauge_humid_in;
        private System.Windows.Forms.Label lbl_temp_out;
        private AGaugeApp.AGauge aGauge_temp_out;
        private System.Windows.Forms.Label lbl_humid_out;
        private AGaugeApp.AGauge aGauge_humid_out;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown num_up_down_delay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkbx_constant;
        private System.Windows.Forms.GroupBox grpbx_constant;
    }
}

