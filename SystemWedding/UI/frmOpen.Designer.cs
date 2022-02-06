
namespace SystemWedding.UI
{
    partial class frmOpen
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
            this.cboName = new System.Windows.Forms.ComboBox();
            this.bsProject = new System.Windows.Forms.BindingSource(this.components);
            this.btnOpen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.bsProjectType = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjectType)).BeginInit();
            this.SuspendLayout();
            // 
            // cboName
            // 
            this.cboName.DataSource = this.bsProject;
            this.cboName.DisplayMember = "Name";
            this.cboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(121, 78);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(350, 41);
            this.cboName.TabIndex = 15;
            this.cboName.ValueMember = "DocEntry";
            // 
            // bsProject
            // 
            this.bsProject.DataSource = typeof(SystemWedding.Models.Master.ClsProject);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.White;
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.Location = new System.Drawing.Point(370, 125);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(101, 43);
            this.btnOpen.TabIndex = 14;
            this.btnOpen.Text = "បើក";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 34);
            this.label2.TabIndex = 13;
            this.label2.Text = "ឈ្មោះ";
            // 
            // cboType
            // 
            this.cboType.DataSource = this.bsProjectType;
            this.cboType.DisplayMember = "name";
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(121, 25);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(350, 41);
            this.cboType.TabIndex = 12;
            this.cboType.ValueMember = "code";
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // bsProjectType
            // 
            this.bsProjectType.DataSource = typeof(SystemWedding.Models.Master.ClsProjectType);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "ប្រភេទ";
            // 
            // frmOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 193);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOpen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOpen";
            this.Load += new System.EventHandler(this.frmOpen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjectType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsProject;
        private System.Windows.Forms.BindingSource bsProjectType;
    }
}