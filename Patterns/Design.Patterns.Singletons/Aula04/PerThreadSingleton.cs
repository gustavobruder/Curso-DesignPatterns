using System.Threading;

namespace Design.Patterns.Singletons.Aula04
{
    public sealed class PerThreadSingleton
    {
        private static ThreadLocal<PerThreadSingleton> _instance =
            new ThreadLocal<PerThreadSingleton>(() => new PerThreadSingleton());

        public int Id;

        public static PerThreadSingleton Instance => _instance.Value;

        private PerThreadSingleton()
        {
            Id = Thread.CurrentThread.ManagedThreadId;
        }
    }
}