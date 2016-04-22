namespace Toaster
{
    partial class Form1
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
            this.cmdShowToast = new System.Windows.Forms.Button();
            this.cmdHideToast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdShowToast
            // 
            this.cmdShowToast.Location = new System.Drawing.Point(58, 47);
            this.cmdShowToast.Name = "cmdShowToast";
            this.cmdShowToast.Size = new System.Drawing.Size(111, 23);
            this.cmdShowToast.TabIndex = 1;
            this.cmdShowToast.Text = "Show Me Toast";
            this.cmdShowToast.UseVisualStyleBackColor = true;
            this.cmdShowToast.Click += new System.EventHandler(this.cmdShowToast_Click);
            // 
            // cmdHideToast
            // 
            this.cmdHideToast.Enabled = false;
            this.cmdHideToast.Location = new System.Drawing.Point(58, 76);
            this.cmdHideToast.Name = "cmdHideToast";
            this.cmdHideToast.Size = new System.Drawing.Size(111, 23);
            this.cmdHideToast.TabIndex = 2;
            this.cmdHideToast.Text = "Hide Toast";
            this.cmdHideToast.UseVisualStyleBackColor = true;
            this.cmdHideToast.Click += new System.EventHandler(this.cmdHideToast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 117);
            this.Controls.Add(this.cmdHideToast);
            this.Controls.Add(this.cmdShowToast);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdShowToast;
        private System.Windows.Forms.Button cmdHideToast;
    }
}

