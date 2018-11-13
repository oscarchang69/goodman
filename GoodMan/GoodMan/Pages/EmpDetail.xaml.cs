using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoodMan.ViewModel.DTO;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoodMan.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EmpDetail : ContentPage
	{
        public UserInfor UserInfor { get; set; }

        public EmpDetail ()
		{
			InitializeComponent ();
		}

        public EmpDetail(UserInfor e){
            InitializeComponent();
            vmCP.userInfor = e;
            vmCP.picker = picker;
        }

	}
}