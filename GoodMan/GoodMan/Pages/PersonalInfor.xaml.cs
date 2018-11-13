using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoodMan.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PersonalInfor : ContentPage
	{
		public PersonalInfor ()
		{
			InitializeComponent ();
            vm.CP = pageCP;     
           

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("我是title", "我是訊息", "取消");

        }
    }
}