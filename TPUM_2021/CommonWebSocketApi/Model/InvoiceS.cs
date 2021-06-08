using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TPUM_2021.OPCUAdependencies.Model
{
    [DataContract]
    public class InvoiceS
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int ProductId { get; set; }

        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        public ExtensionDataObject ExtensionData { get; set; }
    }
}
