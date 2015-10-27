namespace DemoSite.Business.PropertyTypes {
    using KalikoCMS.Attributes;
    using KalikoCMS.PropertyType;

    [PropertyType("9033A828-B49A-4A19-9C20-0F9BEBBD3273", "Feature", "Feature", EditorControl)]
    public class FeatureProperty : CompositeProperty {
        [Property("Header")]
        public StringProperty Header { get; set; }

        [Property("Feature body")]
        public HtmlProperty Description { get; set; }

        [Property("Featured link")]
        public LinkProperty Url { get; set; }

        // Override Preview with how to render items of this type in lists.
        // It's also possible to use more complex HTML-layout here if wanted.
        public override string Preview {
            get { return Header.Preview; }
        }
    }
}