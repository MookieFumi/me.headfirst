using System.Collections.Generic;

namespace me.headfirst.Adapter.Second
{
    public class CustomersAdapter : MySystem, ICustomersService
    {
        public IEnumerable<string> GetCustomersNames()
        {
            var employeeList = new List<string>();
            IEnumerable<string[]> customers = GetCustomers();
            foreach (var employee in customers)
            {
                employeeList.Add(employee[1]);
            }

            return employeeList;
        }
    }
}