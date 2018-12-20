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
	public partial class Torch : ContentPage
	{
		public Torch ()
		{
			InitializeComponent ();

            //padding for iphone
            if (Device.OS == TargetPlatform.iOS)
                Padding = new Thickness(0, 20, 0, 0);
        }

        private async void ButtonOn_Clicked(object sender, EventArgs e)
        {
            try
            {    //Turn on
                await Flashlight.TurnOnAsync();
            }
            catch (FeatureNotSupportedExcepton fnsEx)
            {
                //Handle not supported on device exception
            }
            catch (PermissionException pEx)
            {
                //Handle not supported on device exception
            }
            catch (Exception ex)
            {
                //Handle not supported on device exception
            }
        }

        private async void ButtonOff_Clicked(object sender, EventArgs e)
        {
            try
            {    //Turn off
                await Flashlight.TurnOffAsync();
            }
            catch (FeatureNotSupportedExcepton fnsEx)
            {
                //Handle not supported on device exception
            }
            catch (PermissionException pEx)
            {
                //Handle not supported on device exception
            }
            catch (Exception ex)
            {
                //Handle not supported on device exception
            }

        }
    }
}