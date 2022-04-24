using TecAir_MobileApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace TecAir_MobileApp.Views
{
    /// <summary>
    /// Page to show the payment success.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaymentView : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentView" /> class.
        /// </summary>
        public PaymentView()
        {
            this.InitializeComponent();
            this.BindingContext = PaymentViewModel.BindingContext;
        }
    }
}