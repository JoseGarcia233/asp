﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Show_Presentation.Controllers
{
    public class PrincipalController : Controller
    {
        // GET: Principal
        public ActionResult Index()
        {
            return View();
        }
    }
}