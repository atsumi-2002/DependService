using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DependService.Services
{
    public interface IQrScanService
    {
        Task<string> ScanAsync();
    }
}
