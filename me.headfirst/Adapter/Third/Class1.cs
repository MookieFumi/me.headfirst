using System;
using System.Security.Cryptography.X509Certificates;

namespace me.headfirst.Adapter.Third
{
    public interface IDuck
    {
        void Quack();
        void Fly();
    }

    public interface ITurkey
    {
        void Gobble();
        void Fly();
    }

    public class MallarDuck:IDuck    {
        public void Quack()
        {
            Console.WriteLine("Quack mallar duck");
        }

        public void Fly()
        {
            Console.WriteLine("Fly mallar duck");
        }
    }

    public class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gooble gooble");
        }

        public void Fly()
        {
            Console.WriteLine("Fly short distance");
        }
    }

    public class TurkeyAdapter: IDuck
    {
        private readonly ITurkey _turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }

        public void Quack()
        {
            _turkey.Gobble();
        }

        public void Fly()
        {
            _turkey.Fly();
        }
    }
}
