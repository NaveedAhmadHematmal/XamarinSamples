using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinAnimations.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ButtonAnimation : ContentPage
    {
        public ButtonAnimation()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //Btn.FadeTo(10, 1000, Easing.BounceIn);
            await Btn.ScaleTo(1.3, 100, Easing.CubicOut);
            await Btn.ScaleTo(1, 100, Easing.CubicIn);
        }
    }
}