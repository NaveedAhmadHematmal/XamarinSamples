using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAnimations.Views;

namespace XamarinAnimations
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Animation_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ButtonAnimation());
        }

        private void Carousel_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CarouselViewPage());
        }
    }
}