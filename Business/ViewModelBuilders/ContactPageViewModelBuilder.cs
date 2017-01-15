namespace DemoSite.Business.ViewModelBuilders {
    using Models.Pages;
    using Models.ViewModels;

    public class ContactPageViewModelBuilder {
        public static ContactPageViewModel Create(ContactPage currentPage) {
            var model = new ContactPageViewModel(currentPage);
            PageViewModelBuilder.SetBaseProperties(model);
            
            return model;
        }
    }
}