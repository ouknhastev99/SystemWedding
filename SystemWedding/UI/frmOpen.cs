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
    public partial class frmOpen : Form
    {
        public frmOpen()
        {
            InitializeComponent();
        }
        public frmOpen(frmMain fr)
        {
            InitializeComponent();
            frm = fr;
        }
        frmMain frm = new frmMain();
        [Obsolete]
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (cboName.Text != "")
            {
                frm.ProjectType = cboType.SelectedValue.ToString();
                frm.ProjectName = cboName.SelectedValue.ToString();

                frm.btnAdd.Enabled = true;
                frm.txtSearch.Enabled = true;
                frm.btnReport.Enabled = true;
                frm.LoadProject();
                this.Hide();
            }
        }
        [Obsolete]
        private void frmOpen_Load(object sender, EventArgs e)
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
            LoadData();
        }
        [Obsolete]
        public void LoadData()
        {
            ClsLogin login = new ClsLogin();
            DataTable dt = new DataTable();
            ClsProject p;
            List<ClsProject> Ps = new List<ClsProject>();
            if (login._ErrorCode == 0)
            {
                string str = "select * from tbNewProject where ProjectType in(N'" + cboType.SelectedValue + "')";
                login._ad = new System.Data.SqlClient.SqlDataAdapter(str, login._con);
                login._ad.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    p = new ClsProject();
                    p.DocEntry = Convert.ToInt32(row[0].ToString());
                    p.Type = row[1].ToString();
                    p.Name = row[2].ToString();

                    Ps.Add(p);
                }
                bsProject.Clear();
                bsProject.DataSource = Ps;
            }
            else
            {
                MessageBox.Show(login._ErrorMsg);
            }
        }
        [Obsolete]
        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
