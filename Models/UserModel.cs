using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Test1.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    //public Gender gender { get; set; }


    }
    public enum Gender
    {
        Male,
        Female
    }
}
