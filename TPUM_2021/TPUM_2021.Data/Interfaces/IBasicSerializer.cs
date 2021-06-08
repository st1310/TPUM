using System;
using System.Collections.Generic;
using System.Text;

namespace TPUM_2021.ServerData
{
    public interface IBasicSerializer
    {
        public void Serialize();
        public void Deserialize();
    }
}
