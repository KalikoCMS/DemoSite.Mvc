namespace DemoSite.Business.ViewModelBuilders {
    using FakeStore;
    using Models.Pages;
    using Models.ViewModels;

    public class ProductListPageViewModelBuilder {
        public static ProductListPageViewModel Create(ProductListPage currentPage) {
            var model= new ProductListPageViewModel(currentPage);
            PageViewModelBuilder.SetBaseProperties(model);
            model.Products = FakeProductDatabase.GetProducts();
            return model;
        }
    }
}