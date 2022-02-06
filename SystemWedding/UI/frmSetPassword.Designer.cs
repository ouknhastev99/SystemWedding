
namespace SystemWedding.UI
{
    partial class frmSetPassword
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
            this.txtSetPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSetPassword
            // 
            this.txtSetPassword.Location = new System.Drawing.Point(12, 28);
            this.txtSetPassword.Name = "txtSetPassword";
            this.txtSetPassword.PasswordChar = '8';
            this.txtSetPassword.Size = new System.Drawing.Size(465, 41);
            this.txtSetPassword.TabIndex = 1;
            this.txtSetPassword.UseSystemPasswordChar = true;
            this.txtSetPassword.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtSetPassword_PreviewKeyDown);
            // 
            // frmSetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 97);
            this.Controls.Add(this.txtSetPassword);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSetPassword;
    }
}