using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Umbraco.AcmeCoporation.Domain
{
    public class MediaData
    {
        public string Url { get; set; }
        public string AltText { get; set; }
        public HtmlString Description { get; set; }
    }
}