namespace Singleton
{
    // Using C#'s static type construction is a better way to achieve
    // thread-safety. This is due to the first locking approach affecting
    // performance negatively, and second one being complex, easy to forget, and
    // not compliant with the ECMA Common Language Interface specification.
    public class SingletonWithStaticConstructor
    {
        private static readonly SingletonWithStaticConstructor _instance = new();

        // Reading this will initialize the instance.
        public static readonly string GREETING = "Hi!";

        // Explicitly state `static` to tell the compiler to not mark this type with
        // `beforefieldinit`. This ensures that this type (and the _instance) is not instantiated
        // any earlier than possible.
        static SingletonWithStaticConstructor() { }

        public static SingletonWithStaticConstructor Instance => _instance;
    }
    // One downside to this approach is that if we attempt to read any static
    // field from this class (eg. GREETING), we're going to initialize our instance
}