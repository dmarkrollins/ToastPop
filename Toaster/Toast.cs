using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toaster
{
    public partial class Toast : Form
    {
        public Toast()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Toast_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Width - Width - 20;
            int y = Screen.PrimaryScreen.WorkingArea.Height - Height - 20;
            SetDesktopLocation(x, y);
        }

        public void fadeIn()
        {
            int duration = 1000;//in milliseconds
            int steps = 50;
            Timer timer = new Timer();
            timer.Interval = duration / steps;

            int currentStep = 0;
            timer.Tick += (arg1, arg2) =>
            {
                Opacity = ((double)currentStep) / steps;
                currentStep++;

                if (currentStep >= steps)
                {
                    timer.Stop();
                    timer.Dispose();
                }
            };

            timer.Start();
        }
    }
}
