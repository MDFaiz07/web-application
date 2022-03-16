using Fcrud.DB_Folder;
using Fcrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fcrud.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            stuInfoEntities obj = new stuInfoEntities();
            List<StuModel> hobj = new List<StuModel>();
            


            var res = obj.tb_stu1.ToList();
            foreach (var item in res)
            {
                hobj.Add(new StuModel
                {
                    Id = item.id,
                    name = item.name,
                    age = (int)item.age,
                    company = item.company,
                    email = item.email
                }
            );
            }


           
            return View(hobj);

        }
       
        public ActionResult About()
        {
           

            return View();
        }
        
       

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}