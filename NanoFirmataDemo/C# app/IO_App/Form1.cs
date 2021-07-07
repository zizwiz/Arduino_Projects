using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LattePanda.Firmata;

namespace Test_Firmata
{
    public partial class Form1 : Form
    {

        Arduino arduino = new Arduino();
        bool AnalogueFlag = false;
        private ulong count = 0;

        //stepper motor bits
        int[] motorPins = { 9, 10, 11, 12 };
        int countA = 0;
        int countB = 0;
        int countC = 0;
        int countD = 0;
        int delayTime = 500;
        private int val1;
        private Thread StepperThread;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            SetSwitches();

            // Remove those not on Nano.
            lbl_D0.Visible = false; tswch_D0.Visible = false; lbl_state_D0.Visible = false; LED_D0.Visible = false; label24.Visible = false;
            lbl_D1.Visible = false; tswch_D1.Visible = false; lbl_state_D1.Visible = false; LED_D1.Visible = false; label23.Visible = false;

            groupBox1.Visible = false;


            /////////////////////////////////////////////////////////////////////////////////////////////
            ///                                   Digital Outputs Section 
            /// /////////////////////////////////////////////////////////////////////////////////////////

            arduino.pinMode(2, Arduino.OUTPUT); lbl_D2.Text = "O";
            arduino.pinMode(7, Arduino.OUTPUT); lbl_D7.Text = "O";


            /////////////////////////////////////////////////////////////////////////////////////////////
            ///                                   Digital PWM Section 
            /// /////////////////////////////////////////////////////////////////////////////////////////
            // PWM pins = D3, D5, D6, D9, D10, D13
            arduino.pinMode(3, Arduino.PWM); lbl_D3.Text = "P"; tswch_D3.Enabled = false;
            arduino.pinMode(6, Arduino.PWM); lbl_D6.Text = "P"; tswch_D6.Enabled = false;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            ///                               Digital Servo Motor Section
            /// ///////////////////////////////////////////////////////////////////////////////////////////

            arduino.pinMode(5, Arduino.SERVO); lbl_D5.Text = "P"; tswch_D5.Enabled = false;

            ///////////////////////////////////////////////////////////////////////////////////////////////
            ///                               Digital Stepper Motor Section
            /// ///////////////////////////////////////////////////////////////////////////////////////////
            // We just use plain digital signals high low etc

            arduino.pinMode(9, Arduino.OUTPUT); lbl_D9.Text = "S"; tswch_D9.Enabled = false;
            arduino.pinMode(10, Arduino.OUTPUT); lbl_D10.Text = "S"; tswch_D10.Enabled = false;
            arduino.pinMode(11, Arduino.OUTPUT); lbl_D11.Text = "S"; tswch_D11.Enabled = false;
            arduino.pinMode(12, Arduino.OUTPUT); lbl_D12.Text = "S"; tswch_D12.Enabled = false;

            /////////////////////////////////////////////////////////////////////////////////////////////
            ///                                   Digital Section Inpputs
            /// /////////////////////////////////////////////////////////////////////////////////////////
            // Set Digital Inputs
            arduino.pinMode(4, Arduino.INPUT); lbl_D4.Text = "I"; tswch_D4.Enabled = false;
            arduino.pinMode(8, Arduino.INPUT); lbl_D8.Text = "I"; tswch_D8.Enabled = false;
            arduino.pinMode(13, Arduino.INPUT); lbl_D13.Text = "I"; tswch_D13.Enabled = false;
           

            // Add event to listen for Digital input pins
            arduino.digitalPinUpdated += Arduino_digitalPinUpdated;


            ///////////////////////////////////////////////////////////////////////////////////////////////
            ///                               Analogue Input Section
            /// ///////////////////////////////////////////////////////////////////////////////////////////

            AnalogueFlag = true; //set to true so we keep reading analogue values in analogue event.
            // Set Analogue Outputs


            // Set Analogue Inputs
            arduino.pinMode(0, Arduino.INPUT);

            // Add event to listen for Analogue input pins
            arduino.analogPinUpdated += Arduino_analogPinUpdated;
            
            
            ///////////////////////////////////////////////////////////////////////////////////////
            ///                               Analogue I2C section
            /// ///////////////////////////////////////////////////////////////////////////////////
            /// I2C address of ADXL345 = 0x53
            ///
            ///
            arduino.wireBegin(200);
            arduino.wireRequest(0x53, 0x2D, new Int16[] { 8 }, Arduino.I2C_MODE_WRITE);//Write data{8} to I2C
            arduino.didI2CDataReveive += Arduino_didI2CDataReceive;//did I2C Data Reveive
            arduino.wireRequest(0x53, 0x32, new Int16[] { 6 }, Arduino.I2C_MODE_READ_CONTINUOUSLY);//Read data form I2C data

            //////////////////////////////////////////////////////////////////////////////////////
            ///                              Other Items Section
            /// ///////////////////////////////////////////////////////////////////////////////////

            // write app version  number to GUI
            lbl_version.Text = "v" + Assembly.GetExecutingAssembly().GetName().Version;

