using System;
using System.Collections.Generic;
using System.Text;
using TPUM_2021.ClientData;

namespace TPUM_2021.ClientLogic
{
    public class CustomerQuery : Query<ICustomer, CustomerDto>, ICustomerQuery
    {
        public CustomerQuery() : base(DataFactory.CustomerRepository)
        {

        }

        public CustomerQuery(IMapper mapper, IRepository repository) : base(mapper, repository)
        {

        }
    }
}
