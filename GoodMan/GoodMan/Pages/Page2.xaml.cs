using GoodMan.DS;
using GoodMan.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoodMan.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();
            vmcp.CP =this.pageCP;
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var result = await DependencyService.Get<IQrCodeScanningService>().ScanAsync();
            vmcp.UserID = result;
            //await DisplayAlert("通知", result, "好");

        }
    }
}