            lbl_pwm_slider.Text = trkbar_pwm.Value.ToString();
            trkbr_stepper.Value = 10;
            lbl_stepper_value.Text = trkbr_stepper.Value.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (StepperThread != null)
            {
                StepperThread.Abort();
            }

            AnalogueFlag = false;
            arduino.Close();
        }

        private void btn_close_Click(object sender, System.EventArgs e)
        {
            AnalogueFlag = false;
            Close();
        }

        private void rdo_high_CheckedChanged(object sender, System.EventArgs e)
        {/*
            if (rdo_high.Checked)
            {
                //  if (!tswch_D0.Checked) { tswch_D0.Checked = true; } else { tswch_D0.Checked = false; }
                //  if (!tswch_D1.Checked) { tswch_D1.Checked = true; } else { tswch_D1.Checked = false; }
                //  if (!tswch_D2.Checked) { tswch_D2.Checked = true; } else { tswch_D2.Checked = false; }
                //  if (!tswch_D3.Checked) { tswch_D3.Checked = true; } else { tswch_D3.Checked = false; }
                //  if (!tswch_D4.Checked) { tswch_D4.Checked = true; } else { tswch_D4.Checked = false; }
                //  if (!tswch_D5.Checked) { tswch_D5.Checked = true; } else { tswch_D5.Checked = false; }
                //  if (!tswch_D6.Checked) { tswch_D6.Checked = true; } else { tswch_D6.Checked = false; }
                if (!tswch_D7.Checked)
                {
                    tswch_D7.Checked = true;
                }
                else
                {
                    tswch_D7.Checked = false;
                }
                //  if (!tswch_D7.Checked) { tswch_D8.Checked = true; } else { tswch_D8.Checked = false; }
                //  if (!tswch_D8.Checked) { tswch_D9.Checked = true; } else { tswch_D9.Checked = false; }
                //  if (!tswch_D10.Checked) { tswch_D10.Checked = true; } else { tswch_D10.Checked = false; }
                //  if (!tswch_D11.Checked) { tswch_D11.Checked = true; } else { tswch_D11.Checked = false; }
                //  if (!tswch_D12.Checked) { tswch_D12.Checked = true; } else { tswch_D12.Checked = false; }
                //  if (!tswch_D13.Checked) { tswch_D13.Checked = true; } else { tswch_D13.Checked = false; }
            }
            else
            {
                //  if (!tswch_D0.Checked) { tswch_D0.Checked = false; } else { tswch_D0.Checked = true; }
                //  if (!tswch_D1.Checked) { tswch_D1.Checked = false; } else { tswch_D1.Checked = true; }
                //  if (!tswch_D2.Checked) { tswch_D2.Checked = false; } else { tswch_D2.Checked = true; }
                //  if (!tswch_D3.Checked) { tswch_D3.Checked = false; } else { tswch_D3.Checked = true; }
                //  if (!tswch_D4.Checked) { tswch_D4.Checked = false; } else { tswch_D4.Checked = true; }
                //  if (!tswch_D5.Checked) { tswch_D5.Checked = false; } else { tswch_D5.Checked = true; }
                //  if (!tswch_D6.Checked) { tswch_D6.Checked = false; } else { tswch_D6.Checked = true; }
                if (!tswch_D7.Checked)
                {
                    tswch_D7.Checked = false;
                }
                else
                {
                    tswch_D7.Checked = true;
                }
                //  if (!tswch_D7.Checked) { tswch_D8.Checked = false; } else { tswch_D8.Checked = true; }
                //  if (!tswch_D8.Checked) { tswch_D9.Checked = false; } else { tswch_D9.Checked = true; }
                //  if (!tswch_D10.Checked) { tswch_D10.Checked = false; } else { tswch_D10.Checked = true; }
                //  if (!tswch_D11.Checked) { tswch_D11.Checked = false; } else { tswch_D11.Checked = true; }
                //  if (!tswch_D12.Checked) { tswch_D12.Checked = false; } else { tswch_D12.Checked = true; }
                //  if (!tswch_D13.Checked) { tswch_D13.Checked = false; } else { tswch_D13.Checked = true; }
            }*/
        }



        //Event which is listening for input pins
        private void Arduino_digitalPinUpdated(byte pin, byte state)
        {
            Invoke(new Action(() =>
            {
                string ActivePin = pin.ToString();

                if (ActivePin == "13") //motor speed
                {
                    count++;
                    lbl_motor_speed.Text = (count / 32).ToString();
                }
                else
                {
                    if (state.ToString() == "0") //low
                    {
                        if (ActivePin == "8")
                        {
                            tswch_D8.Checked = false;
                        }
                        else if (ActivePin == "4")
                        {
                            tswch_D4.Checked = false;
                        }
                    }
                    else //high
                    {
                        if (ActivePin == "8")
                        {
                            tswch_D8.Checked = true;
                        }
                        else if (ActivePin == "4")
                        {
                            tswch_D4.Checked = true;
                        }
                    }
                }
                //lbl_pin.Text = pin.ToString();
                // lbl_state.Text = state.ToString();
                // lbl_read.Text = arduino.digitalRead(12).ToString();



            }));
        }

