using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Agency.Dal;
using Travel_Agency.Models;
using Travel_Agency.ViewModel;

namespace Travel_Agency.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View("LoginPage");
        }
        public ActionResult LoginPage()
        {
            UserViewModel uvm = new UserViewModel();
            User objUser = new User();
            UserDal dal = new UserDal();
            List<User> objUsers = dal.Users.ToList();

            if (Request.Form.Count > 0)
            {
                objUser.userName = Request.Form["User.userName"].ToString();
                objUser.Password = Request.Form["User.Password"].ToString();

                foreach (User x in objUsers)//to make sure the username is valid
                {
                    if (x.userName == objUser.userName && x.Password == objUser.Password)
                    {
                        uvm.user = x;//add the current user to the CVM user
                        Session["currUserName"] = x.userName;
                        Session["currPassword"] = x.Password;
                        //HomeViewModel hvm = new HomeViewModel();
                        return View();
                    }
                }
                uvm.user = new User();
                ViewBag.UserORPassError = "User Name Or Password InCorrect! Please Try Again...";
                return View("LoginPage", uvm);//userName Or Pass not found
            }
            return View("LoginPage");
        }
    }
}