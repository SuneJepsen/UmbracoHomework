using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.AcmeCoporation.Domain;
using Umbraco.AcmeCoporation.Mapper;
using Umbraco.AcmeCoporation.Models;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace Umbraco.AcmeCoporation.Controllers
{
    public class ProductsController : RenderMvcController
    {
        private MediaMapper mediaMapper;
        public ProductsController()
        {
            mediaMapper = new MediaMapper();
        }
        // GET: Products
        public ActionResult Index(RenderModel renderModel)
        {
            var productsModel = new ProductsModel(CurrentPage);
            var productContentList = CurrentPage.Children;
            var productList = new List<Product>();
   
            foreach (var content in productContentList)
            {
                productList.Add(Map(content, Umbraco));
            }
            productsModel.Products = productList;

            return View(productsModel);
        }

        public Product Map(IPublishedContent currentNode, UmbracoHelper helper)
        {
            return new Product()
            {
                Title = currentNode.GetPropertyValue<string>("title") ,
                Image = mediaMapper.GetMedia(currentNode, helper, "image"),
                SerialNumber = currentNode.GetPropertyValue<string>("productSerialNumber"),
            };
        }
    }
}