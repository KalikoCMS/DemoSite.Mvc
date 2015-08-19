namespace DemoSite.Models.Pages {
    using KalikoCMS.Attributes;
    using KalikoCMS.Core;
    using KalikoCMS.PropertyType;
    using KalikoCMS.Search;

    /// <summary>
    /// This is a standard page type for articles. We got a few defined properties.
    /// </summary>
    [PageType("ArticlePage", "Article page", PageTypeDescription = "Used for articles", PreviewImage = "/Assets/Images/articlepage.png")]
    public class ArticlePage : CmsPage, IIndexable {
        /// <summary>
        /// Simple string headline to use instead of pagename in the articles.
        /// </summary>
        [Property("Headline")]
        public virtual StringProperty Headline { get; set; }

        /// <summary>
        /// To set a required width and/or height for images use the [ImageProperty] 
        /// attribute instead of the standard [Property]
        /// </summary>
        [ImageProperty("Top image", Width = 848, Height = 180)]
        public virtual ImageProperty TopImage { get; set; }

        [Property("Preamble")]
        public virtual TextProperty Preamble { get; set; }

        [Property("Main body")]
        public virtual HtmlProperty MainBody { get; set; }

        /// <summary>
        /// The tag property enable tags for a particular page type. Notice that you can 
        /// use multiple tag spaces for the same page by setting different tag contexts.
        /// Be sure to use [TagProperty] to define the TagContext, otherwise it will 
        /// fallback to the standard tag space.
        /// </summary>
        [TagProperty("Tags", TagContext = "article")]
        public virtual TagProperty Tags { get; set; }

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
            var typedPage = page.ConvertToTypedPage<ArticlePage>();

            // Get the base index item with basic information already set
            var indexItem = typedPage.GetBaseIndexItem();

            // Add additional information to index, this is where you add the page's properties that should be searchable
            indexItem.Title = typedPage.Headline.Value;
            indexItem.Summary = typedPage.Preamble.Value;
            indexItem.Content = typedPage.Preamble.Value + " " + typedPage.MainBody.Value;
            indexItem.Tags = typedPage.Tags.ToString();
            
            // We set a category in order to be able to single out search hits
            indexItem.Category = "Article";
            
            return indexItem;
        }
    }
}