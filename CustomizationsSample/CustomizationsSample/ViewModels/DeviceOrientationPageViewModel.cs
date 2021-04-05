using CustomizationsSample.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace CustomizationsSample.ViewModels
{
    public class DeviceOrientationPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public const string Text = "You device orientation is";
        public string Message { get; set; }
        public DeviceOrientationPageViewModel()
        {
            DeviceOrientation orientation = DependencyService.Get<IGetDeviceOrientation>().GetDeviceOrientation();
            if (orientation == DeviceOrientation.Portrait)
            {
                Message = $"{Text} Portrait";
            }

            else if (orientation == DeviceOrientation.Landscape)
            {
                Message = $"{Text} Landscape";
            }
        }


    }
}
