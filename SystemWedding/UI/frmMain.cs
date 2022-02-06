using Microsoft.Reporting.WinForms;
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

namespace SystemWedding.UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public string ProjectType;
        public string ProjectName;
        public bool update = false;
        DataTable data = new DataTable("tbProject");
        private void MenuNew_Click(object sender, EventArgs e)
        {
            frmNew frm = new frmNew();
            frm.ShowDialog();
        }
        [Obsolete]
        private void frmMain_Load(object sender, EventArgs e)
        {
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Text = "ស្វែងរកដោយលេខរៀងនឹងឈ្មោះនៅទីនេះ....";
            panel1.Visible = false;
            Enable(false);

            ClsLogin login = new ClsLogin();
            DataTable dt = new DataTable();
            if (login._ErrorCode == 0)
            {
                string query = "select * from tbLogin";
                login._ad = new System.Data.SqlClient.SqlDataAdapter(query, login._con);
                login._ad.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    if (row[1].ToString() != null || row[1].ToString() != "")
                    {
                        frmLogin frm = new frmLogin(this);
                        frm.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show(login._ErrorMsg);
            }
        }

        private void MenuNew_Click_1(object sender, EventArgs e)
        {
            frmNew frm = new frmNew();
            frm.ShowDialog();
        }

        private void MenuOpen_Click(object sender, EventArgs e)
        {
            frmOpen frm = new frmOpen(this);
            frm.ShowDialog();
        }

        private void MenuSetPassword_Click(object sender, EventArgs e)
        {
            frmSetPassword frm = new frmSetPassword();
            frm.ShowDialog();
        }

        private void MenuSetup_Click(object sender, EventArgs e)
        {
            frmSetup frm = new frmSetup();
            frm.ShowDialog();
        }
        public void Enable(Boolean t)
        {
            txtID.Enabled = t;
            cboName.Enabled = t;
            txtAddress.Enabled = t;
            numRiel.Enabled = t;
            numUSD.Enabled = t;
            txtOther.Enabled = t;
            txtSearch.Enabled = t;

            btnAdd.Enabled = t;
            btnReport.Enabled = t;
            btnSave.Enabled = t;
            btnUpdate.Enabled = t;

        }
        [Obsolete]
        public void LoadProject()
        {
            ClsLogin login = new ClsLogin();
            DataTable dt = new DataTable();
            List<ClsProjectDetail> ls = new List<ClsProjectDetail>();
            ClsProjectDetail obj;
            if (login._ErrorCode == 0)
            {
                int i = 1;
                string str = "select * from tbProject where projectType in('" + ProjectType + "')and projectcode in('" + ProjectName + "')";
                login._ad = new System.Data.SqlClient.SqlDataAdapter(str, login._con);
                login._ad.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    obj = new ClsProjectDetail();
                    obj.RowNo = i;
                    obj.DocEntry = Convert.ToInt32(row[0].ToString());
                    obj.IDNo = row[1].ToString();
                    obj.Name = row[2].ToString();
                    obj.Address = row[3].ToString();
                    obj.kh = Convert.ToDouble(row[4].ToString());
                    obj.usd = Convert.ToDouble(row[5].ToString());
                    obj.other = row[6].ToString();
                    i = i + 1;
                    ls.Add(obj);
                }
                dgvShow.DataSource = null;
                bsProjectDetail.DataSource = ls;
                dgvShow.DataSource = bsProjectDetail;
                dgvShow.ClearSelection();
                dgvShow.Enabled = true;
            }
            else
            {
                MessageBox.Show(login._ErrorMsg);
            }
        }
        public void Clear()
        {
            txtAddress.Text = "";
            txtID.Text = "";
            cboName.Text="";
            numRiel.Value = 0;
            numUSD.Value = 0;
            txtOther.Text = "";
            txtSearch.Text = "";
            Enable(false);
            btnAdd.Enabled = true;
            btnReport.Enabled = true;
            txtSearch.Enabled = true;
            update = false;
        }

        private void dgvShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                txtID.Text = dgvShow.Rows[index].Cells[1].Value.ToString();
                cboName.Text = dgvShow.Rows[index].Cells[2].Value.ToString();
                numRiel.Value = Convert.ToInt32(dgvShow.Rows[index].Cells[3].Value.ToString());
                numUSD.Value = Convert.ToInt32(dgvShow.Rows[index].Cells[4].Value.ToString());
                txtAddress.Text = dgvShow.Rows[index].Cells[5].Value.ToString();
                txtOther.Text = dgvShow.Rows[index].Cells[6].Value.ToString();

                Enable(false);
                btnUpdate.Enabled = true;
                btnSave.Enabled = false;
                btnAdd.Enabled = true;
                btnReport.Enabled = true;
                update = false;
            }
        }
        [Obsolete]
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Clear();
            Enable(true);
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            LoadDataCbo();
            txtID.Focus();
            dgvShow.ClearSelection();
            dgvShow.Enabled = true;
        }
        [Obsolete]
        public void LoadDataCbo() //ទាញទិន្នន័យបង្ហាញនៅលើcboធម្មតា តែបើយើងចង់មានvalue idបង្គប់ពីក្រោយយើងត្រូវប្រើbinary souce
        {
            //Clear();
            ClsLogin login = new ClsLogin();
            DataTable dt = new DataTable();
            if (login._ErrorCode == 0)
            {
                string str = "select * from tbSetup";
                login._ad = new System.Data.SqlClient.SqlDataAdapter(str, login._con);
                login._ad.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    cboName.Items.Add(row[1].ToString());
                }

            }
            else
            {
                MessageBox.Show(login._ErrorMsg);
            }
        }
        [Obsolete]
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text.Trim()))
            {
                MessageBox.Show("Please input IDNo...", "IDNo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (string.IsNullOrEmpty(cboName.Text.Trim()))
            {
                MessageBox.Show("Please input Name...", "Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (string.IsNullOrEmpty(txtAddress.Text.Trim()))
            {
                MessageBox.Show("Please input Address", "Address", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                ClsLogin login = new ClsLogin();
                if (login._ErrorCode == 0)
                {
                    if (update == false)
                    {
                        login._cmd = new System.Data.SqlClient.SqlCommand();
                        login._cmd.Connection = login._con;
                        login._cmd.CommandText = "insert into tbProject values(N'" + txtID.Text + "',N'" + cboName.Text + "',N'" + txtAddress.Text + "','" + numRiel.Value + "','" + numUSD.Value + "',N'" + txtOther.Text + "',N'" + ProjectType + "',N'" + ProjectName + "')";

                        if (login._cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Your record was saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadProject();
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Add Fail");
                        }
                    }
                    else
                    {
                        login._cmd = new System.Data.SqlClient.SqlCommand();
                        login._cmd.Connection = login._con;
                        login._cmd.CommandText = "update tbProject set IDNo=N'" + txtID.Text + "',Name=N'" + cboName.Text + "',Address=N'" + txtAddress.Text + "',KH='" + numRiel.Value + "',USD='" + numUSD.Value + "',Other=N'" + txtOther.Text + "' where DocEntry in('" + dgvShow.Rows[dgvShow.CurrentRow.Index].Cells[7].Value.ToString() + "')";

                        if (login._cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Your updated was saved", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadProject();
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Updated fail");
                        }
                    }
                }
                else
                {
                    MessageBox.Show(login._ErrorMsg);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update = true;
            dgvShow.Enabled = false;
            Enable(true);
            txtID.Enabled = false;
            txtSearch.Enabled = false;
            btnUpdate.Enabled = false;
            txtID.Focus();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DialogResult re;
            re = MessageBox.Show("Do you want to print report", "Report", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                DataTable data = new DataTable();
                data.Columns.Add("IDNo", typeof(string));
                data.Columns.Add("Name", typeof(string));
                data.Columns.Add("Address", typeof(string));
                data.Columns.Add("KH", typeof(string));
                data.Columns.Add("USD", typeof(string));
                data.Columns.Add("Other", typeof(string));

                foreach (DataGridViewRow r in dgvShow.Rows)
                {
                    data.Rows.Add(r.Cells[1].Value,
                                r.Cells[2].Value,
                                r.Cells[3].Value,
                                r.Cells[4].Value,
                                r.Cells[5].Value,
                                r.Cells[6].Value);
                }

                frmReport rep = new frmReport();
                rep.reportViewer.ProcessingMode = ProcessingMode.Local;
                LocalReport lr = rep.reportViewer.LocalReport;
                lr.DisplayName = "Report.rdlc";

                ReportDataSource rds = new ReportDataSource("DS", data);
                lr.DataSources.Clear();
                lr.DataSources.Add(rds);
                rep.Show();
                rep.reportViewer.Refresh();
            }
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
