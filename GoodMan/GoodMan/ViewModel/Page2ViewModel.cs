using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Newtonsoft.Json;
using GoodMan.ViewModel.DTO;
using GoodMan.DS;
using System.Net;

namespace GoodMan.ViewModel
{
    public class Page2ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ContentPage CP { get; set; }
        public ICommand btnLogin
        {
            get
            {
                return new Command(() =>
               {
                   GetUserInfor(this.UserID);
               });
            }
        }

        private string _UserID;
        public string UserID
        {
            get { return _UserID; }
            set
            {
                _UserID = value;
                PropertyChanged(this, new PropertyChangedEventArgs("UserID"));
            }
        }

        private string _InforJSON;
        public string InforJSON
        {
            get
            {
                return _InforJSON;
            }
            set
            {
                _InforJSON = value;
                PropertyChanged(this, new PropertyChangedEventArgs("InforJSON"));
            }
        }

        private async void GetUserInfor(string userID)
        {
            var hc = new HttpClient();

            try
            {
                //var data = await hc.GetStringAsync($"https://www.ddm.org.tw/DdmPortal_test/api/v1/login/user-infor/{userID}");
                //var inforObj = JsonConvert.DeserializeObject<UserInfor>(data);
                //await CP.Navigation.PushAsync(new Pages.EmpDetail(inforObj));


                HttpResponseMessage response = await hc.GetAsync($"https://www.ddm.org.tw/DdmPortal_test/api/v1/login/user-infor/{userID}");

                if (!response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        await CP.DisplayAlert("錯誤", "登入失敗", "確定");
                    }
                    return;
                }

                String data = await response.Content.ReadAsStringAsync();
                var inforObj = JsonConvert.DeserializeObject<UserInfor>(data);
                await CP.Navigation.PushAsync(new Pages.EmpDetail(inforObj));





            }
            catch (Exception ex)
            {
                await CP.DisplayAlert("錯誤", ex.Message.ToString(), "確定");
            }


        }

        public ICommand scanLogin
        {
            get
            {
                return new Command(async () =>
                {
                    var result = await DependencyService.Get<IQrCodeScanningService>().ScanAsync(); 
                    if (result != "")
                    {
                        GetUserInfor(result);
                    }

                });
            }
        }

      
    }
}
