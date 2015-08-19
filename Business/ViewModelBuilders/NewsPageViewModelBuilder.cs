namespace DemoSite.Business.ViewModelBuilders {
    using KalikoCMS.Search;
    using Models.Pages;
    using Models.ViewModels;

    public class NewsPageViewModelBuilder {
        public static NewsPageViewModel Create(NewsPage currentPage) {
            var model = new NewsPageViewModel(currentPage);
            PageViewModelBuilder.SetBaseProperties(model);

            model.RelatedNews = SearchManager.Instance.FindSimular(currentPage, 0, 5);

            return model;
        }

    }
}