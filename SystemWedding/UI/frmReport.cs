using AngleSharp.Css.Dom;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemWedding.UI
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            reportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            this.reportViewer.RefreshReport();
        }
    }
}
