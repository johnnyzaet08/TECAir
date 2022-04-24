using System;
using System.Collections.Generic;
using System.Text;
using TecAir_MobileApp.Services;
using TinyIoC;

namespace TecAir_MobileApp.ViewModels
{
    public static class ViewModelLocator
    {
        private static TinyIoCContainer _container;
        static ViewModelLocator()
        {
            _container = new TinyIoCContainer();
         
            _container.Register<LoginPageViewModel>();
            _container.Register<LoginViewModel>();
            _container.Register<Page1ViewModel>();  
            _container.Register<SearchViewModel>();
            _container.Register<Page2ViewModel>();
            _container.Register<AddCardPageViewModel>();
            _container.Register<PaymentViewModel>();
            _container.Register<PageFlightViewModel>();
      

            _container.Register<INavigationService, NavigationService>();
        }
        public static T Resolve<T>() where T : class
        {
            return _container.Resolve<T>();
        }
    }
}
