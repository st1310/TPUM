using System;
using System.Collections.Generic;
using System.Text;

namespace TPUM_2021.ClientData
{
    internal class RepositoryObserver : IObserver<string>
    {
        private IDisposable unsubscriber;
        public Action<string> onMessage { set; protected get; } = x => { };

        public virtual void Subscribe(IObservable<string> provider)
        {
            if (provider != null)
                unsubscriber = provider.Subscribe(this);
        }

        public void OnCompleted()
        {
            this.Unsubscribe();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(string value)
        {
            onMessage?.Invoke(value);
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
    }
}
