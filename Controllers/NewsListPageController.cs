namespace DemoSite.Controllers {
    using System;
    using System.Web.Mvc;
    using Business.ViewModelBuilders;
    using KalikoCMS.Mvc.Framework;
    using Models.Pages;

    public class NewsListPageController : PageController<NewsListPage> {
        public ActionResult Index(NewsListPage currentPage, int page = 1) {
            var model = NewsListPageViewModelBuilder.Create(currentPage, page);

            return View(model);
        }

        [NonAction]
        public override ActionResult Index(NewsListPage currentPage) {
            // Decorated with NonAction in order to use optional parameters
            throw new NotImplementedException();
        }
    }
}