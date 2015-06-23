using System.Collections.Generic;

namespace me.headfirst.Adapter.Second
{
    public interface ICustomersService
    {
        IEnumerable<string> GetCustomersNames();
    }
}