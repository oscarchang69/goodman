using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using GoodMan.ViewModel.DTO;
using Xamarin.Forms;

namespace GoodMan.ViewModel
{
    public class EmpDetailViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public Picker picker { get; set; }

        private UserInfor _userInfor;
        public UserInfor userInfor
        {
            get
            {
              
                return _userInfor;
            }
            set
            {
                _userInfor = value;
                this.登入者帳號 = _userInfor.登入者帳號;
                this.登入者姓名 = _userInfor.登入者姓名;
                this.部門名稱 = _userInfor.部門名稱;
                this.systemCollection = _userInfor.登入者系統;

                EmpImg = _userInfor.登入者帳號.ToLower() + ".jpg";

                PropertyChangedEmit("userInfor");
            }
        }

        public ObservableCollection<登入者系統> _systemCollection;
        public ObservableCollection<登入者系統> systemCollection
        {
            get { return _systemCollection; }
            set
            {
                _systemCollection = value;
                PropertyChangedEmit("systemCollection");
                
            }
        }
        



        private string _登入者帳號 { get; set; } 
        public string 登入者帳號
        {
            get { return _登入者帳號; }
            set
            {
                _登入者帳號 = value;
                PropertyChangedEmit("登入者帳號");
            }
        }

        private string _登入者姓名 { get; set; }
        public string 登入者姓名
        {
            get { return _登入者姓名; }
            set
            {
                _登入者姓名 = value;
                PropertyChangedEmit("登入者姓名");
            }
        }

        private string _部門名稱 { get; set; }
        public string 部門名稱
        {
            get { return _部門名稱; }
            set
            {
                _部門名稱 = value;
                PropertyChangedEmit("部門名稱");
            }

        }


        private string _EmpImg { get; set; }
        public string EmpImg
        {
            get { return _EmpImg; }
            set
            {
                _EmpImg = value;
                PropertyChangedEmit("EmpImg");
            }

        }






        private void PropertyChangedEmit(string columnName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(columnName));
        }
    }
}
