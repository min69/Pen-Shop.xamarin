using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shop.TABLE;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace shop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Loginbutton_clicked(object sender, EventArgs e)
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "User.db");
            var db = new SQLiteConnection(dbPath);
            var query = db.Table<LIST>().Where(u => u.Username.Equals(Userlabel.Text) && u.Password.Equals(Passlabel.Text)).FirstOrDefault();

            if (query != null)
            {
                App.Current.MainPage = new NavigationPage(new Main());
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Error", "Failed Username and Password!", "Cancel", "Yes");
                    if (result)
                    {
                        await Navigation.PushAsync(new Login());
                    }
                    else
                    {
                        await Navigation.PushAsync(new Login());
                    }
                });
            }
        }
        private void registerbutton_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registerr());
        }
    }
}
