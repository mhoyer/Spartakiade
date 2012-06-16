using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;

namespace FizzBuzz
{
    public class NumberObservable : IObservable<int>
    {
        private IList<IObserver<int>> _obsersers;

        public NumberObservable(NumberProducer producer)
        {
            _obsersers = new List<IObserver<int>>();
            producer.OnNumber += 
                i => _obsersers.ToList().ForEach(o => o.OnNext(i));
        }

        public IDisposable Subscribe(IObserver<int> observer)
        {
            _obsersers.Add(observer);

            return Disposable.Empty;
        }
    }
}