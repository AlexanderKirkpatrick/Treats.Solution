using Treats.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System;

using Microsoft.AspNetCore.Mvc;

namespace Treats.Controllers
{
    public class HomeController : Controller
    {
    
      private readonly TreatsContext _db;

      public HomeController(TreatsContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

        public ActionResult Details()
      {
        ViewBag.Treats = _db.Treats.ToList();
        ViewBag.Flavors = _db.Flavors.ToList();
        return View();
      }             

      
    }
}