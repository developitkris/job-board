using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JobBoard.Models;
using System;

namespace JobBoard.Controllers
{
    public class JobsController : Controller
    {
        [HttpGet("/jobs")]
        public ActionResult Index()
        {
            List<JobOpening> allJobs = JobOpening.GetAll();
            return View(allJobs);
        }

        [HttpGet("/jobs/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/jobs")]
        public ActionResult Create()
        {

          Contact newContact = new Contact (Request.Form["new-contactName"], Request.Form["new-contactEmail"], int.Parse(Request.Form["new-contactPhone"]));

          JobOpening newJobOpening = new JobOpening(Request.Form["new-title"], Request.Form["new-description"], newContact);
          newJobOpening.Save();

          // public JobOpening(string jobTitle, string jobDescription, newContact)

          List<JobOpening> allJobs = JobOpening.GetAll();
          return View("Index", allJobs);
        }

        [HttpPost("/jobs/delete")]
        public ActionResult DeleteAll()
        {
            JobOpening.ClearAll();
            return View();
        }
    }
}
