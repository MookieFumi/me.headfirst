namespace me.headfirst.Decorator.Second.Components
{
    public class FrontCamera6MP : ComponentDecorator
    {
        private readonly Phone _phone;

        public FrontCamera6MP(Phone phone)
        {
            _phone = phone;
        }

        public override string GetSpecifications()
        {
            return _phone.GetSpecifications() + ", FrontCamera6MP";
        }

        public override decimal Cost()
        {
            return _phone.Cost() + 30;
        }
    }
}