using me.headfirst.Factory.Second.Bikes;

namespace me.headfirst.Factory.Second.Shops
{
    public class RetailShop : Shop
    {
        protected override Nerve CreateNerve(FrameSize size)
        {
            var retailShopComponentFactory = new RetailShopComponentFactory();
            switch (size)
            {
                case FrameSize.Default:
                    return new DefaultNerve(retailShopComponentFactory);
                default:
                    return null;
            }
        }
    }
}