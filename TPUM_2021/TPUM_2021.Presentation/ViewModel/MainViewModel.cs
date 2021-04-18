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
        public ICommand BuyCommand { get; }

        private ObservableCollection<ProductDto> _Products;
        private ObservableCollection<ProductDto> _CustomerProducts;
        private ObservableCollection<CustomerDto> _Customers;
        private ProductQuery _ProductQuery;
        private CustomerQuery _CustomerQuery;

        private ProductCommand _ProductCommand;

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
            BuyCommand = new RelayCommand(BuyCurrentProduct);

            _ProductQuery = DependencyResolver.ProductQuery;
            _CustomerQuery = DependencyResolver.CustomerQuery;

            _ProductCommand = DependencyResolver.ProductCommand;

            _Customers = new ObservableCollection<CustomerDto>(_CustomerQuery.GetAll());
            _CurrentCustomer = Customers[0];

            _Products = new ObservableCollection<ProductDto>(_ProductQuery.GetAvailableProducts());
            _CustomerProducts = new ObservableCollection<ProductDto>(_ProductQuery.GetProductsByCustomerId(_CurrentCustomer.Id));
            _CurrentProduct = Products[0];
        }

        public void BuyCurrentProduct()
        {
            CurrentProduct.CustomerId = CurrentCustomer.Id;
            _ProductCommand.Update(CurrentProduct.Id, CurrentProduct);

            Products = new ObservableCollection<ProductDto>(_ProductQuery.GetAvailableProducts());
            CustomerProducts = new ObservableCollection<ProductDto>(_ProductQuery.GetProductsByCustomerId(_CurrentCustomer.Id));
        }
    }
}
