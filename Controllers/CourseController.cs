using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseRegisterApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseRegisterApp.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult ListOfApplications()
        {
            var model = Repository.Applications;
            return View(model);
        }

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm] Candidate candidate)
        {
            if(Repository.Applications.Any(c => c.Email.Equals(candidate.Email)))
            {
                ModelState.AddModelError("", "Mail already exist.");
            }

            if(ModelState.IsValid)
            {
                 Repository.Add(candidate);
                return View("Feedback", candidate);
            }
           return View();
        }
    }
}