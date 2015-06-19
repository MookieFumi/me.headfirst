namespace me.headfirst.Factory.Second
{
    public class OnlineShopComponentFactory : INerveComponentsFactory
    {
        public string CreateRearShock()
        {
            return "2015. Fox Float CTD Performance Boost Valve";
        }

        public string CreateFork()
        {
            return "2015. Fox 32 Float 29 CTD Fit Performance";
        }
    }
}