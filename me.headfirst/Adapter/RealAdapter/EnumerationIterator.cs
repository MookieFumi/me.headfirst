using System;

namespace me.headfirst.Adapter.RealAdapter
{
    public class EnumerationIterator : IIterator
    {
        private readonly IEnumerator _enumerator;

        public EnumerationIterator(IEnumerator enumerator)
        {
            _enumerator = enumerator;
        }

        public bool HasNext()
        {
            return _enumerator.HasMoreElements();
        }

        public void Next()
        {
            _enumerator.NextElement();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
