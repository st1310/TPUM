using System;
using System.Collections.Generic;
using System.Text;
using TPUM_2021.ServerData;

namespace TPUM_2021.ServerLogic
{
    public class SerializationManager
    {
        private IBasicSerializer basicSerializer;
        public SerializationManager(IBasicSerializer basicSerializer)
        {
            this.basicSerializer = basicSerializer;
        }

        public void Serialize()
        {
            basicSerializer.Serialize();
        }
    }
}