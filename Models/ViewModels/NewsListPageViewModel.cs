namespace DemoSite.Models.ViewModels {
    using System.Collections;
    using System.Collections.Generic;
    using KalikoCMS.Core;
    using Pages;

    public class NewsListPageViewModel : IPageViewModel<NewsListPage> {
        public NewsListPageViewModel(NewsListPage currentPage) {
            CurrentPage = currentPage;
        }

        public NewsListPage CurrentPage { get; private set; }
        public IEnumerable<CmsPage> TopMenu { get; set; }
        public IEnumerable<CmsPage> News { get; set; }
        public IEnumerable<CmsPage> NewsHolders { get; set; }
    }
}