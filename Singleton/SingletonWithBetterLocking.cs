namespace Singleton
{
    // This implementation has way less of an impact on performance since the
    // lock will only be fetched if the instance is null, which means only when
    // the app starts up or when the first request is made to to the instance.
    public class SingletonWithBetterLocking
    {
        private static SingletonWithBetterLocking? _instance;
        private static readonly object _padlock = new();

        public static SingletonWithBetterLocking Instance
        {
            get
            {
                if (_instance is null)
                    lock (_padlock)
                        _instance ??= new();
                return _instance;
            }
        }
    }
}