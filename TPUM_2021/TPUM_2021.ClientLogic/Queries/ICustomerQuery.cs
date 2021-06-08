using System;
using System.Collections.Generic;
using System.Text;
using TPUM_2021.ClientData;

namespace TPUM_2021.ClientLogic
{
    public interface ICustomerQuery : IQuery<ICustomer, CustomerDto>
    {
    }
}
