using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace zd5_Shaidullin
{
    public partial class MainPage : ContentPage
    {

        string login;
        string password;

        public MainPage(string login, string password)
        {
            InitializeComponent();

            this.login = login;
            this.password = password;   
        }



        private void button_Clicked(object sender, EventArgs e)
        {
            // получение значений выбранных элементов
            double sliderValue = slider3.Value;
            int department = (int)sliderValue + 1;


            Navigation.PushModalAsync(new Info(login, password));
        }



        private void slider4_1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double maxValue = slider4_1.Maximum;
            double value = e.NewValue;

            if (value > (maxValue / 2))
            {
                slider4_1.Value = maxValue / 2;
                slider4_2.Value = maxValue / 2;
            }
            else { slider4_2.Value = value; }
        }

        private void toggleSwitch1_2_Toggled(object sender, ToggledEventArgs e)
        {
            bool isToggled = e.Value;
            onSwitch1_2.IsVisible = isToggled;
            offSwitch1_2.IsVisible = !isToggled;
        }

        private void toggleSwitch1_3_Toggled(object sender, ToggledEventArgs e)
        {
            bool isToggled = e.Value;
            onSwitch1_3.IsVisible = isToggled;
            offSwitch1_3.IsVisible = !isToggled;
        }

        private void toggleSwitch2_2_Toggled(object sender, ToggledEventArgs e)
        {
            bool isToggled = e.Value;
            onSwitch2_2.IsVisible = isToggled;
            offSwitch2_2.IsVisible = !isToggled;
        }

        private void toggleSwitch2_3_Toggled(object sender, ToggledEventArgs e)
        {
            bool isToggled = e.Value;
            onSwitch2_3.IsVisible = isToggled;
            offSwitch2_3.IsVisible = !isToggled;
        }
    }
}
