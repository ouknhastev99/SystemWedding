using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemWedding.Models
{
    class ClsProjectDetail
    {
        public int DocEntry { get; set; }
        public int RowNo { get; set; }
        public string IDNo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double kh { get; set; }
        public double usd { get; set; }
        public string other { get; set; }
        public string ProjectType { get; set; }
        public string ProjectCode { get; set; }
    }
}
