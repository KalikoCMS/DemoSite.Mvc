namespace DemoSite.Controllers {
    using Business.ViewModelBuilders;
    using KalikoCMS.Mvc.Framework;
    using Models.Pages;
    using System.Web.Mvc;

    public class ArticlePageController : PageController<ArticlePage> {
        public override ActionResult Index(ArticlePage currentPage) {
            var model = PageViewModelBuilder.Create(currentPage);

            return View(model);
        }
    }
}