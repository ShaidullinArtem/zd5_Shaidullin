using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zd5_Shaidullin.store;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd5_Shaidullin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {

        public Login()
        {
            InitializeComponent();
        }

        private async void signin_Clicked(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(login_field.Text) || string.IsNullOrEmpty(password_field.Text))
            {
                DisplayAlert("Ошибка", "Заполните все поля", "Окей");
                return;
            }

            await SaveApplicationProperty("user", login_field.Text);
            Navigation.PushAsync(new MainPage());
        }

        private async Task SaveApplicationProperty<T>(string key, T value)
        {
            Xamarin.Forms.Application.Current.Properties[key] = value;
            await Xamarin.Forms.Application.Current.SavePropertiesAsync();
        }
    }
}