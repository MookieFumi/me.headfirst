using System;
using me.headfirst.Adapter.First;
using me.headfirst.Adapter.Second;
using me.headfirst.Adapter.Third;
using NUnit.Framework;

namespace me.headfirst.Adapter
{
    public class AdapterTests
    {
        [Test]
        public void ElectricMotorAdapterTest()
        {
            ICombustionEngine combustionEngine = new DieselEngine();
            combustionEngine.TurnOn();
            combustionEngine.SpeeUp();
            combustionEngine.TurnOff();

            ICombustionEngine gasolineEngine = new GasolineEngine();
            gasolineEngine.TurnOn();
            gasolineEngine.SpeeUp();
            gasolineEngine.TurnOff();

            ICombustionEngine electricMotor = new ElectricMotorAdapter();
            electricMotor.TurnOn();
            electricMotor.SpeeUp();
            electricMotor.TurnOff();
        }

        [Test]
        public void CustomersServiceAdapterTest()
        {
            ICustomersService customersAdapter = new CustomersAdapter();
            ThirdPartySystem thirdPartySystem = new ThirdPartySystem(customersAdapter);
            thirdPartySystem.ShowCustomersList();
        }

        [Test]
        public void ProductServiceTest()
        {
            IProductsService productsServiceAdapter = new ProductsServiceAdapter();
            foreach (var product in productsServiceAdapter.GetProducts())
            {
                Console.WriteLine(product);
            }
            Console.ReadLine();
        }
    }
}