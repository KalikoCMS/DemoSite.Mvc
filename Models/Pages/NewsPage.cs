namespace DemoSite.Models.Pages {
    using System;
    using KalikoCMS.Attributes;
    using KalikoCMS.Core;
    using KalikoCMS.PropertyType;
    using KalikoCMS.Search;

    // Setting AllowedTypes to an empty array means that no pages can be created under a news page
    [PageType("NewsPage", "News page", 
        PageTypeDescription = "Used for news", 
        AllowedTypes = new Type[] {},
        PreviewImage = "/Assets/Images/newspage.png")]
    public class NewsPage : CmsPage, IIndexable {
        [Property("Headline")]
        public virtual StringProperty Headline { get; set; }

        [Property("Preamble")]
        public virtual TextProperty Preamble { get; set; }

        [Property("Main body")]
        public virtual HtmlProperty MainBody { get; set; }

        /// <summary>
        /// This function is required when implementing IIndexable and will feed the 
        /// search engine with the content that should be indexed when a page of this 
        /// particular page type is saved.
        /// You should always get the IndexItem object by calling GetBaseIndexItem and 
        /// add the content you wish to be indexed for search.
        /// </summary>
        /// <param name="page">The page that was saved</param>
        /// <returns>An object containing the content to be indexed</returns>
        public IndexItem MakeIndexItem(CmsPage page) {
            // We start by casting the generic CmsPage object to our page type
            var typedPage = page.ConvertToTypedPage<NewsPage>();

            // Get the base index item with basic information already set
            var indexItem = typedPage.GetBaseIndexItem();

            // Add additional information to index, this is where you add the page's properties that should be searchable
            indexItem.Title = typedPage.Headline.Value;
            indexItem.Summary = typedPage.Preamble.Value;
            indexItem.Content = typedPage.Preamble.Value + typedPage.MainBody.Value;
            indexItem.Tags = "News";
            
            // We set a category in order to be able to single out search hits
            indexItem.Category = "News";

            return indexItem;
        }
    }
}
