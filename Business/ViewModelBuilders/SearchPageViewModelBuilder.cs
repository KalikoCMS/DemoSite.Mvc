namespace DemoSite.Business.ViewModelBuilders {
    using System.Collections.Generic;
    using KalikoCMS.Search;
    using Models.Pages;
    using Models.ViewModels;
    using PagedList;

    public class SearchPageViewModelBuilder {
        public const int PageSize = 5;

        public static SearchPageViewModel Create(SearchPage currentPage, string query, int page) {
            var model= new SearchPageViewModel(currentPage);
            PageViewModelBuilder.SetBaseProperties(model);
            model.SearchResult = new PagedList<SearchHit>(GetSearchResult(currentPage, query, page), page, PageSize);
            model.Query = query;
            model.Page = page;
            return model;
        }

        private static List<SearchHit> GetSearchResult(SearchPage currentPage, string query, int page) {
            // Build the query and tell the search engine that we want the additional fields "category" and "summary"
            var searchQuery = new SearchQuery(query) {
                MetaData = new[] {"category", "summary"}
                //NumberOfHitsToReturn = PageSize,
                //ReturnFromPosition = PageSize*(page - 1)
            };

            // Perform the searh
            var result = SearchManager.Instance.Search(searchQuery);

            return result.Hits;
        }
    }
}