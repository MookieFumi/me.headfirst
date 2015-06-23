using System.Collections.Generic;

namespace me.headfirst.Adapter.Second
{
    public class MySystem
    {
        public IEnumerable<string[]> GetCustomers()
        {
            var employees = new string[4][];

            employees[0] = new string[] { "100", "Deepak", "Team Leader" };
            employees[1] = new string[] { "101", "Rohit", "ImportedProduct" };
            employees[2] = new string[] { "102", "Gautam", "ImportedProduct" };
            employees[3] = new string[] { "103", "Dev", "Tester" };

            return employees;
        }
    }
}
