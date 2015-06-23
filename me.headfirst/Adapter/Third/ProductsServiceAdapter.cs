using System.Collections.Generic;

namespace me.headfirst.Adapter.Third
{
    class ProductsServiceAdapter : IProductsService
    {
        public IEnumerable<string> GetProducts()
        {
            var externalProductsServices = new ExternalProductsServices();
            var products = externalProductsServices.GetListOfProducts();

            //ForEach uses Action<T>, which means that you could affect x if it were not immutable
            return products.ConvertAll(p => p.ToUpper());
        }
    }
}