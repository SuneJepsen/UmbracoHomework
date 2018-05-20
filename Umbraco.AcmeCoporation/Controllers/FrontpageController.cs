using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.AcmeCoporation.Models;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace Umbraco.AcmeCoporation.Controllers
{
    public class FrontpageController : RenderMvcController
    {
        public ActionResult Frontpage(RenderModel renderModel)
        {
            var frontpageModel = new FrontpageModel(CurrentPage);
            return View(frontpageModel);
        }
    }
}