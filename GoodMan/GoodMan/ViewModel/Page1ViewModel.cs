using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace GoodMan.ViewModel
{
    public class Page1ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ContentPage CP { get; set; }

        private string _Name="oscar";
        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }

        public ICommand SayHi
        {
            get
            {
                return new Command(() =>
                {                   
                    CP.Navigation.PushAsync(new Pages.Page2(),true);
                });
            }

           
        }
    }
}
