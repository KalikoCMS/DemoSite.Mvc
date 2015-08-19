namespace DemoSite.Models.ViewModels {
    using System.Collections.Generic;
    using Business.FakeStore;
    using KalikoCMS.Core;
    using Pages;

    public class ProductListPageViewModel : IPageViewModel<ProductListPage> {
        public ProductListPageViewModel(ProductListPage currentPage)
        {
            CurrentPage = currentPage;
        }

        public ProductListPage CurrentPage { get; private set; }
        public IEnumerable<CmsPage> TopMenu { get; set; }
        public List<Product> Products { get; set; }
        public Product SelectedProduct { get; set; }
    }
}