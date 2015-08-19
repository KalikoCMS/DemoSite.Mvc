namespace DemoSite.Business.PropertyTypes {
    using KalikoCMS.Core;
    using KalikoCMS.PropertyType;

    public partial class FeaturePropertyEditor : PropertyEditorBase {
        // Used for the system to set a label when editing the propery
        public override string PropertyLabel {
            set { LabelText.Text = value; }
        }

        // Any validation logic goes here
        public override bool Validate() {
            return true;
        }

        // Any validation logic if property is required (or not) goes here
        public override bool Validate(bool required) {
            return true;
        }

        // Box and unbox our input fields to a FeatureProperty instance
        public override PropertyData PropertyValue {
            get {
                var property = new FeatureProperty {
                    Header = HeaderField.Text, 
                    Description = DescriptionField.Text, 
                    Url = UrlField.Text
                };

                return property;
            }
            set {
                var property = (FeatureProperty)value;

                HeaderField.Text = property.Header;
                DescriptionField.Text = property.Description;
                UrlField.Text = property.Url;
            }
        }

        // Ability to pass parameters to the editor, not used in our case
        public override string Parameters {
            set { throw new System.NotImplementedException(); }
        }
    }
}