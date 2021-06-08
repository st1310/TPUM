using System;
using System.Collections.Generic;
using System.Text;

namespace TPUM_2021.ServerLogic
{
    public class LogicFactory : CommonLogicFactory
    {
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

        private static ProductCommand _productCommand = null;
        public static ProductCommand ProductCommand
        {
            get
            {
                _productCommand ??= new ProductCommand();
                return _productCommand ?? new ProductCommand();
            }

            set
            {
                _productCommand = value;
            }
        }
    }
}
