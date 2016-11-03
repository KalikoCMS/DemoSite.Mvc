namespace DemoSite.Models.ViewModels {
    using System.Collections.Generic;
    using KalikoCMS;
    using KalikoCMS.Core;
    using KalikoCMS.Search;
    using Pages;

    public class NewsPageViewModel : IPageViewModel<NewsPage> {
        public NewsPageViewModel(NewsPage currentPage) {
            CurrentPage = currentPage;
            CurrentSite = SiteFactory.CurrentSite<DemoSite>();
        }

        public NewsPage CurrentPage { get; private set; }
        public DemoSite CurrentSite { get; private set; }
        public IEnumerable<CmsPage> TopMenu { get; set; }
        public SearchResult RelatedNews { get; set; }
    }
}