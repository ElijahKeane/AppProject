using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //padding for iphone
            if (Device.OS == TargetPlatform.iOS)
                Padding = new Thickness(0, 20, 0, 0);
        }
        //setting up click functions
        async void Torch_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Torch());
        }

        async void Calculator_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Calculator());
        }

        async void BMICalculator_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BMICalculator());
        }
    }
}
