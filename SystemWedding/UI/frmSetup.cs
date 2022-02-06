using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemWedding.Models;
using SystemWedding.Models.Master;

namespace SystemWedding.UI
{
    public partial class frmSetup : Form
    {
        public frmSetup()
        {
            InitializeComponent();
        }
        [Obsolete]
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Please input name");
            }
            else
            {
                ClsLogin login = new ClsLogin();
                if (login._ErrorCode == 0)
                {
                    string str = "insert into tbSetup values(N'" + txtName.Text + "')";
                    login._cmd = new System.Data.SqlClient.SqlCommand();
                    login._cmd.Connection = login._con;
                    login._cmd.CommandText = str;
                    if (login._cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Your record was saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Add Fail");
                    }
                }
                else
                {
                    MessageBox.Show(login._ErrorMsg);
                }
            }
        }
        [Obsolete]
        private void frmSetup_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        [Obsolete]
        public void LoadData()
        {
            ClsLogin login = new ClsLogin();
            DataTable dt = new DataTable();
            ClsSetup clsSetup;
            List<ClsSetup> clsSetups = new List<ClsSetup>();
            if (login._ErrorCode == 0)
            {
                string str = "select * from tbSetup";
                login._ad = new System.Data.SqlClient.SqlDataAdapter(str, login._con);
                login._ad.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    clsSetup = new ClsSetup();
                    clsSetup.DocEntry = Convert.ToInt32(row[0].ToString());
                    clsSetup.Name = row[1].ToString();

                    clsSetups.Add(clsSetup);
                }
                dgvSetup.DataSource = null;
                bsSetup.DataSource = clsSetups;
                dgvSetup.DataSource = bsSetup;
            }
            else
            {
                MessageBox.Show(login._ErrorMsg);
            }
        }
    }
}
