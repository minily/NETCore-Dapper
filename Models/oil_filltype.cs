using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperDemo.Models
{
    public class oil_filltype
    {
        public int id { get; set; }
        public string filltypeName { get; set; }
        public string traintypeID { get; set; }
        public string oilTypeID { get; set; }
        public string fillTypeCode { get; set; }
        public bool isRation { get; set; }
        public string reportPath { get; set; }
        public string guid { get; set; }
    }
}
