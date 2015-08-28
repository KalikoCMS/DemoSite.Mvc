namespace DemoSite.Business.ViewModelBuilders {
    using System.Collections.Generic;
    using System.Linq;
    using KalikoCMS;
    using KalikoCMS.Core;
    using KalikoCMS.Core.Collections;
    using Models.Pages;
    using Models.ViewModels;
    using PagedList;

    public class NewsListPageViewModelBuilder {
        public const int PageSize = 10;

        public static NewsListPageViewModel Create(NewsListPage currentPage, int page) {
            var model= new NewsListPageViewModel(currentPage);
            PageViewModelBuilder.SetBaseProperties(model);
            model.News = new PagedList<NewsPage>(GetNews(currentPage), page, PageSize);
            model.NewsHolders = GetNewsHolders(currentPage);
            model.Page = page;
            return model;
        }

        private static IEnumerable<NewsPage> GetNews(NewsListPage currentPage) {
            // Get the page type for news page
            var pageType = PageType.GetPageType(typeof(NewsPage));

            // Get all news from the list level and below
            var newsPages = PageFactory.GetPageTreeFromPage(currentPage.PageId, p => p.IsAvailable);

            // Sort on publish start date descending
            newsPages.Sort(SortOrder.StartPublishDate, SortDirection.Descending);

            // TODO: Page the result

            // Return all news pages
            return newsPages.Where(x => x.PageTypeId == pageType.PageTypeId).Select(x => x.ConvertToTypedPage<NewsPage>());
        }

        private static IEnumerable<NewsListPage> GetNewsHolders(NewsListPage currentPage) {
            // Get the page type for news lists
            var pageType = PageType.GetPageType(typeof(NewsListPage));

            // Get all children from the news root
            return PageFactory.GetChildrenForPageOfPageType(currentPage.RootId, pageType.PageTypeId).Select(x => x.ConvertToTypedPage<NewsListPage>());
        }
    }
}