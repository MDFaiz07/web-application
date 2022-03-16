using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Fcrud.Models
{
    public class StuModel
    {
        public int Id { get; set; }
       
        public string  name { get; set; }
      
        public int age { get; set; }
        public string company { get; set; }
        public  string email { get; set; }
    }
}