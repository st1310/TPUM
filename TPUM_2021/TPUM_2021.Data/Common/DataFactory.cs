using System;
using System.Collections.Generic;
using System.Text;
using TPUM_2021.Data.Model;

namespace TPUM_2021.Data
{
    public static class DataFactory
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

        internal static AppContext _context = null;
        internal static AppContext Context
        {
            get
            {
                _context = new AppContext();
                return _context;
            }

            set
            {
                _context = value;
            }
        }

        public static IRepository EntityRepository<TEntity>() where TEntity : IEntity
        {
            if (typeof(TEntity) == typeof(ICustomer))
            {
                return CustomerRepository;
            }

            if (typeof(TEntity) == typeof(IInvoice))
            {
                return InvoiceRepository;
            }

            if (typeof(TEntity) == typeof(IProduct))
            {
                return ProductRepository;
            }

            throw new ArgumentException();
        }

        private static IRepository _CustomerRepository = null;
        public static IRepository CustomerRepository
        {
            get
            {
                _CustomerRepository ??= new Repository(Context);
                return _CustomerRepository;
            }
        }

        private static IRepository _InvoiceRepository = null;
        public static IRepository InvoiceRepository
        {
            get
            {
                _InvoiceRepository ??= new Repository(Context);
                return _InvoiceRepository;
            }
        }

        private static IRepository _ProductRepository = null;
        public static IRepository ProductRepository
        {
            get
            {
                _ProductRepository ??= new Repository(Context);
                return _ProductRepository;
            }
        }
    }
}
