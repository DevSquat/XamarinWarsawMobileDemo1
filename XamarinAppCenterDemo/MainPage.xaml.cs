using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using Microsoft.AppCenter;

namespace XamarinAppCenterDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GetDeviceInfo_Clicked(object sender, EventArgs e)
        {
            Model.Text = DeviceInfo.Model;
            Manufacturer.Text = Devicelnfo.Manufacturer;
            Name.Text = DeviceInfo.Name;
            VersionString.Text = DeviceInfo.VersionString;
            Platform.Text = DeviceInfo.Platform.ToString();
            Idiom.Text = DeviceInfo.Idiom.ToString();
            DeviceTypeSpan.Text = DeviceInfo.DeviceType.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            throw new Exception("It crashed :(");
        }
    }
}
