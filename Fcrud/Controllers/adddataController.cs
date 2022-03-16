using Fcrud.DB_Folder;
using Fcrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fcrud.Controllers
{
    public class adddataController : Controller
    {
        private object hobj;

        [HttpGet]
        public ActionResult adddata()
        {
            return View();
        }
        [HttpPost]
        public ActionResult adddata(StuModel hobj)
        {
            stuInfoEntities sobj = new stuInfoEntities();

            tb_stu1 tobj = new tb_stu1();

            tobj.id = hobj.Id;
            tobj.name = hobj.name;
            tobj.age = hobj.age;
            tobj.email = hobj.email;
            tobj.company = hobj.company;
            sobj.tb_stu1.Add(tobj);
            sobj.SaveChanges();


            return View();
        }
    }
}