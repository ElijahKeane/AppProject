using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppProject
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BMICalculator : ContentPage
	{
		public BMICalculator ()
		{
			InitializeComponent ();

            if (Device.OS == TargetPlatform.iOS)
                Padding = new Thickness(0, 20, 0, 0);
        }

        private void ButtonCalculate_Click(object sender, RoutedEventArgs e)
        {
            var weight = float.Parse(this.InputWeight.Text);
            var height = float.Parse(this.InputHeight.Text);

            var result = Calculator.CalculateBodyMassIndex(weight, height);

            this.OutputResult.Text = result.ToString();
        }

    }
}