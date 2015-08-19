namespace DemoSite.Business.ViewModelBuilders {
    using System.Collections.Generic;
    using System.Linq;
    using KalikoCMS;
    using KalikoCMS.Core;
    using KalikoCMS.Core.Collections;
    using Models.Pages;
    using Models.ViewModels;

    public class StartPageViewModelBuilder {
        public static StartPageViewModel Create(StartPage currentPage) {
            var model = new StartPageViewModel(currentPage);
            PageViewModelBuilder.SetBaseProperties(model);
            model.LatestNews = GetLatestNews();
            return model;
        }

        private static IEnumerable<CmsPage> GetLatestNews() {
            // Get the page type based on our NewsPage definition
            var pageType = PageType.GetPageType(typeof(NewsPage));

            // Get all pages of the news page type
            var news = PageFactory.GetPages(pageType.PageTypeId);

            // Sort so that the last published news is first
            news.Sort(SortOrder.StartPublishDate, SortDirection.Descending);

            // Return the five latest news
            return news.Take(5);
        }
    }
}