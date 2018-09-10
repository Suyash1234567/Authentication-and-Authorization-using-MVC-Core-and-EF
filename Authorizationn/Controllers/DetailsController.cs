using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Authorizationn.DAL;
using Authorizationn.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Authorizationn.Controllers
{
  
    public class DetailsController : Controller
    {
        private  DBOperations dbOperations = new DBOperations();

        public IActionResult Index()
        {
            return View();
        }

      

        [HttpPost]
        public IActionResult Index(UserModel login)
        {
            List<LoginTable> allUsers = dbOperations.GetAllStudents();
            LoginTable userInput = allUsers.Where(x => x.EmailId == login.EmailId && x.UserPassword == login.UserPassword).FirstOrDefault();
            if (userInput != null)
            {
                return RedirectToAction("Dashboard","Details",userInput);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Dashboard(LoginTable userInput)
        {
            if (userInput.EmailId != null)
            {
                return View(userInput);
            }
            return RedirectToAction("Index");
        }
    }
}