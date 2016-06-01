using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Identity.Controllers
{
    public class SecretController : Controller
    {
        // GET: Secret
        [Authorize]//Makes sure you have an Identity ie.(logged in)
        public ContentResult Index()
        {
            return Content("This is a secret");
        }

        public ContentResult Overt()
        {
            return Content("This is public");
        }
    }
}