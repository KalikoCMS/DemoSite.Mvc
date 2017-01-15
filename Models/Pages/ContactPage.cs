namespace DemoSite.Models.Pages {
    using KalikoCMS.Attributes;
    using KalikoCMS.Core;
    using KalikoCMS.PropertyType;

    // This is a sample contact form and shows how to post to a secondary action in your page controller
    [PageType("ContactPage", "Contact page", PageTypeDescription = "Used for contact form", PreviewImage = "/Assets/Images/contactpage.png")]
    public class ContactPage : CmsPage {
        [Property("Headline")]
        public virtual StringProperty Headline { get; set; }

        [Property("Main body")]
        public virtual HtmlProperty MainBody { get; set; }

        [Property("Thank you-message")]
        public virtual HtmlProperty ThankYouMessage { get; set; }

        [Property("Where to send the mail")]
        public virtual StringProperty MailToAddress { get; set; }
    }
}