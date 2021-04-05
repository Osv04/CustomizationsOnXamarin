using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace CustomizationsSample.Services
{
    public interface IGetDeviceOrientation
    {
        DeviceOrientation GetDeviceOrientation();
    }
}
