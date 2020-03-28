using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Success : ContentPage
    {
        public Success()
        {
            InitializeComponent();
        }
        private void successbutton_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }
        private void meenuubutton_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Main());
        }
    }
}