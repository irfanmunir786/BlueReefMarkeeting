using BlueReef.Common;
using BlueReef.Models;
using BlueReef.ViewModels;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueReef.Controllers
{
    public class UserloginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserLoginVM model)
        {
            UserHandler userHandler = new UserHandler();
            Registraion currentuser = userHandler.GetUsers(model.loginId, model.Password);
            if(currentuser!=null)
            {
                HttpContext.Session.Set<Registraion>(WebUtilities.CURRENT_USER, currentuser);
                
                if(currentuser.Id==WebUtilities.ADMIN_ROLE)
                {
                    return RedirectToAction("Index","Admin");
                }
                else if(currentuser.Id==WebUtilities.USER_ROLE)
                {
                    return RedirectToAction("Index", "home");
                }
                else
                {
                    return RedirectToAction("Login", "Userlogin");
                }
                
            }
            return View();
        }
    }
}
