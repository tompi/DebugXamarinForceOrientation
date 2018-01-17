using System;
using Xamarin.Forms;

namespace TompiTestOrientation
{
    public class Page2 : ContentPage
    {
        public Page2()
        {
            
            var lbl = new Label();
            lbl.Text = "Page 2";
            Content = lbl;

        }

        protected override void OnAppearing()
        {
            // DependencyService.Get<IOrientationHandler>().ForceLandscape();
            base.OnAppearing();
        }
    }
}
