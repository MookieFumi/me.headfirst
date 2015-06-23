namespace me.headfirst.Prototype.First
{
    public class ConcretePrototypeA : IPrototype
    {
        public int PropertyOne { get; set; }

        public IPrototype Clone()
        {
            // Shallow Copy: only top-level objects are duplicated
            return (IPrototype)MemberwiseClone();

            // Deep Copy: all objects are duplicated
            //return (IPrototype)this.Clone();
        }
    }
}
