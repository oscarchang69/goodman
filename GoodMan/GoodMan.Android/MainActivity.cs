using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace GoodMan.Droid
{


    //[Activity(
    //    Label = "GoodMan",
    //    Icon = "@mipmap/icon",
    //    Theme = "@style/MainTheme",
    //    MainLauncher = true,
    //    ConfigurationChanges =
    //    ConfigChanges.ScreenSize | ConfigChanges.Orientation)
    //    ]


    [Activity(
        Label = "GoodMan",
        Icon = "@android:style/Theme.NoTitleBar.Fullscreen",
         Theme = "@style/MainTheme",
        MainLauncher = true,
        ConfigurationChanges =
        ConfigChanges.ScreenSize | ConfigChanges.Orientation)
        ]



    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);           

            ZXing.Mobile.MobileBarcodeScanner.Initialize(Application);

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
    }
}