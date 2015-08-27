namespace DemoSite.Models.Pages {
    using KalikoCMS.Attributes;
    using KalikoCMS.Core;
    using KalikoCMS.Core.Collections;

    /// <summary>
    /// This is a page type that will only act as a container and therefor has no additional properties.
    /// Setting AllowedTypes to only allow creation of other news lists and news pages under a news list page.
    /// </summary>
    [PageType("NewsList", "News list", 
        PageTypeDescription = "Used for news archives", 
        AllowedTypes = new[] { typeof(NewsListPage), typeof(NewsPage) },
        DefaultChildSortOrder = SortOrder.CreatedDate,
        DefaultChildSortDirection = SortDirection.Descending,
        PreviewImage = "/Assets/Images/newslistpage.png")]
    public class NewsListPage : CmsPage {
    }
}
