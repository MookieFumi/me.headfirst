namespace me.headfirst.Factory.Second
{
    public abstract class Shop
    {
        public Nerve OrderNerve(FrameSize size)
        {
            Nerve nerve = CreateNerve(size);
            nerve.Assemble();
            return nerve;
        }

        protected abstract Nerve CreateNerve(FrameSize size);
    }
}
