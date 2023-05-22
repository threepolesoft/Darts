using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Darts.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class sp : ContentPage
    {
        public sp()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await image.TranslateTo(0, 50, 500);    // Move image left
            await image.TranslateTo(0, -100, 500); // Move image diagonally up and left

            await image.TranslateTo(0, 50, 500);    // Move image left

           Application.Current.MainPage = new AppShell();
        }
    }
}