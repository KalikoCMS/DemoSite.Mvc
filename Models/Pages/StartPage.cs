namespace DemoSite.Models.Pages {
    using Business.PropertyTypes;
    using KalikoCMS.Attributes;
    using KalikoCMS.Core;
    using KalikoCMS.PropertyType;

    /// <summary>
    /// This is the type for our start page. Here we'll use our own custom property type; FeatureProperty
    /// </summary>
    [PageType("StartPage", "Start page", PageTypeDescription = "Used for start page", PreviewImage = "/Assets/Images/startpage.png")]
    public class StartPage : CmsPage {

        /// <summary>
        /// A collection of 0..n of our custom FeatureProperty type
        /// </summary>
        [Property("Main feature slides", TabGroup = TabGroups.Slider)]
        public virtual CollectionProperty<FeatureProperty> Slides { get; set; }

        [Property("Main feature", TabGroup = TabGroups.Features)]
        public virtual FeatureProperty MainFeature { get; set; }

        [Property("Secondary feature", TabGroup = TabGroups.Features)]
        public virtual FeatureProperty SecondaryFeature { get; set; }
    }
}