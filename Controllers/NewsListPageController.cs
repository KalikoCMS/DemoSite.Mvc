namespace DemoSite.Controllers {
    using System.Web.Mvc;
    using Business.ViewModelBuilders;
    using KalikoCMS.Mvc.Framework;
    using Models.Pages;

    public class NewsListPageController : PageController<NewsListPage> {
        public override ActionResult Index(NewsListPage currentPage) {
            var model = NewsListPageViewModelBuilder.Create(currentPage);

            return View(model);
        }
    }
}