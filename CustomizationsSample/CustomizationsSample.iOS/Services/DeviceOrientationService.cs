using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomizationsSample.iOS.Services;
using CustomizationsSample.Services;
using Foundation;
using UIKit;
using Xamarin.Forms.Internals;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceOrientationService))]
namespace CustomizationsSample.iOS.Services
{
    public class DeviceOrientationService : IGetDeviceOrientation
    {
        public DeviceOrientation GetDeviceOrientation()
        {
            UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;

            bool isPortrait = orientation == UIInterfaceOrientation.Portrait ||
                orientation == UIInterfaceOrientation.PortraitUpsideDown;
            return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
        }
    }
}