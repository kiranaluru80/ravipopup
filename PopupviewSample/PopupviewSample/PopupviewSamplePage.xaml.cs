using Xamarin.Forms;
using System;

namespace PopupviewSample
{
	public partial class PopupviewSamplePage : ContentPage
	{
		public PopupviewSamplePage()
		{
			InitializeComponent();
            pickerRef.Clicked += (object sender, EventArgs e) =>
              {
					  activityIndicatorLayout.IsVisible = true;
                OkRef.Clicked+= (object sendravier, EventArgs enemy) =>
                 {
                     activityIndicatorLayout.IsVisible = false;

                 };
                Cancelref.Clicked+=(object senderravi,EventArgs error)=>
                {
					  activityIndicatorLayout.IsVisible = false;

				  };
                      
              };
		}
	}
}