        //Event which is listening for Analogue input pins
        private void Arduino_analogPinUpdated(int pin, int value)
        {

            if ((pin == 0) && (AnalogueFlag))
            {
                Invoke(new Action(() =>
                {
                    lbl_read.Text = value.ToString();
                    aGauge1.Value = value;

                    arduino.analogWrite(3, (value / 4)); //div by 4 as input 0 to 1023 but output 0 to 255.
                    Thread.Sleep(4); //delay 4ms to let it settle.
                }));
            }
        }
        

        private void Arduino_didI2CDataReceive(byte address, byte register, byte[] data)
        {
            try
            {
                Invoke(new Action(() =>
                {
                    lbl_AcX.Text = (BitConverter.ToInt16(data, 0)).ToString();
                    lbl_AcY.Text = (BitConverter.ToInt16(data, 2)).ToString();
                    lbl_AcZ.Text = (BitConverter.ToInt16(data, 4)).ToString();

                }));
            }
            catch (Exception e)
            {
                //carry on 
            }

        }

        private void trkbar_pwm_Scroll(object sender, EventArgs e)
        {
            TrackBar bar = (TrackBar)(sender);
            arduino.analogWrite(6, bar.Value);
            lbl_pwm_slider.Text = bar.Value.ToString();
        }

        private void btn_set_servo_Click(object sender, EventArgs e)
        {
            int angle = Convert.ToInt32(Math.Round(numupdwn_degrees.Value, 0));
            arduino.servoWrite(5, angle);//tell the servo motor go to the position
        }

        private void btn_reset_motor_speed_Click(object sender, EventArgs e)
        {
            count = 0;
            lbl_motor_speed.Text = count.ToString();
        }

       
        private void btn_stepper_start_Click_1(object sender, EventArgs e)
        {
            StepperThread = new Thread(() =>
            {
                while (true)
                {
                    RunStepper();
                }

            });

            StepperThread.IsBackground = true;
            StepperThread.Start();
        }

        private void btn_stop_stepper_Click(object sender, EventArgs e)
        {
            StepperThread.Abort();
        }

        private void trkbr_stepper_Scroll(object sender, EventArgs e)
        {
            val1 = trkbr_stepper.Value;
            lbl_stepper_value.Text = val1.ToString();
        }



        private void RunStepper()
        {
           // lbl_stepper_pins.Invoke((MethodInvoker)(() => lbl_stepper_pins.Text = ""));
          //  lbl_stepper_signal.Invoke((MethodInvoker)(() => lbl_stepper_signal.Text = ""));

            while (true)
            {

                if (val1 > 540)
                {
                    delayTime = (2048 - ((1024 * val1) / 512)) + 1;
                    moveForward();
                }
                else if (val1 < 480)
                {
                    delayTime = ((1024 * val1) / 512) + 1;
                    moveBackward();
                }
                else
                {
                    delayTime = 1024;
                }

                lbl_stepper_delay.Invoke((MethodInvoker)(() => lbl_stepper_delay.Text = delayTime.ToString()));
            }
        }


        void moveForward()
        {
            byte valued;
            lbl_stepper_pins.Invoke((MethodInvoker)(() => lbl_stepper_pins.Text = ""));
            lbl_stepper_signal.Invoke((MethodInvoker)(() => lbl_stepper_signal.Text = ""));

            if ((countB == 0) || (countB == 1))
            {
                countB = 16;
            }

            countB >>= 1;

            for (countA = 3; countA >= 0; countA--)
            {
                valued = Convert.ToByte(0); //low
                if ((countB >> countA & 0x01) == 1) valued = Convert.ToByte(255); //high

                arduino.digitalWrite(motorPins[countA], valued);
                lbl_stepper_pins.Invoke((MethodInvoker)(() => lbl_stepper_pins.Text += motorPins[countA] + " : "));

                lbl_stepper_signal.Invoke((MethodInvoker)(() => lbl_stepper_signal.Text += valued + " : "));
            }

            Task.Delay(delayTime).Wait();
        }

        void moveBackward()
        {
            byte valuec;
            lbl_stepper_pins.Invoke((MethodInvoker)(() => lbl_stepper_pins.Text = ""));
            lbl_stepper_signal.Invoke((MethodInvoker)(() => lbl_stepper_signal.Text = ""));

            if ((countB == 0) || (countB == 1))
            {
                countB = 16;
            }

            countB >>= 1;

            for (countC = 3; countC >= 0; countC--)
            {
                valuec = Convert.ToByte(0); //low
                if ((countB >> countC & 0x01) == 1) valuec = Convert.ToByte(255); //high

                arduino.digitalWrite(motorPins[3 - countC], valuec);

                lbl_stepper_pins.Invoke((MethodInvoker)(() => lbl_stepper_pins.Text += motorPins[3 - countC] + " : "));
                lbl_stepper_signal.Invoke((MethodInvoker)(() => lbl_stepper_signal.Text += valuec + " : "));
            }

            Task.Delay(delayTime).Wait();
        }
    }
}
