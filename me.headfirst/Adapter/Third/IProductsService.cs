using System.Collections.Generic;

namespace me.headfirst.Adapter.Third
{
    interface IProductsService
    {
        IEnumerable<string> GetProducts();
    }
}