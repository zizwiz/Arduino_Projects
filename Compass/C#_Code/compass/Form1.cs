using System;
using System.Windows.Forms;
using Compass.Properties;

namespace Compass
{
    public enum DataMode { Text, Hex }

    public partial class Form1 : Form
    {
        private int CurrentValue = 0;
        private Settings settings = Settings.Default;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Restore the users settings
            InitializeControlValues();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();

            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }


        private DataMode CurrentDataMode
        {
            get
            {
                if (rbHex.Checked) return DataMode.Hex;
                else return DataMode.Text;
            }

            set
            {
                if (value == DataMode.Text) rbText.Checked = true;
                else rbHex.Checked = true;
            }
        }


        private void txtbx_heading_TextChanged(object sender, EventArgs e)
        {
            int heading_value = 0;
            try
            {
                heading_value = Int32.Parse(txtbx_heading.Text.Substring(0, txtbx_heading.Text.Length - 1));

            }
            catch (Exception exception)
            {
                MessageBox.Show("Something went wrong we are resetting\r" + exception);
                txtbx_heading.Text = "0°";
            }
           
            if (heading_value <= 0)
            {
                heading_value = 0;
            }

            if (heading_value > 360)
            {
                heading_value = 360;
            }

            hbarDegrees.Value = CurrentValue = heading_value;
             
            picCompass.Refresh();
            picHeading.Refresh();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

       
    }
}