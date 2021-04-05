using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Compass
{
    public partial class Form1
    {

        private void InitializeControlValues()
        {
            tabControl1.TabPages.Remove(tab_magnetic_declination); //make invisible
            

            cmbParity.Items.Clear(); cmbParity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            cmbStopBits.Items.Clear(); cmbStopBits.Items.AddRange(Enum.GetNames(typeof(StopBits)));

            cmbParity.Text = settings.Parity.ToString();
            cmbStopBits.Text = settings.StopBits.ToString();
            cmbDataBits.Text = settings.DataBits.ToString();
            cmbParity.Text = settings.Parity.ToString();
            cmbBaudRate.Text = settings.BaudRate.ToString();
            CurrentDataMode = settings.DataMode;
            rdobtn_decimal.Checked = settings.rdobtn_decimal;
            rdobtn_deg_min.Checked = settings.rdobtn_deg_min;

            RefreshComPortList();

            // If it is still avalible, select the last com port used
            if (cmbPortName.Items.Contains(settings.PortName)) cmbPortName.Text = settings.PortName;
            else if (cmbPortName.Items.Count > 0) cmbPortName.SelectedIndex = cmbPortName.Items.Count - 1;
            else
            {
                MessageBox.Show(this, "There are no COM Ports detected on this computer.\nPlease install a COM Port and restart this app.", "No COM Ports Installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

       
        /// <summary> Save the user's settings. </summary>
        private void SaveSettings()
        {
            settings.BaudRate = int.Parse(cmbBaudRate.Text);
            settings.DataBits = int.Parse(cmbDataBits.Text);
            settings.DataMode = CurrentDataMode;
            settings.Parity = (Parity)Enum.Parse(typeof(Parity), cmbParity.Text);
            settings.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmbStopBits.Text);
            settings.PortName = cmbPortName.Text;

            settings.rdobtn_decimal = rdobtn_decimal.Checked;
            settings.rdobtn_deg_min = rdobtn_deg_min.Checked;


            settings.Save();
        }

        private void rbText_CheckedChanged(object sender, EventArgs e)
        { if (rbText.Checked) CurrentDataMode = DataMode.Text; }

        private void rbHex_CheckedChanged(object sender, EventArgs e)
        { if (rbHex.Checked) CurrentDataMode = DataMode.Hex; }


    }
}
