namespace Singleton
{
    // The simplest and most obvious approach for implementing thread-safety is
    // to use a padlock. This approach works but it has negative performance
    // impacts because every use of the Instance property will now incur the
    // overhead of the `lock`.
    public class SingletonWithLocking
    {
        private static SingletonWithLocking? _instance;
        private static readonly object _padlock = new();

        public static SingletonWithLocking Instance
        {
            get
            {
                // This same lock is used on *every* call reference to the Singleton
                lock (_padlock)
                    return _instance ??= new();
            }
        }

        private SingletonWithLocking()
        {
        }
    }
}