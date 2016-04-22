namespace Toaster
{
    partial class Toast
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmdKnow = new System.Windows.Forms.Button();
            this.cmdNotKnown = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cmdKnow
            // 
            this.cmdKnow.Location = new System.Drawing.Point(12, 99);
            this.cmdKnow.Name = "cmdKnow";
            this.cmdKnow.Size = new System.Drawing.Size(177, 23);
            this.cmdKnow.TabIndex = 0;
            this.cmdKnow.Text = "I got this...";
            this.cmdKnow.UseVisualStyleBackColor = true;
            // 
            // cmdNotKnown
            // 
            this.cmdNotKnown.Location = new System.Drawing.Point(12, 128);
            this.cmdNotKnown.Name = "cmdNotKnown";
            this.cmdNotKnown.Size = new System.Drawing.Size(177, 23);
            this.cmdNotKnown.TabIndex = 1;
            this.cmdNotKnown.Text = "No Freakin\' Clue";
            this.cmdNotKnown.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "I know somebody!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(177, 81);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Do you know where to find the claim version calendar?";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Toast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 194);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdNotKnown);
            this.Controls.Add(this.cmdKnow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Toast";
            this.Opacity = 0D;
            this.Text = "Toast";
            this.Load += new System.EventHandler(this.Toast_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdKnow;
        private System.Windows.Forms.Button cmdNotKnown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
    }
}