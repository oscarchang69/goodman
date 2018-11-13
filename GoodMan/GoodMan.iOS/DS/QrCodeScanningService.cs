using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using GoodMan.DS;
using GoodMan.iOS.DS;
using System.Threading.Tasks;
using ZXing.Mobile;

[assembly: Dependency(typeof(QrCodeScanningService))]
namespace GoodMan.iOS.DS
{
    public class QrCodeScanningService: IQrCodeScanningService
    {
        public async Task<string> ScanAsync()
        {
            var scanner = new MobileBarcodeScanner() { CancelButtonText = "取消" };

          
          
            var scanResults = await scanner.Scan();

            if (scanResults == null)
            {
                return "";
            }
            else
            {
                return scanResults.Text;
            }

            //return scanResults.Text;
        }

        
    }
}