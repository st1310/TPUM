using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Windows.Input;
using TPUM_2021.Logic;

namespace TPUM_2021.Presentation.ViewModel
{
    internal class MainViewModel : BaseViewModel
    {
        public ICommand BuyCommand { get; }
        public ICommand AddSomeProductsCommand { get; }

        private ObservableCollection<ProductDto> _Products;
        private ObservableCollection<ProductDto> _CustomerProducts;
        private ObservableCollection<CustomerDto> _Customers;
        private ProductQuery _ProductQuery;
        private CustomerQuery _CustomerQuery;

        private ProductCommand _ProductCommand;

        private ProductDto _CurrentProduct;
        private CustomerDto _CurrentCustomer;

        private ReactiveTimer _ReactiveTimer;
        private IObservable<EventPattern<TickEventArgs>> _tickObservable;
        private IDisposable _observer;


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
            AddSomeProductsCommand = new RelayCommand(SetTimer);

            _ProductQuery = LogicFactory.ProductQuery;
            _CustomerQuery = LogicFactory.CustomerQuery;

            _ProductCommand = LogicFactory.ProductCommand;

            _Customers = new ObservableCollection<CustomerDto>(_CustomerQuery.GetAll());
            _CurrentCustomer = Customers[0];

            _Products = new ObservableCollection<ProductDto>(_ProductQuery.GetAvailableProducts());
            _CustomerProducts = new ObservableCollection<ProductDto>(_ProductQuery.GetProductsByCustomerId(_CurrentCustomer.Id));
            _CurrentProduct = Products[0];
        }

        public void SetTimer()
        {
            SetReactiveTimer(TimeSpan.FromSeconds(5));
        }

        public void SetReactiveTimer(TimeSpan period)
        {
            _ReactiveTimer = new ReactiveTimer(period);
            _tickObservable = Observable.FromEventPattern<TickEventArgs>(_ReactiveTimer, "Tick");
            _observer = _tickObservable.Subscribe(x => AddPrice());

            _ReactiveTimer.Start();
        }

        public void AddPrice()
        {
            ObservableCollection<ProductDto> productsTemp = Products;

            foreach (ProductDto product in productsTemp)
            {
                product.Price += 5;

                if (product.Price >= 50)
                {
                    product.Price = 52;
                }
            }

            Products = new ObservableCollection<ProductDto>(productsTemp);
        }

        public void BuyCurrentProduct()
        {
            if (CurrentProduct == null)
                return;

            CurrentProduct.CustomerId = CurrentCustomer.Id;
            _ProductCommand.Update(CurrentProduct.Id, CurrentProduct);

            Products = new ObservableCollection<ProductDto>(_ProductQuery.GetAvailableProducts());
            CustomerProducts = new ObservableCollection<ProductDto>(_ProductQuery.GetProductsByCustomerId(_CurrentCustomer.Id));
        }
    }
}
