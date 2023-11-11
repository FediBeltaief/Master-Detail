using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Master_Detail
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void GoToPage1(Object sender,EventArgs e)
        {
            Navigation.PushAsync(new P1());
        }
        public void GoToPage2(Object sender, EventArgs e)
        {
            Navigation.PushAsync(new P2());
        }
        public void GoToPage3(Object sender, EventArgs e)
        {
            Navigation.PushAsync(new P3());
        }
    }
}
