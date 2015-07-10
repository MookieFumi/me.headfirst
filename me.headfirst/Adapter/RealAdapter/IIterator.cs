namespace me.headfirst.Adapter.RealAdapter
{
    interface IIterator
    {
        bool HasNext();
        void Next();
        void Remove();
    }
}