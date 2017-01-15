namespace DemoSite.Models.ViewModels {
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using KalikoCMS;
    using KalikoCMS.Core;
    using Pages;

    public class ContactPageViewModel : IPageViewModel<ContactPage> {
        public ContactPageViewModel(ContactPage currentPage) {
            CurrentPage = currentPage;
            CurrentSite = SiteFactory.CurrentSite<DemoSite>();
            FormData = new ContactPageFormData();
        }

        public ContactPage CurrentPage { get; private set; }
        public DemoSite CurrentSite { get; private set; }
        public IEnumerable<CmsPage> TopMenu { get; set; }
        public ContactPageFormData FormData { get; set; }
    }

    public class ContactPageFormData {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string EmailAddress { get; set; }
        
        [Required]
        [Display(Name = "Subject")]
        public string Subject { get; set; }
        
        [Required]
        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}