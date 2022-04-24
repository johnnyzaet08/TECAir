using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TecAir_MobileApp.DataBaseConnections;
using TecAir_MobileApp.DataBaseModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TecAir_MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageFlightView : ContentPage
    {
        public ObservableCollection<Admins> Adminss { get; set; } = new ObservableCollection<Admins>();
        public PageFlightView()
        {
            InitializeComponent();
            /*var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
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
            BindingContext = this;*/
        }
    }
}