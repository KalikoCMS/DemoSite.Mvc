namespace DemoSite.Models.ViewModels {
    using System.Collections.Generic;
    using KalikoCMS;
    using KalikoCMS.Core;
    using KalikoCMS.Search;
    using PagedList;
    using Pages;

    public class SearchPageViewModel : IPageViewModel<SearchPage> {
        public SearchPageViewModel(SearchPage currentPage) {
            CurrentPage = currentPage;
            CurrentSite = SiteFactory.CurrentSite<DemoSite>();
        }

        public SearchPage CurrentPage { get; private set; }
        public DemoSite CurrentSite { get; private set; }
        public IEnumerable<CmsPage> TopMenu { get; set; }
        public IPagedList<SearchHit> SearchResult { get; set; }
        public string Query { get; set; }
        public int Page { get; set; }
    }
}