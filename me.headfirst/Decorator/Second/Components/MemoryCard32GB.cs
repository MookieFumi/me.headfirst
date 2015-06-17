namespace me.headfirst.Decorator.Second.Components
{
    public class MemoryCard32GB : ComponentDecorator
    {
        private readonly Phone _phone;

        public MemoryCard32GB(Phone phone)
        {
            _phone = phone;
        }

        public override string GetSpecifications()
        {
            return _phone.GetSpecifications() + ", MemoryCard32GB";
        }

        public override decimal Cost()
        {
            return _phone.Cost() + 40;
        }
    }
}