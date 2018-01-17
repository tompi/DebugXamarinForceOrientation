using System;
using Foundation;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(TompiTestOrientation.iOS.OrientationHandlerImplementation))]
namespace TompiTestOrientation.iOS
{
    public class OrientationHandlerImplementation : IOrientationHandler
    {
        public void ForceLandscape()
        {
            UIDevice.CurrentDevice.SetValueForKey(new NSNumber((int)UIInterfaceOrientation.LandscapeLeft), new NSString("orientation"));
        }

        public void ForcePortrait()
        {
            UIDevice.CurrentDevice.SetValueForKey(new NSNumber((int)UIInterfaceOrientation.Portrait), new NSString("orientation"));
        }
    }
}
