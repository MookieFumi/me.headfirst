namespace me.headfirst.Decorator.Second
{
    public abstract class ComponentDecorator : Phone
    {
        public override abstract string GetSpecifications();
        public override abstract decimal Cost();
    }
}