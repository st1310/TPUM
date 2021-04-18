using System;
using System.Collections.Generic;
using System.Text;
using TPUM_2021.Data;
using TPUM_2021.Data.Model;

namespace TPUM_2021.Logic
{
    public class CustomerQuery : Query<Customer, CustomerDto>
    {
        public CustomerQuery() : base()
        {

        }

        public CustomerQuery(IMapper mapper, IRepository<Customer> repository) : base(mapper, repository)
        {

        }
    }
}
