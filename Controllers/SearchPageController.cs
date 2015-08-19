namespace DemoSite.Controllers {
    using System.Web.Mvc;
    using Business.ViewModelBuilders;
    using KalikoCMS.Mvc.Framework;
    using Models.Pages;

    public class SearchPageController : PageController<SearchPage> {
        public override ActionResult Index(SearchPage currentPage) {
            var model = PageViewModelBuilder.Create(currentPage);

            // TODO: Implement

            return Content("Coming soon :)");
            //return View(model);
        }
    }
}