namespace DemoSite.Controllers {
    using System.Web.Mvc;
    using Business.ViewModelBuilders;
    using KalikoCMS.Mvc.Framework;
    using Models.Pages;
    using Models.ViewModels;

    public class ContactPageController : PageController<ContactPage> {
        public override ActionResult Index(ContactPage currentPage) {
            var model = ContactPageViewModelBuilder.Create(currentPage);
            return View(model);
        }

        public ActionResult SendMessage(ContactPage currentPage, ContactPageFormData formData) {
            var model = ContactPageViewModelBuilder.Create(currentPage);

            if (ModelState.IsValid) {
                // Do your magic here to send the message as you see fit, for instance using https://sendgrid.com

                // Then display the "thank you"-message
                return View("ThankYou", model);
            }

            model.FormData = formData;
            return View("Index", model);
        }
    }
}