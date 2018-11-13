using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GoodMan.DS
{
    public interface IQrCodeScanningService
    {
        Task<string> ScanAsync();
    }
}
