using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fine_Arts.Models;

namespace Fine_Arts.Controllers
{
    public class ArtsController : Controller
    {
        //
        // GET: /Arts/
        public ActionResult Index()
        {
            List<Teacher> ls = new List<Teacher>();
            var t = new Teacher();
            t.Name = "Abc";
            t.Email = "abc@gmail.com";
            t.RemarksOnPainting = "Excellent";

            ls.Add(t);
            ls.Add(new Teacher() {Name = "xyz", Email = "xyz@gmail.com", RemarksOnPainting = "Good" });



            
            return View(ls);
        }
	}
}