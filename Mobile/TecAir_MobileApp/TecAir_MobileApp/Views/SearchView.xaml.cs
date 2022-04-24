using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace TecAir_MobileApp.Views
{
    /// <summary>
    /// Page to add business details such as name, email address, and phone number.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchView : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchView" /> class.
        /// </summary>
        public SearchView()
        {
            this.InitializeComponent();
        }

        private void endDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {

        }

        private void includeSwitch_Toggled(object sender, ToggledEventArgs e)
        {

        }
    }
}