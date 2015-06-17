namespace me.headfirst.Decorator.First.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "HouseBlend";
        }
        public override double Cost()
        {
            return .89;
        }
    }
}