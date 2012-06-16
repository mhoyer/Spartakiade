using System;

namespace FizzBuzz
{
    public class NumberProducer
    {
        public event Action<int> OnNumber;

        public void Produce()
        {
            for (int i = 0; i < 100; i++)
            {
                if (OnNumber == null) continue;
                OnNumber(i);
            }
        }
    }
}