using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public String Index(String RollNumber)
        {
            return "suraj "  +RollNumber;
        }
        public String Index1()
        {
            return "suraj1";
        }
    }
}