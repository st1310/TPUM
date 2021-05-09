using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TPUM_2021.CommonData;
using TPUM_2021.CommonData.Model;
using TPUM_2021.ServerData;

namespace TPUM_2021.ClientData
{
    public class DataFactory : CommonDataFactory
    {
        public static async Task ConnectClient() => await Context.ConnectClient();

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
