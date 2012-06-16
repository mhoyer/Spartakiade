using System;
using System.Reactive.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var producer = new NumberProducer();
            var observer = new NumberObservable(producer);

            var consumer = new ConsoleOutputObserver();

            observer.Subscribe(consumer);
            producer.Produce();
            
            // short way
            Observable
                .Range(0, 100)
                .Subscribe(Console.Write);

            Console.ReadKey();
        }
    }
}
