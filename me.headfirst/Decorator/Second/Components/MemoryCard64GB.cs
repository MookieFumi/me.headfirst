namespace me.headfirst.Decorator.Second.Components
{
    public class MemoryCard64GB : ComponentDecorator
    {
        private readonly Phone _phone;

        public MemoryCard64GB(Phone phone)
        {
            _phone = phone;
        }

        public override string GetSpecifications()
        {
            return _phone.GetSpecifications() + ", MemoryCard64GB";
        }

        public override decimal Cost()
        {
            return _phone.Cost() + 80;
        }
    }
}