using System;

namespace me.headfirst.Factory.Second.Bikes
{
    public class TwentyNineNerve : Nerve
    {
        private readonly INerveComponentsFactory _nerveComponentsFactory;

        public TwentyNineNerve(INerveComponentsFactory nerveComponentsFactory)
        {
            _nerveComponentsFactory = nerveComponentsFactory;
            SignedBy = "Canyon 29";
        }

        public override void Assemble()
        {
            Fork = _nerveComponentsFactory.CreateFork();
            RearShock = _nerveComponentsFactory.CreateRearShock();
            Console.WriteLine("SignedBy {0}", SignedBy);
        }
    }
}