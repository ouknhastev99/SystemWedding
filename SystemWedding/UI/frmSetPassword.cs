using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemWedding.Models;

namespace SystemWedding.UI
{
    public partial class frmSetPassword : Form
    {
        public frmSetPassword()
        {
            InitializeComponent();
        }
        [Obsolete]
        private void txtSetPassword_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = new DataTable();
                ClsLogin login = new ClsLogin();
                if (string.IsNullOrEmpty(txtSetPassword.Text.Trim()))
                {
                    MessageBox.Show("Please input new password", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    string query = "update tbLogin set Password=('" + txtSetPassword.Text + "')where DocEntry=1";
                    login._ad = new SqlDataAdapter(query, login._con);
                    login._ad.Fill(dt);
                    MessageBox.Show("Your new Password was Changed", "Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSetPassword.Text = null;
                    txtSetPassword.Focus();
                }
            }
        }
    }
}
