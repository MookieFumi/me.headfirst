using System;
using System.Security.Cryptography.X509Certificates;

namespace me.headfirst.Factory.Second
{
    public abstract class Nerve
    {
        protected string SignedBy { get; set; }
        protected string Fork { get; set; }
        protected string RearShock { get; set; }

        public virtual void Assemble()
        {
            SignedBy = "Canyon";
            Console.WriteLine("SignedBy {0}", SignedBy);
        }
    }
}