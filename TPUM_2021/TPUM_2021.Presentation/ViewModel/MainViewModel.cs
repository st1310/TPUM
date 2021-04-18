using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using TPUM_2021.Logic;

namespace TPUM_2021.Presentation.ViewModel
{
    internal class MainViewModel : BaseViewModel
    {
        public ICommand DoCommand { get; }
        public ICommand DoNextCommand { get; }

        private ObservableCollection<ProductDto> _Products;
        private ObservableCollection<ProductDto> _CustomerProducts;
        private ObservableCollection<CustomerDto> _Customers;
        private ProductQuery _ProductQuery;
        private CustomerQuery _CustomerQuery;

        private ProductDto _CurrentProduct;
        private CustomerDto _CurrentCustomer;

        public ObservableCollection<ProductDto> Products
        {
            get
            {
                return _Products;
            }
            set
            {
                _Products = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<ProductDto> CustomerProducts
        {
            get
            {
                return _CustomerProducts;
            }
            set
            {
                _CustomerProducts = value;
                RaisePropertyChanged();
            }
        }

        public ProductDto CurrentProduct
        {
            get
            {
                return _CurrentProduct;
            }
            set
            {
                _CurrentProduct = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<CustomerDto> Customers
        {
            get
            {
                return _Customers;
            }
            set
            {
                _Customers = value;
                RaisePropertyChanged();
            }
        }

        public CustomerDto CurrentCustomer
        {
            get
            {
                return _CurrentCustomer;
            }
            set
            {
                _CurrentCustomer = value;
                RaisePropertyChanged();
            }
        }

        public MainViewModel()
        {
            //DoCommand = to do;
            //DoNextCommand = to do;

            _ProductQuery = DependencyResolver.ProductQuery;
            _CustomerQuery = DependencyResolver.CustomerQuery;
            _CustomerProducts = new ObservableCollection<ProductDto>(_ProductQuery.GetAvailableProducts());
            _Products = new ObservableCollection<ProductDto>(_ProductQuery.GetProductsByCustomerId(1));
            _Customers = new ObservableCollection<CustomerDto>(_CustomerQuery.GetAll());
            _CurrentProduct = Products[0];
            _CurrentCustomer = Customers[0];
        }


    }
}
