namespace DemoSite.Controllers {
    using System.Web.Mvc;
    using Business.ViewModelBuilders;
    using KalikoCMS.Mvc.Framework;
    using Models.Pages;

    public class NewsPageController : PageController<NewsPage> {
        public override ActionResult Index(NewsPage currentPage) {
            var model = NewsPageViewModelBuilder.Create(currentPage);

            return View(model);
        }
    }
}