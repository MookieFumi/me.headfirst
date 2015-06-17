namespace me.headfirst.Decorator.Second.Components
{
    public class FrontCamera13MP : ComponentDecorator
    {
        private readonly Phone _phone;

        public FrontCamera13MP(Phone phone)
        {
            _phone = phone;
        }

        public override string GetSpecifications()
        {
            return _phone.GetSpecifications() + ", FrontCamera13MP";
        }

        public override decimal Cost()
        {
            return _phone.Cost() + 60;
        }
    }
}