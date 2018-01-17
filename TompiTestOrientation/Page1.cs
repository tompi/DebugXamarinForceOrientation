using System;
using Plugin.DeviceOrientation;
using Xamarin.Forms;

namespace TompiTestOrientation
{
    public class Page1 : ContentPage
    {
        public Page1()
        {
            var layout = new StackLayout();
            var lbl = new Label();
            lbl.Text = "Page 1";
            layout.Children.Add(lbl);

            var btn = new Button();
            btn.Text = "Rotate page";
            btn.Clicked += (sender, e) => 
            {
                //Navigation.PushAsync(new Page2());
                CrossDeviceOrientation.Current.LockOrientation(Plugin.DeviceOrientation.Abstractions.DeviceOrientations.Landscape);
            };
            layout.Children.Add(btn);

            Content = layout;
        }
    }
}
