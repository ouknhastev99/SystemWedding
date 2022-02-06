
namespace SystemWedding.UI
{
    partial class frmNew
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
            this.btnAddnew = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bsProjectType = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsProjectType)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddnew
            // 
            this.btnAddnew.BackColor = System.Drawing.Color.White;
            this.btnAddnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddnew.Location = new System.Drawing.Point(349, 123);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(101, 43);
            this.btnAddnew.TabIndex = 9;
            this.btnAddnew.Text = "បង្កើតថ្មី";
            this.btnAddnew.UseVisualStyleBackColor = false;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(350, 41);
            this.txtName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "ឈ្មោះ";
            // 
            // cboType
            // 
            this.cboType.DataSource = this.bsProjectType;
            this.cboType.DisplayMember = "name";
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(100, 23);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(350, 41);
            this.cboType.TabIndex = 6;
            this.cboType.ValueMember = "code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "ប្រភេទ";
            // 
            // bsProjectType
            // 
            this.bsProjectType.DataSource = typeof(SystemWedding.Models.Master.ClsProjectType);
            // 
            // frmNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 188);
            this.Controls.Add(this.btnAddnew);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNew";
            this.Load += new System.EventHandler(this.frmNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsProjectType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsProjectType;
    }
}