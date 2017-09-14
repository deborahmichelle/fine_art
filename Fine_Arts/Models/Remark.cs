using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fine_Arts.Models
{
    public class Remark
    {
        public int ID { get; set; }
        public string rmks { get; set; }
        public Teacher[] RemarksOnPaintings { get; set; }
    }
}