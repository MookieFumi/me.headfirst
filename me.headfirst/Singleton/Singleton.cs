using System;

namespace me.headfirst.Singleton
{
    public class Singleton
    {
        private static Singleton _instance;

        private Singleton()
        {
            CreatedDateTime = DateTime.UtcNow;
        }

        public DateTime CreatedDateTime { get; private set; }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}