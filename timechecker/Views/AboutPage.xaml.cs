using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace timechecker.Views
{
    public partial class AboutPage : ContentPage
    {
        private DateTime CurrentNetworkTime;
        public AboutPage()
        {
            InitializeComponent();
            funcn();
        }

        protected async void funcn()
        {

            CurrentNetworkTime = await NTPClient.GetNetworkTimeAsync();
            var x = CurrentNetworkTime.ToString().Split(' ')[1].ToString();
 
            timelbl.Text = string.Format("It is currently {0}", x);
        
        }
    }
}