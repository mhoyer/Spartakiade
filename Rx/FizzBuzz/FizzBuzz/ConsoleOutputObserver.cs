using System;

namespace FizzBuzz
{
    public class ConsoleOutputObserver : IObserver<int>
    {
        public void OnNext(int value)
        {
            Console.WriteLine(value);
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("error: {0}", error);
        }

        public void OnCompleted()
        {
            Console.WriteLine("done");
        }
    }
}