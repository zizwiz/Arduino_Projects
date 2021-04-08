using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Humidity_Temperature.Properties;


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
        private string[] values;
        private Thread _readThread = null;
        private bool flag = false;
        #endregion

        public Form1()
        {
            InitializeComponent();
            // Restore the users settings
            InitializeControlValues();

            // Enable/disable controls based on the current state
            EnableControls();
            btn_get_data.Enabled = false;
            grpbx_constant.Enabled = false;
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
            //int year = Int32.Parse(DateTime.Now.ToString("yyyy"));
           // int month = Int32.Parse(DateTime.Now.ToString("MM"));
          //  int day = Int32.Parse(DateTime.Now.ToString("dd"));

           // string dow = ConvertStringToHex((((int)DateTime.Now.DayOfWeek + 6) % 7 + 1).ToString());
           // string date = ConvertStringToHex(DateTime.Now.ToString("ddMMyyyy"));

            //We need to add 1 to second so it can be correct once it is in the module. 
            //SendData(ConvertStringToHex(DateTime.Now.ToString("HHmm")) + ConvertStringToHex(((int)DateTime.Now.Second+1).ToString().PadLeft(2,'0')) + date + dow + "04");

            
        }

        private void btn_getdata_Click(object sender, EventArgs e)
        {
            SendData(ConvertStringToHex("1"));
        }

        private void ShowData()
        {
            Invoke(new Action(() =>
            {
                // Temperature in
                lbl_temp_in.Text = values[0] + "°C";
                aGauge_temp_in.Value = float.Parse(values[0]);

                // Humidity in
                lbl_humid_in.Text = values[1] + "%";
                aGauge_humid_in.Value = float.Parse(values[1]);

                // Temperature out
                lbl_temp_out.Text = values[2] + "°C";
                aGauge_temp_out.Value = float.Parse(values[2]);

                // Humidity out
                lbl_humid_out.Text = values[3] + "%";
                aGauge_humid_out.Value = float.Parse(values[3]);
            }));
        }

        private void chkbx_constant_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkbx_constant.Checked)
            {
                flag = true;
                _readThread = new Thread(StartWork);
                _readThread.Start();
            }
            else
            {
                flag = false;
                _readThread.Abort();
            }

        }


        private async void StartWork()
        {
            do
            {
                SendData(ConvertStringToHex("1"));
               // Thread.Sleep(((Int32)(num_up_down_delay.Value)) * 1000);
                Task.Delay(((Int32)(num_up_down_delay.Value)) * 1000).Wait();
                ReadData();

            } while (flag);

        }
    }
}
