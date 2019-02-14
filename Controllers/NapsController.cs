using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bit285_assignment2_login.Models;
using bit285_assignment2_login.ViewModels;

namespace bit285_assignment2_login.Controllers
{
    public class NapsController : Controller
    {
        //TODO: Inject the DbContext into the NapsController via constructor

        /* 
         * 1) Account Info 
        */
        public IActionResult AccountInfo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AccountInfo(User user)
        {
            //TODO: Add User information to the database

            return RedirectToAction("PasswordInfo", new { id = user.Id });
        }
        /* 
         * 2) Password Info 
        */
        [HttpGet]
        public IActionResult PasswordInfo(long id)
        {
            //TODO: Get the User information from the db based on given id

            //Create a new PasswordInfo object, include appropriate User info
            PasswordInfo passwordInfo = new PasswordInfo
            {

            };

            return View(passwordInfo);
        }
        [HttpPost]
        public IActionResult PasswordInfo(PasswordInfo info)
        {
            return RedirectToAction("SelectPassword", info);
        }
        /* 
         * 3) Select Password  
        */
        [HttpGet]
        public IActionResult SelectPassword(PasswordInfo info)
        {
            return View(info);
        }
        [HttpPost]
        public IActionResult SelectPassword(long id, PasswordInfo info)
        {
            //TODO: Get the User information from the db based on given id 
            User user;

            //TODO: Update the user's password from viewmodel info and update db


             return RedirectToAction("ConfirmAccount", user);
        }
        /* 
         * 4) Confirm Account 
        */
        [HttpGet]
        public IActionResult ConfirmAccount(User user)
        {
            return View(user);
        }

    }
}
