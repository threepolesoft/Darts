using Darts.Models;
using Darts.ViewModels;
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
    public partial class Equipment : ContentPage
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void LVPlayer_ItemTapped(object sender, ItemTappedEventArgs e)
        {
           
        }
    }
}