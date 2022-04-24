using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using TecAir_MobileApp.Validators;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace TecAir_MobileApp.ViewModels
{
    /// <summary>
    /// ViewModel for Payment page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [DataContract]
    public class PaymentViewModel : BaseViewModel
    {
        #region Fields

        private static PaymentViewModel paymentViewModel;

        private Command trackOrderCommand;

        private Command makePaymentCommand;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="PaymentViewModel"/> class.
        /// </summary>
        public PaymentViewModel()
        {
            this.InitializeProperties();
            this.SubmitCommand = new Command(this.TrackOrderClicked);
        }

        private void InitializeProperties()
        {
            this.FullName = new ValidatableObject<string>();
        }
        public ValidatableObject<string> FullName { get; set; }
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the value of payment view model.
        /// </summary>
        public static PaymentViewModel BindingContext =>
            paymentViewModel = PopulateData<PaymentViewModel>("transaction.json");

        /// <summary>
        /// Gets or sets the payment success icon.
        /// </summary>
        [DataMember(Name = "paymentSuccessIcon")]
        public string PaymentSuccessIcon { get; set; }

        /// <summary>
        /// Gets or sets the payment failure icon.
        /// </summary>
        [DataMember(Name = "paymentFailureIcon")]
        public string PaymentFailureIcon { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// Gets the command that will be executed when track order button is clicked.
        /// </summary>
        public Command SubmitCommand { get; set; }

        /// <summary>
        /// Gets the command that will be executed when make payment button is clicked.
        /// </summary>
        

        #endregion

        #region Methods

        /// <summary>
        /// Populates the data for view model from json file.
        /// </summary>
        /// <typeparam name="T">Type of view model.</typeparam>
        /// <param name="fileName">Json file to fetch data.</param>
        /// <returns>Returns the view model object.</returns>
        private static T PopulateData<T>(string fileName)
        {
            var file = "TecAir_MobileApp.Data." + fileName;

            var assembly = typeof(App).GetTypeInfo().Assembly;

            T data;

            using (var stream = assembly.GetManifestResourceStream(file))
            {
                var serializer = new DataContractJsonSerializer(typeof(T));
                data = (T)serializer.ReadObject(stream);
            }

            return data;
        }

        /// <summary>
        /// Invoked when track order button is clicked.
        /// </summary>
        private async void TrackOrderClicked(object obj)
        {
            await NavigationService.NavigateToAsync<SearchViewModel>();
        }

        /// <summary>
        /// Invoked when make payment button is clicked.
        /// </summary>
       

        #endregion
    }
}
