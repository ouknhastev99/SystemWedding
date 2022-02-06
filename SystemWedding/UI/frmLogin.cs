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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public frmLogin(frmMain fr)
        {
            frm = fr;
            InitializeComponent();
        }
        frmMain frm = new frmMain();
        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        [Obsolete]
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int found = 0;
                DataTable dt = new DataTable();
                ClsLogin login = new ClsLogin();
                if (login._ErrorCode == 0)
                {
                    string query = "select * from tbLogin where Password in(N'" + txtPassword.Text + "')";
                    login._ad = new SqlDataAdapter(query, login._con);
                    login._ad.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        this.Hide();
                        found = 1;
                        frm.panel1.Visible = true;
                    }
                    if (found == 0)
                    {
                        MessageBox.Show("Password Incorrect!", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPassword.Text = "";
                    }
                }
            }
        }
    }
}
