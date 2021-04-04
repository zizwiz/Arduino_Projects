using System;
using System.Drawing;
using System.Windows.Forms;
using SetArduinoRTC.Properties;


namespace SetArduinoRTC
{
    #region Public Enumerations
    public enum DataMode { Text, Hex }
    public enum LogMsgType { Incoming, Outgoing, Normal, Warning, Error };
    #endregion

    public partial class Form1 : Form
    {
        #region Private Variables

        // Various colors for logging info
        private Color[] LogMsgTypeColor = { Color.Blue, Color.Green, Color.Black, Color.Orange, Color.Red };
        private Settings settings = Settings.Default;

        #endregion

        public Form1()
        {
            InitializeComponent();
            // Restore the users settings
            InitializeControlValues();

            // Enable/disable controls based on the current state
            EnableControls();
            btn_setclock.Enabled = false;
        }
        
        private void btn_clear_Click(object sender, EventArgs e)
        {
            rchtxbx_output.Clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void btn_setclock_Click(object sender, EventArgs e)
        {
            int year = Int32.Parse(DateTime.Now.ToString("yyyy"));
            int month = Int32.Parse(DateTime.Now.ToString("MM"));
            int day = Int32.Parse(DateTime.Now.ToString("dd"));

            string dow = ConvertStringToHex((((int)DateTime.Now.DayOfWeek + 6) % 7 + 1).ToString());
            string date = ConvertStringToHex(DateTime.Now.ToString("ddMMyyyy"));

            //We need to add 1 to second so it can be correct once it is in the module. 
            SendData(ConvertStringToHex(DateTime.Now.ToString("HHmm")) + ConvertStringToHex(((int)DateTime.Now.Second+1).ToString().PadLeft(2,'0')) + date + dow + "04");
        }

        
    }
}
