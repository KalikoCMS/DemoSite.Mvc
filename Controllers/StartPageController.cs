namespace DemoSite.Controllers {
    using System.Web.Mvc;
    using Business.ViewModelBuilders;
    using KalikoCMS.Mvc.Framework;
    using Models.Pages;

    public class StartPageController : PageController<StartPage> {
        public override ActionResult Index(StartPage currentPage) {
            var model = StartPageViewModelBuilder.Create(currentPage);

            return View(model);
        }
    }
}