﻿using System;

namespace TPUM_2021.ClientData
{
    public class CommonDataFactory
    {
        public static ICustomer GetCustomer => new Customer();
        public static IInvoice GetInvoice => new Invoice();
        public static IProduct GetProduct => new Product();

        public static IEntity GetEntity(Type type)
        {
            if (type == typeof(ICustomer))
            {
                return new Customer();
            }

            if (type == typeof(IInvoice))
            {
                return new Invoice();
            }

            if (type == typeof(IProduct))
            {
                return new Product();
            }

            throw new ArgumentException();
        }
    }
}
