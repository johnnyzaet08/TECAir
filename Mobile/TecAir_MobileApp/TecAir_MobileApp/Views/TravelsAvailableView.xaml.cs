using TecAir_MobileApp.DataService;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace TecAir_MobileApp.Views
{
    /// <summary>
    /// Page to show the catalog list. 
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TravelsAvailableView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TravelsAvailableView" /> class.
        /// </summary>
        public TravelsAvailableView()
        {
            this.InitializeComponent();
            this.BindingContext = CatalogDataService.Instance.CatalogPageViewModel;
        }
    }
}