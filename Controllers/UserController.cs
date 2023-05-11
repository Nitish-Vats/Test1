using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.Models;

namespace Test1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            
            List<UserModel> users1=UserList();
            return View(users1);
        
        }
        [HttpPost]
        public ActionResult Index(string gender, string searching)
         {
            List<UserModel> users = UserList();
            List<UserModel> user1 = new List<UserModel>();
      if (searching == null)
      {
        foreach (var item in users)
        {
          UserModel u = new UserModel();
          u.ID = item.ID;
          u.Name = item.Name;
          u.Age = item.Age;
          if (item.Gender == gender)
          {
            u.Gender = item.Gender;
          }
          else
          {
            continue;
          }

          user1.Add(u);
        }
      }
      if(gender==null)
      {
        foreach (var item in users)
        {
          UserModel u = new UserModel();
          u.ID = item.ID;
          if (item.Name.ToLower().Contains(searching.ToLower()) || searching == null)
          {
            u.Name = item.Name;
          }
          else
          {
            continue;
          }

          u.Age = item.Age;
          u.Gender = item.Gender;
          user1.Add(u);
        }
      }
        return View(user1);
          // return PartialView("~/Partal/UserList.cshtml");


        }
    public List<UserModel> UserList()
    {
      List<UserModel> users = new List<UserModel>();
      UserModel user = new UserModel();
      user.ID = 1;
      user.Name = "Johny";
      user.Age = 26;
      user.Gender = "Male";
      users.Add(user);
      user = new UserModel();
      user.ID = 2;
      user.Name = "Agnes";
      user.Age = 29;
      user.Gender = "Female";
      users.Add(user);
      user = new UserModel();
      user.ID = 3;
      user.Name = "Sachiver";
      user.Age = 23;
      user.Gender = "Female";
      users.Add(user);
      user = new UserModel();
      user.ID = 4;
      user.Name = "Mathew";
      user.Age = 31;
      user.Gender = "Male";
      users.Add(user);
      user = new UserModel();
      user.ID = 5;
      user.Name = "Angel";
      user.Age = 27;
      user.Gender = "Male";
      users.Add(user);
      return (users);
    }

       





    }
}
