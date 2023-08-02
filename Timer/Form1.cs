using System.Timers;
using System.Windows.Forms;

namespace MyTimer
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer timer = new System.Timers.Timer();

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Elapsed += new ElapsedEventHandler(timer_Tick);
            timer.Enabled = true;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (labelShowTime.InvokeRequired)
            {
                labelShowTime.Invoke(new MethodInvoker(delegate
                {
                    labelShowTime.Text = DateTime.Now.ToString("HH:mm:ss");
                }
                ));
            }
            else
            {
                labelShowTime.Text = DateTime.Now.ToString("HH:mm:ss");
            }
        }
        private void buttonSetAnAllarm_Click(object sender, EventArgs e)
        {
            DateTime alarmTime;
            if (DateTime.TryParse(maskedTextBox1.Text, out alarmTime))
            {
                timer.Elapsed += new ElapsedEventHandler(delegate (object sender3, ElapsedEventArgs e3)
                {
                    if (DateTime.Now >= alarmTime)
                    {
                        System.Media.SystemSounds.Hand.Play();
                    }
                });
                timer.Enabled = true;
            }
            else
            {
                MessageBox.Show("Невірний формат часу");
            }
        }

        private void buttonStopAllarm_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}