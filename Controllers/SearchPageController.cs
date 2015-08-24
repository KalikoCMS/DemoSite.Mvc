namespace DemoSite.Controllers {
    using System;
    using System.Web.Mvc;
    using Business.ViewModelBuilders;
    using KalikoCMS.Mvc.Framework;
    using Models.Pages;

    public class SearchPageController : PageController<SearchPage> {
        public ActionResult Index(SearchPage currentPage, string q = null, int page = 1) {
            var model = SearchPageViewModelBuilder.Create(currentPage, q, page);

            return View(model);
        }

        [NonAction]
        public override ActionResult Index(SearchPage currentPage)
        {
            // Decorated with NonAction in order to use optional parameters
            throw new NotImplementedException();
        }

    }
}