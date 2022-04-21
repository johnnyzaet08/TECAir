using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TecAir_MobileApp.Services
{
    public class NavigationService : INavigationService
    {
        public Task NavigateToAsync<TViewModel>()
        {
            return InternalNavigateToAsync(typeof(TViewModel), null);
        }

        private async Task InternalNavigateToAsync( Type viewModelType , object parameter)
        {
            Page page = CreatePage(viewModelType, parameter);
            var navigationPage = Application.Current.MainPage as NavigationPage;
            if (navigationPage != null)
            {
                await navigationPage.PushAsync(page);
            }
            else
            {
                Application.Current.MainPage = new NavigationPage(page);
            }
        }
        private Page CreatePage(Type viewModelType, object parameter)
        {
            Type pageType = GetPageTypeForViewModel(viewModelType);
            if(pageType == null)
            {
                throw new Exception($"Cannot locate page type for {viewModelType}");

            }
            Page page = Activator.CreateInstance(pageType) as Page;
            return page;
        }
         private Type GetPageTypeForViewModel(Type viewModelType)
        {
            var viewName=
                viewModelType.FullName.Replace("Model", string.Empty);
            var viewModelAssemblyName =
                viewModelType.GetTypeInfo().Assembly.FullName;
            var viewAssemblyName = string.Format(CultureInfo.InvariantCulture, "{0}, {1}", viewName, viewModelAssemblyName);
            var viewType = Type.GetType(viewAssemblyName);
            return viewType;
        }
    }
}
