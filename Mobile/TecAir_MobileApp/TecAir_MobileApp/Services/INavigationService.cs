using System.Threading.Tasks;

namespace TecAir_MobileApp.Services
{
    public interface INavigationService
    {
        Task NavigateToAsync<TViewModel>();
    }
}