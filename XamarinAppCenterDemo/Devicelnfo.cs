using System;
using Xamarin.Essentials;

namespace XamarinAppCenterDemo
{
    public static class Devicelnfo
    {

        public static string Manufacturer 
        {
            get
            {
                var manufacturer = DeviceInfo.Manufacturer;
                if (manufacturer == "Samsung")
                    throw new ApplicationException("Very strange error specific to platform.");
                return manufacturer;
            }
        }
    }
}
