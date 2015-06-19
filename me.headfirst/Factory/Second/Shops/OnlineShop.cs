using me.headfirst.Factory.Second.Bikes;

namespace me.headfirst.Factory.Second.Shops
{
    public class OnlineShop : Shop
    {
        protected override Nerve CreateNerve(FrameSize size)
        {
            var onlineShopComponentFactory = new OnlineShopComponentFactory();

            switch (size)
            {
                case FrameSize.Default:
                    return new DefaultNerve(onlineShopComponentFactory);
                case FrameSize.TwentyNine:
                    return new TwentyNineNerve(onlineShopComponentFactory);
                default:
                    return null;
            }
        }


    }
}