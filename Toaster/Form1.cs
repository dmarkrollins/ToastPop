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

            Rectangle Bounds = new Rectangle(0, 0, t.Width, t.Height);
            int CornerRadius = 20;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(Bounds.X, Bounds.Y, CornerRadius, CornerRadius, 180, 90);
            path.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y, CornerRadius, CornerRadius, 270, 90);
            path.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
            path.AddArc(Bounds.X, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
            path.CloseAllFigures();

            t.Region = new Region(path);

            t.Show();
            t.fadeIn();
            cmdHideToast.Enabled = true;
        }
    }
}
