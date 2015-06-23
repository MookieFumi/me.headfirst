namespace me.headfirst.Prototype.Second
{
    public class Product : IProduct
    {
        public string Name { get; set; }

        public IProduct Clone()
        {
            // Shallow Copy: only top-level objects are duplicated
            return (IProduct)MemberwiseClone();

            // Deep Copy: all objects are duplicated
            //return (IProduct)this.Clone();
        }

        public string GetDetails()
        {
            return string.Format("{0}", Name);
        }
    }
}