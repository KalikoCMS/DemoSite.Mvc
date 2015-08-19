namespace DemoSite.Models.ViewModels {
    using System.Collections.Generic;
    using KalikoCMS.Core;

    public class PageViewModel<T> : IPageViewModel<T> where T : CmsPage {
        public PageViewModel(T currentPage) {
            CurrentPage = currentPage;
            TopMenu = new List<CmsPage>();
        }

        public T CurrentPage { get; private set; }
        public IEnumerable<CmsPage> TopMenu { get; set; }
    }
}