using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Threading.Tasks;
using ZXing.Mobile;

using GoodMan.Droid.DS;
using GoodMan.DS;
using Xamarin.Forms;

[assembly: Dependency(typeof(QrCodeScanningService))]
namespace GoodMan.Droid.DS
{
    public class QrCodeScanningService:GoodMan.DS.IQrCodeScanningService

    {
        public async Task<string> ScanAsync()
        {
            var scanner = new ZXing.Mobile.MobileBarcodeScanner();
            var scanResults = await scanner.Scan();
            return scanResults != null ? scanResults.Text : "";
        }
    }
}