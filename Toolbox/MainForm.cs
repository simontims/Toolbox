using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toolbox
{
    public partial class MainWindow : Form
    {

        int counter = 0;

        public MainWindow()
        {
            Program.LogToFile("Launch");
            InitializeComponent();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Program.LogToFile("Open email settings dialog");
            settingsForm settingsForm = new settingsForm();
            settingsForm.ShowDialog();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            timer1.Interval = Properties.Settings.Default.TimerSeconds*1000;
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                buttonStart.Text = "Start";
                labelStatusValue.Text = "Idle";
            }
            else
            {
                timer1.Enabled = true;
                buttonStart.Text = "Stop";
                labelStatusValue.Text = "Running";
            }
        }

        // Timer code tips: https://www.c-sharpcorner.com/article/timer-in-C-Sharp/
        private void Timer1_Tick(object sender, EventArgs e)
        {
            counter++;

            labelStatusValue.Text = counter.ToString();
        }
    }
}
