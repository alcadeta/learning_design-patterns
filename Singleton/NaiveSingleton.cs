using System;

namespace Singleton
{
    // Naive because it's not thread-safe. In multi-threaded environments,
    // multiple threads can cause an invocation of the constructor. This leads
    // to multiple instances being created.
    public sealed class NaiveSingleton
    {
        private static NaiveSingleton? _instance;

        public static NaiveSingleton Instance => _instance ??= new();

        private NaiveSingleton()
        {
        }
    }
}