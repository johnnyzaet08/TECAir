using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using TecAir_MobileApp.DataBaseConnections;
using TecAir_MobileApp.DataBaseModels;
using TecAir_MobileApp.Validators;
using TecAir_MobileApp.Validators.Rules;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace TecAir_MobileApp.ViewModels
{
    /// <summary>
    /// ViewModel for Business Registration Form page 
    /// </summary> 
    [Preserve(AllMembers = true)]
    public class PageFlightViewModel : LoginViewModel
    {
        #region Constructor
        public ObservableCollection<Admins> Adminss { get; set; } = new ObservableCollection<Admins>();
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchViewModel" /> class
        /// </summary>
        public PageFlightViewModel()
        {
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;

            using (Stream stream = assembly.GetManifestResourceStream("TecAir_MobileApp.Data.sqliteTEC.db"))
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    stream.CopyTo(memoryStream);

                    File.WriteAllBytes(AdminsConnection.DbPath, memoryStream.ToArray());
                }
            }
            AdminsConnection connect = new AdminsConnection();
            foreach (var admin in connect.List())
            {
                Adminss.Add(admin);
            }
            this.InitializeProperties();
            //this.PromotionsCommand = new Command(this.PromotionsClicked);
            this.SubmitCommand = new Command(this.SubmitClicked); 
        }


        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the Full Name from user.
        /// </summary>
        public ValidatableObject<string> FullName { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the Business Name from user.
        /// </summary>
        public string BusinessName { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with a ComboBox that gets the Business from user.
        /// </summary>
        public string Business { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the Phone Number from user.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the Street Address from user.
        /// </summary>
        public string StreetAddress { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the City from user.
        /// </summary>
        public string City { get; set; }
        public Command PromotionsCommand { get; }

        #endregion

        #region Comments

        /// <summary>
        /// Gets or sets the command is executed when the Submit button is clicked.
        /// </summary>
        public Command SubmitCommand { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Initializzing the properties.
        /// </summary>
        private void InitializeProperties()
        {
            this.FullName = new ValidatableObject<string>();
        }


        /// <summary>
        /// Invoked when the Submit button clicked
        /// </summary>
        /// <param name="obj">The object</param>
        private async void SubmitClicked(object obj)
        {

            await NavigationService.NavigateToAsync<PaymentViewModel>();

        }
       

        #endregion
    }
}