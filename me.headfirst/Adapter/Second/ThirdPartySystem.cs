using System;
using System.Collections.Generic;

namespace me.headfirst.Adapter.Second
{
    public class ThirdPartySystem
    {
        private readonly ICustomersService _customersService;

        public ThirdPartySystem(ICustomersService customersService)
        {
            _customersService = customersService;
        }

        public void ShowCustomersList()
        {
            IEnumerable<string> employee = _customersService.GetCustomersNames();
            foreach (var item in employee)
            {
                Console.WriteLine(item);
            }
        }
    }
}