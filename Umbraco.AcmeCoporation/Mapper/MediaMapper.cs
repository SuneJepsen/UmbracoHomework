using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.AcmeCoporation.Domain;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace Umbraco.AcmeCoporation.Mapper
{
    public class MediaMapper
    {

        public MediaData GetMedia(IPublishedContent currentPage,
            UmbracoHelper helper, string propertyAlias)
        {

            var id = currentPage.GetPropertyValue<string>(propertyAlias);
            IPublishedContent media = helper.TypedMedia(currentPage.GetPropertyValue<string>(propertyAlias));
            MediaData mediaData = null;
            if (media != null)
            {
                mediaData = new MediaData()
                {
                    Url = media.Url(),
                    AltText = media.GetPropertyValue<string>("altText"),
                    Description = new HtmlString(currentPage.GetPropertyValue<string>("description"))
                };
            }
            else
            {
                mediaData = new MediaData();
            }

            return mediaData;

        }
    }
}