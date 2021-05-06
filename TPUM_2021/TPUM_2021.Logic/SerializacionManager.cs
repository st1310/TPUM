using System;
using System.Collections.Generic;
using System.Text;
using TPUM_2021.Data;

namespace TPUM_2021.Logic
{
    public class SerializationManager
    {
        private BasicSerializer basicSerializer;
        public SerializationManager(BasicSerializer basicSerializer)
        {
            this.basicSerializer = basicSerializer;
        }

        public void Serialize()
        {
            basicSerializer.Serialize();
        }
    }
}