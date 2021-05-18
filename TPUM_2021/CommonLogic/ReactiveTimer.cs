using System;
using System.Collections.Generic;
using System.Text;
using System.Reactive.Concurrency;
using System.Reactive.Linq;

namespace TPUM_2021.CommonLogic
{
    public class ReactiveTimer : IDisposable
    {
        public ReactiveTimer(TimeSpan period)
        {
            Period = period;
        }

        public event EventHandler<TickEventArgs> Tick;

        public void Start()
        {
            IObservable<long> _TimerObservable = Observable.Interval(Period);
            m_TimerSubscription = _TimerObservable.ObserveOn(Scheduler.Default).Subscribe(c => RaiseTick(c));
        }
        public TimeSpan Period
        {
            get;
            private set;
        }

        IDisposable m_TimerSubscription = null;

        private void RaiseTick(long counter)
        {
            Tick?.Invoke(this, new TickEventArgs(counter));
        }

        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO:
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

    }
}
