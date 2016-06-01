using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Identity.Controllers
{
    [Authorize]//Now All methods in controller require log in
    public class SecretController : Controller
    {
        // GET: Secret
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