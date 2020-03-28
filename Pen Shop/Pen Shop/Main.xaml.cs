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
    public partial class Main : ContentPage
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buybutton_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Success());
        }

        private class Success : Page
        {
        }
    }
}