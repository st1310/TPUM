﻿using System;
using System.Collections.Generic;
using System.Text;
using TPUM_2021.ServerData;

namespace TPUM_2021.ServerLogic
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
