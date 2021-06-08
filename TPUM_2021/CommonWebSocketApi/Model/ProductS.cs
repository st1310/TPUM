using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TPUM_2021.OPCUAdependencies.Model
{
    [DataContract]
    public class ProductS
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public int? CustomerId { get; set; }

        public ExtensionDataObject ExtensionData { get; set; }
    }
}
