using System.Collections.Generic;

namespace me.headfirst.Adapter.Third
{
    public class ExternalProductsServices
    {
        public List<string> GetListOfProducts()
        {
            var products = new List<string> 
            {
                "Gaming Consoles", 
                "Television", 
                "Books", 
                "Musical Instruments"
            };
            return products;
        }
    }
}
