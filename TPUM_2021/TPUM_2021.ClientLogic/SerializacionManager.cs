using System;
using System.Collections.Generic;
using System.Text;
using TPUM_2021.ClientData;

namespace TPUM_2021.ClientLogic
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