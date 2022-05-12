using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DependService
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BatteryDemo : ContentPage
    {
        public BatteryDemo()
        {
            InitializeComponent();
            
            baterryButton.Clicked += (sender, e) =>
            {
                var bat = DependencyService.Get<IBattery>();

                switch (bat.PowerSource)
                {
                    case PowerSource.Battery:
                        baterryButton.Text = "Battery - ";
                        break;
                    case PowerSource.Ac:
                        baterryButton.Text = "AC - ";
                        break;
                    case PowerSource.Usb:
                        baterryButton.Text = "USB - ";
                        break;
                    case PowerSource.Wireless:
                        baterryButton.Text = "Wireless - ";
                        break;
                    case PowerSource.Other:
                    default:
                        baterryButton.Text = "Unknown - ";
                        break;
                }
                switch (bat.Status)
                {
                    case BatteryStatus.Charging:
                        Resources["basicStyle"] = Resources["chargingStyle"];
                        baterryButton.Text += "Charging";
                        break;
                    case BatteryStatus.Discharging:
                        Resources["basicStyle"] = Resources["dischargingStyle"];
                        baterryButton.Text += "Discharging";
                        break;
                    case BatteryStatus.NotCharging:
                        Resources["basicStyle"] = Resources["notchargingStyle"];
                        baterryButton.Text += "Not Charging";
                        break;
                    case BatteryStatus.Full:
                        Resources["basicStyle"] = Resources["fullStyle"];
                        baterryButton.Text += "Full";
                        break;
                    case BatteryStatus.Unknown:
                    default:
                        Resources["basicStyle"] = Resources["unknownStyle"];
                        baterryButton.Text += "Unknown";
                        break;
                }
            };
        }
    }
}