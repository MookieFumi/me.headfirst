using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace me.headfirst.Prototype.Second
{
    public class ImportedProduct : IProduct
    {
        public string Name { get; set; }
        public string CountryCode { get; set; }

        public IProduct Clone()
        {
            // Shallow Copy: only top-level objects are duplicated
            return (IProduct)MemberwiseClone();

            // Deep Copy: all objects are duplicated
            //return (IProduct)this.Clone();
        }

        public string GetDetails()
        {
            return string.Format("{0} - {1}", Name, CountryCode);
        }
    }
}
