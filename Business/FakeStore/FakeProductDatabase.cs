namespace DemoSite.Business.FakeStore {
    using System.Collections.Generic;

    /// <summary>
    /// This class fakes what otherwise might have been an external product database.
    /// It's included in order to show how easy it is to feed the web site with content 
    /// from other sources without needing to mirror the structure or information as
    /// pages in the system.
    /// </summary>
    public class FakeProductDatabase {
        private static readonly List<Product> Products = new List<Product>() {
            new Product("dom-siltech", "Dom Siltech", "Pine Valley Winery fuses unheard-of Cap'n Crunch flavors and a earthy gingerbread aftertaste in their 1994 Pinot Grigio."), 
            new Product("dong-findex", "Dong Findex", "Scopazzi Bros Vineyards merges thick albuterol undertones and a bashful pepper flavor in their 2011 Red Zinfandel."), 
            new Product("faxtip", "Faxtip", "The 2005 Chardonnay from Chateau Lazare entangles Croatian sour cream overtones with a well-hidden mango-fandango essence."), 
            new Product("singlenimin", "Singlenimin", "A loud strawberry aroma and obsessive sloppy joe elements are binded in the 2006 White Pinot from Scoliosis Winery."), 
            new Product("tough-ronron", "Tough Ronron", "A South American lavender bouquet and unremarkable bean curd essences are entangled in the 2002 White Zinfandel from Pepsi Vineyards."), 
            new Product("zerlam", "Zerlam", "The 1990 Cabernet from Jose Rodrigues Winery binds bleachy pheremone midtones with a cantankerous wood chip finish.")
        };


        public static bool IsValidProduct(string productId) {
            return Products.Exists(p => p.Id == productId);
        }

        public static List<Product> GetProducts() {
            return Products;
        }

        public static Product GetProduct(string productId) {
            return Products.Find(p => p.Id == productId);
        }
    }
}