using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.AcmeCoporation.Domain;
using Umbraco.Core.Models;
using Umbraco.Web.Models;

namespace Umbraco.AcmeCoporation.Models
{
    public class ProductsModel : RenderModel
    {
        public ProductsModel(IPublishedContent currentPage) : base(currentPage)
        {

        }

        public List<Product> Products { get; set; }
    }
}