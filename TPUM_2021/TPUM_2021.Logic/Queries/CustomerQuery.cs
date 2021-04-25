using System;
using System.Collections.Generic;
using System.Text;
using TPUM_2021.Data;

namespace TPUM_2021.Logic
{
    public class CustomerQuery : Query<ICustomer, CustomerDto>
    {
        public CustomerQuery() : base(DataFactory.CustomerRepository)
        {

        }

        public CustomerQuery(IMapper mapper, IRepository repository) : base(mapper, repository)
        {

        }
    }
}
