﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewWaghralkar.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult DashboardIndex()
        {
            return View();
        }
    }
}