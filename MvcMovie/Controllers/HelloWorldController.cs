﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public String Index()
        {
            return "This is my default action...";
        }
        //
        //Get: /HelloWorld/Welcome/

        public string Welcome()
        {
            return "This is Welcome action method...";
        }

    }
}
