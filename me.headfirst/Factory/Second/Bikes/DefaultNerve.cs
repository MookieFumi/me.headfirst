using System;

namespace me.headfirst.Factory.Second.Bikes
{
    public class DefaultNerve : Nerve
    {
        private readonly INerveComponentsFactory _nerveComponentsFactory;

        public DefaultNerve(INerveComponentsFactory nerveComponentsFactory)
        {
            _nerveComponentsFactory = nerveComponentsFactory;
            SignedBy = "Canyon";
        }

        public override void Assemble()
        {
            Fork = _nerveComponentsFactory.CreateFork();
            RearShock = _nerveComponentsFactory.CreateRearShock();
            Console.WriteLine("SignedBy {0}", SignedBy);
        }
    }

}