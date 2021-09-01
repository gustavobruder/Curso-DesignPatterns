using System;
using System.Threading.Tasks;

namespace Design.Patterns.Singletons.Aula04
{
    public class Aula04
    {
        public static void Executar()
        {
            var thread1 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine($"Thread 1: {PerThreadSingleton.Instance.Id}");
            });

            var thread2 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine($"Thread 2: {PerThreadSingleton.Instance.Id}");
                Console.WriteLine($"Thread 2: {PerThreadSingleton.Instance.Id}");
            });

            Task.WaitAll(thread1, thread2);
        }
    }
}