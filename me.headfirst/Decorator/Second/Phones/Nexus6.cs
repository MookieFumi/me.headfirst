namespace me.headfirst.Decorator.Second.Phones
{
    public class Nexus6 : Phone
    {
        public Nexus6()
        {
            Description = "Motorola Nexus 6";
        }

        public override decimal Cost()
        {
            return 400;
        }
    }
}