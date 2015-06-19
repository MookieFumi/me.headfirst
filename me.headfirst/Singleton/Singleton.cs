using System;

namespace me.headfirst.Singleton
{
    public class Singleton
    {
        private static Singleton _instance;
        public DateTime CreatedDateTime { get; private set; }

        private Singleton()
        {
            CreatedDateTime = DateTime.UtcNow;
        }

        public static  Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}