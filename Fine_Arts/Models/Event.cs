using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fine_Arts.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string Events { get; set; }
        public Student[] Students { get; set; }
        public Painting Paintings { get; set; }
        public Remark[] RemarksOnPaintings { get; set; }
    }
}