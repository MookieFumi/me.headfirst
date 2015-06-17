namespace me.headfirst.Decorator.Second
{
    public abstract class Phone
    {
        protected string Description = "Unkown phone";

        public virtual string GetSpecifications()
        {
            return Description;
        }

        public abstract decimal Cost();
    }
}
