namespace StepperMotorTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbl_stepper_signal = new System.Windows.Forms.Label();
            this.lbl_stepper_pins = new System.Windows.Forms.Label();
            this.btn_stop_stepper = new System.Windows.Forms.Button();
            this.lbl_stepper_delay = new System.Windows.Forms.Label();
            this.lbl_stepper_value = new System.Windows.Forms.Label();
            this.trkbr_stepper = new System.Windows.Forms.TrackBar();
            this.btn_stepper_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkbr_stepper)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(937, 280);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 274);
            this.panel1.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.lbl_stepper_signal);
            this.groupBox6.Controls.Add(this.lbl_stepper_pins);
            this.groupBox6.Controls.Add(this.btn_stop_stepper);
            this.groupBox6.Controls.Add(this.lbl_stepper_delay);
            this.groupBox6.Controls.Add(this.lbl_stepper_value);
            this.groupBox6.Controls.Add(this.trkbr_stepper);
            this.groupBox6.Controls.Add(this.btn_stepper_start);
            this.groupBox6.Location = new System.Drawing.Point(29, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(881, 204);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Stepper Motor";
            // 
            // lbl_stepper_signal
            // 
            this.lbl_stepper_signal.AutoSize = true;
            this.lbl_stepper_signal.Location = new System.Drawing.Point(419, 82);
            this.lbl_stepper_signal.Name = "lbl_stepper_signal";
            this.lbl_stepper_signal.Size = new System.Drawing.Size(32, 17);
            this.lbl_stepper_signal.TabIndex = 9;
            this.lbl_stepper_signal.Text = "......";
            // 
            // lbl_stepper_pins
            // 
            this.lbl_stepper_pins.AutoSize = true;
            this.lbl_stepper_pins.Location = new System.Drawing.Point(419, 49);
            this.lbl_stepper_pins.Name = "lbl_stepper_pins";
            this.lbl_stepper_pins.Size = new System.Drawing.Size(32, 17);
            this.lbl_stepper_pins.TabIndex = 8;
            this.lbl_stepper_pins.Text = "......";
            // 
            // btn_stop_stepper
            // 
            this.btn_stop_stepper.Location = new System.Drawing.Point(712, 49);
            this.btn_stop_stepper.Name = "btn_stop_stepper";
            this.btn_stop_stepper.Size = new System.Drawing.Size(126, 50);
            this.btn_stop_stepper.TabIndex = 7;
            this.btn_stop_stepper.Text = "Stop";
            this.btn_stop_stepper.UseVisualStyleBackColor = true;
            this.btn_stop_stepper.Click += new System.EventHandler(this.btn_stop_stepper_Click);
            // 
            // lbl_stepper_delay
            // 
            this.lbl_stepper_delay.AutoSize = true;
            this.lbl_stepper_delay.Location = new System.Drawing.Point(419, 18);
            this.lbl_stepper_delay.Name = "lbl_stepper_delay";
            this.lbl_stepper_delay.Size = new System.Drawing.Size(32, 17);
            this.lbl_stepper_delay.TabIndex = 6;
            this.lbl_stepper_delay.Text = "......";
            // 
            // lbl_stepper_value
            // 
            this.lbl_stepper_value.AutoSize = true;
            this.lbl_stepper_value.Location = new System.Drawing.Point(419, 169);
            this.lbl_stepper_value.Name = "lbl_stepper_value";
            this.lbl_stepper_value.Size = new System.Drawing.Size(44, 17);
            this.lbl_stepper_value.TabIndex = 5;
            this.lbl_stepper_value.Text = "Value";
            // 
            // trkbr_stepper
            // 
            this.trkbr_stepper.Location = new System.Drawing.Point(33, 121);
            this.trkbr_stepper.Maximum = 1023;
            this.trkbr_stepper.Name = "trkbr_stepper";
            this.trkbr_stepper.Size = new System.Drawing.Size(809, 56);
            this.trkbr_stepper.TabIndex = 3;
            this.trkbr_stepper.TickFrequency = 100;
            this.trkbr_stepper.Value = 300;
            this.trkbr_stepper.Scroll += new System.EventHandler(this.trkbr_stepper_Scroll);
            // 
            // btn_stepper_start
            // 
            this.btn_stepper_start.Location = new System.Drawing.Point(33, 49);
            this.btn_stepper_start.Name = "btn_stepper_start";
            this.btn_stepper_start.Size = new System.Drawing.Size(126, 50);
            this.btn_stepper_start.TabIndex = 0;
            this.btn_stepper_start.Text = "Start";
            this.btn_stepper_start.UseVisualStyleBackColor = true;
            this.btn_stepper_start.Click += new System.EventHandler(this.btn_stepper_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Level:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pins:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Delay:";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(765, 227);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(125, 35);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 280);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Firmata Stepper Motor Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkbr_stepper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbl_stepper_signal;
        private System.Windows.Forms.Label lbl_stepper_pins;
        private System.Windows.Forms.Button btn_stop_stepper;
        private System.Windows.Forms.Label lbl_stepper_delay;
        private System.Windows.Forms.Label lbl_stepper_value;
        private System.Windows.Forms.TrackBar trkbr_stepper;
        private System.Windows.Forms.Button btn_stepper_start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exit;
    }
}

