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

            if (Device.OS == TargetPlatform.iOS)
                Padding = new Thickness(0, 20, 0, 0);
        }

        private void Torch_Clicked(object sender, EventArgs e) => DisplayAlert("Title", "Torch Page", "Ok");
        private void Calculator_Clicked(object sender, EventArgs e) => DisplayAlert("Title", "Calcuator Page", "Ok");
        private void BMICalculator_Clicked(object sender, EventArgs e) => DisplayAlert("Title", "BMI Calculator Page", "Ok");
    }
}
