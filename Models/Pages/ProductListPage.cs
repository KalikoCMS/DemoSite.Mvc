namespace DemoSite.Models.Pages {
    using System;
    using System.Collections.Generic;
    using System.Web;
    using Business.FakeStore;
    using KalikoCMS;
    using KalikoCMS.Attributes;
    using KalikoCMS.ContentProvider;
    using KalikoCMS.Core;
    using KalikoCMS.Mvc;
    using KalikoCMS.PropertyType;
    using Lucene.Net.Search;

    /// <summary>
    /// This is our product list. Since we want to present products from our already existing
    /// product database without also storing them in the CMS we us the page extender functionality.
    /// This is done by implementing IPageExtender and will allow us to handle all calls that are 
    /// "below" our page, like "/products/my-product/" if "products" is our page. 
    /// </summary>
    [PageType("ProductList", "Product list page", PreviewImage = "/Assets/Images/productlist.png")]
    public class ProductListPage : CmsPage, IPageExtender {
        [Property("Headline")]
        public virtual StringProperty Headline { get; set; }

        [Property("Main body")]
        public virtual HtmlProperty MainBody { get; set; }

        /// <summary>
        /// This function is required for implementing the IPageExtender interface and will 
        /// be called in order to verify that the requested Url is a part of the extended 
        /// page or not.
        /// </summary>
        /// <param name="pageId">The id of the page being extended</param>
        /// <param name="remainingSegments">The remaining Url segments from the page and on</param>
        /// <returns></returns>
        public bool HandleRequest(Guid pageId, string[] remainingSegments) {
            // We only handle one level of additional paths in this extender
            if (remainingSegments.Length != 1) {
                return false;
            }

            // Check if this was a called for a valid product in our product database
            if (FakeProductDatabase.IsValidProduct(remainingSegments[0])) {
                // It was, so lets execute ProductPage.aspx. By attaching the pageId 
                // as id in the querystring and letting ProductPage inherit from 
                // PageTemplate we can access all properties from the "mother page".
                // TODO: Uppdatera beskrivning
                var page = PageFactory.GetPage(pageId);
                var additionalRouteData = new Dictionary<string, object> {{"productId", remainingSegments[0]}};

                RouteUtils.RedirectToController(page, "product", additionalRouteData);
                
                return true;
            }

            // Tell the request handler that the requested Url is unknown
            return false;
        }
    }
}