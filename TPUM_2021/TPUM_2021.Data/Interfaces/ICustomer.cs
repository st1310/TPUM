﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TPUM_2021.ServerData
{
    public interface ICustomer : IEntity
    {
        string Name { get; set; }
        decimal Funds { get; set; }
    }
}
