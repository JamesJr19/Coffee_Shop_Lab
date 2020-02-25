using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coffee_Shop_Lab.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_Lab.Controllers
{
    public class UserController : Controller
    {
        public IActionResult UserForm()
        {
            return View(new RegisterUser());
        }

        
        public IActionResult Summary(RegisterUser user)
        {
            //if (ModelState.IsValid)
            //{
                return View();
            //}
            //else
            //{
            //    //the model object of type user did not match the requirements we made
            //    //in our User class
            //    return View("UserForm", User);
            //}
        }
    }
}