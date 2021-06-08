using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TPUM_2021.ClientData
{
    public interface IEntity : IExtensibleDataObject
    {
        int Id { get; set; }
    }
}
