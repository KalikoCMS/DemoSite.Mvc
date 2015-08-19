namespace DemoSite.Controllers {
    using System.Web.Mvc;
    using Business.FakeStore;
    using Business.ViewModelBuilders;
    using KalikoCMS.Mvc.Framework;
    using Models.Pages;

    public class ProductListPageController : PageController<ProductListPage> {
        public override ActionResult Index(ProductListPage currentPage) {
            var model = ProductListPageViewModelBuilder.Create(currentPage);

            return View(model);
        }

        public ActionResult Product(ProductListPage currentPage, string productId) {
            var model = ProductListPageViewModelBuilder.Create(currentPage);

            // Get the product from our fake product store
            model.SelectedProduct = FakeProductDatabase.GetProduct(productId);
            
            return View("Product", model);
        }
    }
}