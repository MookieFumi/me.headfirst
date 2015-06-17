namespace me.headfirst.Decorator.Second.Phones
{
    public class S6Edge : Phone
    {
        public S6Edge()
        {
            Description = "Samsung S6 Edge";
        }

        public override decimal Cost()
        {
            return 500;
        }
    }
}