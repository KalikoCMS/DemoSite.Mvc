namespace DemoSite.Business.PropertyTypes {
    using KalikoCMS.Attributes;
    using KalikoCMS.Core;
    using KalikoCMS.Serialization;

    [PropertyType("9033A828-B49A-4A19-9C20-0F9BEBBD3273", "Feature", "Feature", "~/Business/PropertyTypes/FeaturePropertyEditor.ascx")]
    public class FeatureProperty : PropertyData {
        private int? _cachedHashCode;

        public FeatureProperty() { 
        }

        public FeatureProperty(string header, string description, string url) {
            Header = header;
            Description = description;
            Url = url;
        }

        public string Header { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }

        // Needs to be implemented, displayed when accessing ToString() or preview
        protected override string StringValue {
            get { return string.Format("{0}", Header); }
        }

        // Needs to be implemented, just call DeserializeJson with your type
        protected override PropertyData DeserializeFromJson(string data) {
            return JsonSerialization.DeserializeJson<FeatureProperty>(data);
        }
        
        // Needs to be implemented, returns a hash for an instance of this type
        public override int GetHashCode() {
            return (int)(_cachedHashCode ?? (_cachedHashCode = CalculateHashCode()));
        }

        // Include all custom fields so that a correct hash is calculated
        private int CalculateHashCode() {
            int hash = JsonSerialization.GetNewHash();
            hash = JsonSerialization.CombineHashCode(hash, Header);
            hash = JsonSerialization.CombineHashCode(hash, Description);
            hash = JsonSerialization.CombineHashCode(hash, Url);

            return hash;
        }
    }
}