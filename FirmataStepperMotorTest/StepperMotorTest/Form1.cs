using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LattePanda.Firmata;

namespace StepperMotorTest
{
    public partial class Form1 : Form
    {
        Arduino arduino = new Arduino();
        int[] motorPins = { 4, 5, 6, 7 };
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

        private void Form1_Load(object sender, EventArgs e)
        {
            arduino.pinMode(4, Arduino.OUTPUT); 
            arduino.pinMode(5, Arduino.OUTPUT); 
            arduino.pinMode(6, Arduino.OUTPUT); 
            arduino.pinMode(7, Arduino.OUTPUT);

            trkbr_stepper.Value = 10;
            lbl_stepper_value.Text = "10";
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (StepperThread != null)
            {
                StepperThread.Abort();
            }

            arduino.Close();
        }

        private void trkbr_stepper_Scroll(object sender, EventArgs e)
        {
            val1 = trkbr_stepper.Value;
            lbl_stepper_value.Text = val1.ToString();
        }

        private void btn_stop_stepper_Click(object sender, EventArgs e)
        {
            StepperThread.Abort();
        }

        private void btn_stepper_start_Click(object sender, EventArgs e)
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

        private void RunStepper()
        {
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
