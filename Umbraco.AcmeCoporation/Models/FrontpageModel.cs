using Umbraco.Core.Models;
using Umbraco.Web.Models;

namespace Umbraco.AcmeCoporation.Models
{
    public class FrontpageModel : RenderModel
    {
        public FrontpageModel(IPublishedContent currentPage) : base(currentPage)
        {
            
        }
    }
}