using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fine_Arts.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }
        public Painting Painting { get; set; }
        public Event[] Events { get; set; }
        public Remark[] RemarksOnPainting { get; set; }
    }
}