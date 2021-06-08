using System;
using System.Collections.Generic;
using System.Text;
using TPUM_2021.ServerData;

namespace TPUM_2021.ServerLogic
{
    public interface ICustomerQuery : IQuery<ICustomer, CustomerDto>
    {
    }
}
