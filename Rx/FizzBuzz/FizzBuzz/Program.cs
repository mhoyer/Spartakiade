using System;

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
            
            Console.ReadKey();
        }
    }
}
