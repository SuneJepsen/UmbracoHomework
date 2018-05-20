using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web.Models;

namespace Umbraco.AcmeCoporation.Models
{
    public class ContestModel : RenderModel
    {
        public ContestModel(IPublishedContent currentPage) : base(currentPage)
        {

        }
    }
}