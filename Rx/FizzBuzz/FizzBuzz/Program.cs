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
            var generator = Observable
                .Range(0, 100)
                .Select(
                    x =>
                        {
                            if (x % 15 == 0) return "FizzBuzz";
                            if (x % 3 == 0) return "Fizz";
                            if (x % 5 == 0) return "Buzz";

                            return x.ToString();
                        })
                .Do(Console.Write);

            generator.Subscribe();

            Console.ReadKey();
        }
    }
}
