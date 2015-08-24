namespace DemoSite.Models.ViewModels {
    using System.Collections.Generic;
    using KalikoCMS.Core;
    using Pages;

    public class StartPageViewModel : IPageViewModel<StartPage> {
        public StartPageViewModel(StartPage currentPage)
        {
            CurrentPage = currentPage;
        }

        public StartPage CurrentPage { get; private set; }
        public IEnumerable<CmsPage> TopMenu { get; set; }
        public IEnumerable<CmsPage> LatestNews { get; set; }
    }
}