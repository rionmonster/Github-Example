﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Github_Example.Controllers
{
    public class ExampleController : Controller
    {
        //
        // GET: /Example/

        public ActionResult Index()
        {
            
            return View();
        }

        //Additional Comment
        public ActionResult NewAction()
        {
            //Added a Comment
            return View();
        }

    }
}
