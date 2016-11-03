namespace DemoSite.Models.ViewModels {
    using System.Collections.Generic;
    using KalikoCMS;
    using KalikoCMS.Core;

    public class PageViewModel<T> : IPageViewModel<T> where T : CmsPage {
        public PageViewModel(T currentPage) {
            CurrentPage = currentPage;
            CurrentSite = SiteFactory.CurrentSite<DemoSite>();
            TopMenu = new List<CmsPage>();
        }

        public T CurrentPage { get; private set; }
        public DemoSite CurrentSite { get; private set; }
        public IEnumerable<CmsPage> TopMenu { get; set; }
    }
}