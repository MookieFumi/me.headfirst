using me.headfirst.Prototype.First;
using me.headfirst.Prototype.Second;
using NUnit.Framework;

namespace me.headfirst.Prototype
{
    public class PrototypeTests
    {
        [Test]
        public void PrototypeCloneTest()
        {
            ConcretePrototypeA prototype = new ConcretePrototypeA() { PropertyOne = 99 };
            IPrototype clonedPrototype = prototype.Clone();
            ConcretePrototypeA c = ((ConcretePrototypeA)clonedPrototype);

            Assert.AreEqual(prototype.PropertyOne, c.PropertyOne);
        }

        [Test]
        public void ProductCloneTest()
        {
            var product = new Product { Name = "0001" };
            var clonedProduct = (Product)product.Clone();

            ImportedProduct importedProduct = new ImportedProduct();
            importedProduct.Name = "0002";
            importedProduct.CountryCode = "49 - Germany";

            ImportedProduct clonedImportedProduct = (ImportedProduct)importedProduct.Clone();
            clonedImportedProduct.Name = "0003";
            clonedImportedProduct.CountryCode = "50 - Finland";
        }
    }
}