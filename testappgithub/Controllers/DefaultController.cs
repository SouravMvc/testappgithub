﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testappgithub.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
         public ActionResult Index1()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}
