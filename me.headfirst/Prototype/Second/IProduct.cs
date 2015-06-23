namespace me.headfirst.Prototype.Second
{
    public interface IProduct
    {
        IProduct Clone();
        string GetDetails();
    }
}