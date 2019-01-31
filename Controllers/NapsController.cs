using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bit285_assignment2_login.Models;


namespace bit285_assignment2_login.Controllers
{
    public class NapsController : Controller
    {

        /* 
         * 1) Account Info 
        */
        public IActionResult AccountInfo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AccountInfo(User account)
        {
            return RedirectToAction("PasswordInfo", "Naps", account);
        }
        /* 
         * 2) Password Info 
        */
        [HttpGet]
        public IActionResult PasswordInfo(User account)
        {
             return View(account);
        }
        [HttpPost]
        public IActionResult PasswordInfo(User account, string dummy)
        {

            return RedirectToAction("SelectPassword", "Naps", account);
        }
        /* 
         * 3) Select Password  
        */
        [HttpGet]
        public IActionResult SelectPassword(User account)
        {
            return View(account);
        }
        [HttpPost]
        public IActionResult SelectPassword(User account, string dummy)
        {
            return RedirectToAction("ConfirmAccount", "Naps", account);
        }
        /* 
         * 4) Confirm Account 
        */
        [HttpGet]
        public IActionResult ConfirmAccount(User account)
        {
            return View(account);
        }
        [HttpPost]
        public IActionResult ConfirmAccount()
        {
            return RedirectToAction("Login");
        }
        /* 
         * 5) Login 
        */
        public IActionResult Login()
        {
            return View();
        }
    }
}
