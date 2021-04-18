using System;
using System.Collections.Generic;
using System.Text;

namespace TPUM_2021.Logic
{
    public static class DependencyResolver
    {
        private static Data.AppContext _context = null;
        public static Data.AppContext Context
        {
            get
            {
                _context ??= new Data.AppContext();
                return _context ?? new Data.AppContext();
            }

            set
            {
                _context = value;
            }
        }

        private static Mapper _mapper = null;
        public static Mapper Mapper
        {
            get
            {
                _mapper ??= new Mapper();
                return _mapper ?? new Mapper();
            }

            set
            {
                _mapper = value;
            }
        }

        private static CustomerQuery _customerQuery = null;
        public static CustomerQuery CustomerQuery
        {
            get
            {
                _customerQuery ??= new CustomerQuery();
                return _customerQuery ?? new CustomerQuery();
            }

            set
            {
                _customerQuery = value;
            }
        }

        private static ProductQuery _productQuery = null;
        public static ProductQuery ProductQuery
        {
            get
            {
                _productQuery ??= new ProductQuery();
                return _productQuery ?? new ProductQuery();
            }

            set
            {
                _productQuery = value;
            }
        }
    }
}
