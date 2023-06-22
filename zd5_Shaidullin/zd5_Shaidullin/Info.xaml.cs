using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd5_Shaidullin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Info : ContentPage
    {
        public Info(string login, string password)
        {
            InitializeComponent();

            usernameLabel.Text = login;
            passwordLabel.Text = password;
        }
    }
}