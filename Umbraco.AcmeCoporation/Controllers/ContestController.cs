using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace Umbraco.AcmeCoporation.Controllers
{
    public class ContestController : RenderMvcController
    {
        // GET: Products
        public ActionResult Index(RenderModel renderModel)
        {
            return View();
        }
    }
}