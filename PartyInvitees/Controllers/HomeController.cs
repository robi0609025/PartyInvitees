using PartyInvitees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvitees.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greetings = hour < 12 ? "Good Morning" : "Good Afternoon";

            return View();
        }

        [HttpGet]
        public ActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RsvpForm( GuestResponse guestResponse )
        {
            if (ModelState.IsValid)
            {
                //TODO: Email response to the party organiser
                return View("Thanks", guestResponse);
            }
            else   
            {
                //There is a validation error
                return View();
            }

            //return View("Thanks", guestResponse);
        }
    }
}