namespace me.headfirst.Singleton
{
    public class SingletonMultiThreading
    {
        private static SingletonMultiThreading _instance;
        private static readonly object Padlock = new object();

        private SingletonMultiThreading() { }

        public static SingletonMultiThreading Instance
        {
            get
            {
                lock (Padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonMultiThreading();
                    }
                    return _instance;
                }
            }
        }
    }
}