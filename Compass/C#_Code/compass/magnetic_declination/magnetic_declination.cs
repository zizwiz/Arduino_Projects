using System;

namespace Compass
{
    public partial class Form1
    {

        private void rdobtn_deg_min_CheckedChanged(object sender, EventArgs e)
        {
            SetMagneticDeclination();
        }

        private void SetMagneticDeclination()
        {
            if (rdobtn_deg_min.Checked)
            {
                txtbx_degrees.Enabled = true;
                txtbx_minutes.Enabled = true;

                txtbx_decimal.Enabled = false;
            }
            else
            {
                txtbx_degrees.Enabled = false;
                txtbx_minutes.Enabled = false;

                txtbx_decimal.Enabled = true;
            }


        }


        private void btn_set_in_compass_Click(object sender, EventArgs e)
        {

            //prepare data for Arduino

            if (rdobtn_deg_min.Checked)
            {
                txtbx_decimal.Text = Math.Round((decimal.Parse(txtbx_degrees.Text) + (decimal.Parse(txtbx_minutes.Text) / 60)),2).ToString();
            }
            

            //send data

            
        }




    }
}
