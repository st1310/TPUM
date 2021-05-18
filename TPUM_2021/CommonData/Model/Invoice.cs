using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

[assembly: InternalsVisibleTo("TPUM_2021.ServerTest")]
[assembly: InternalsVisibleTo("TPUM_2021.ServerData")]
[assembly: InternalsVisibleTo("TPUM_2021.ClientData")]

namespace TPUM_2021.CommonData.Model
{
    [DataContract]
    internal class Invoice : IInvoice
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
