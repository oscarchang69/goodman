using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace GoodMan.ViewModel
{
    class PersonalInforViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public PersonalInforViewModel()
        {
            DataCreated();
        }

        public ContentPage CP { get; set; }

        private string _姓名;
        public string 姓名
        {
            get { return _姓名; }
            set
            {
                if (value != _姓名)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("姓名"));
                }
                _姓名 = value;
            }
        }

        private string _性別;
        public string 性別
        {
            get { return 性別; }
            set
            {
                if (value != _性別)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("性別"));
                    _性別 = value;
                }
            }
        }

        private string _年紀;
        public string 年紀
        {
            get { return 年紀; }
            set
            {
                if (value != _年紀)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("年紀"));
                    _年紀 = value;
                }
            }
        }

        private ObservableCollection<VoAge> _ageItems;
        public ObservableCollection<VoAge> ageItems
        {
            get
            {
                return _ageItems;
            }
            set
            {
                PropertyChanged(this, new PropertyChangedEventArgs("ageItems"));
                _ageItems = value;
            }
        }

        private VoAge _SelectedAge;
        public VoAge SelectedAge
        {
            get
            {
                return _SelectedAge;
            }
            set
            {
                _SelectedAge = value;
                ShowSelectedAge = value.key;
            }
        }

        private int _ShowSelectedAge;
        public int ShowSelectedAge
        {
            get
            {
                return _ShowSelectedAge;
            }
            set
            {
                PropertyChanged(this, new PropertyChangedEventArgs("ShowSelectedAge"));
                _ShowSelectedAge = value;
            }
        }


        public ICommand Save
        {
            get
            {
                return new Command(() =>
                {
                   
                    MessagingCenter.Send(this, "MyAlertName", "My actual alert content, or an object if you want");

                });
            }
        }

        public  ICommand Alert
        {
            get
            {
                return new Command(async () =>
                {
                   await CP.DisplayAlert("注意", "透過ViewModel呼叫Alert","確定");
                });
            }
        }

        private void DataCreated()
        {
            _ageItems = new ObservableCollection<VoAge>();
            for(var i = 18; i <= 99; i++)
            {
                var obj = new VoAge()
                {
                    key = i,
                    value = i + "歲"
                };
                _ageItems.Add(obj);
            }     
        }



    }

    public class VoAge
    {
        public int key { get; set; }
        public string value { get; set; }
    }
}
