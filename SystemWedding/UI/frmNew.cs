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
    public partial class frmNew : Form
    {
        public frmNew()
        {
            InitializeComponent();
        }

        private void frmNew_Load(object sender, EventArgs e)
        {
            List<ClsProjectType> lsP = new List<ClsProjectType>();
            ClsProjectType obj;

            obj = new ClsProjectType();
            obj.code = "001";
            obj.name = "អាពាហ៍ពិពាហ៍";
            lsP.Add(obj);

            obj = new ClsProjectType();
            obj.code = "002";
            obj.name = "ឡើងគេហដ្ឋាន";
            lsP.Add(obj);

            obj = new ClsProjectType();
            obj.code = "003";
            obj.name = "ខួបកំណើត";
            lsP.Add(obj);

            bsProjectType.DataSource = lsP;
        }
        [Obsolete]
        private void btnAddnew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Please input project name");
            }
            else
            {
                ClsLogin login = new ClsLogin();
                if (login._ErrorCode == 0)
                {
                    login._cmd = new System.Data.SqlClient.SqlCommand();
                    login._cmd.Connection = login._con;
                    login._cmd.CommandText = "insert into tbNewProject values(N'" + cboType.SelectedValue + "',N'" + txtName.Text + "')";

                    if (login._cmd.ExecuteNonQuery() == 1)
                    {
                        this.Hide();
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
    }
}
