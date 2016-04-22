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
    public partial class Form1 : Form
    {
        Toast t = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdHideToast_Click(object sender, EventArgs e)
        {
            t.Hide();
            t.Dispose();
            cmdHideToast.Enabled = false;
        }

        private void cmdShowToast_Click(object sender, EventArgs e)
        {
            t = new Toast();
            t.Show();
            t.fadeIn();
            cmdHideToast.Enabled = true;
        }
    }
}
