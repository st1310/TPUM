using System;
using System.Collections.Generic;
using System.Text;

namespace TPUM_2021.ServerLogic
{
    public class TickEventArgs : EventArgs
    {
        public TickEventArgs(long counter)
        {
            Counter = counter;
        }
        public long Counter
        {
            get;
            private set;
        }
    }
}
