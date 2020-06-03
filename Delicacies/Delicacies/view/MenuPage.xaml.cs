using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Delicacies.ViewModel;
using Delicacies.Model;

namespace Delicacies.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();

        }
        private Timer timer;



        protected override void OnAppearing()
        {
            //var timespan = TimeSpan.FromMilliseconds(10);

            timer = new Timer(TimeSpan.FromSeconds(5).TotalMilliseconds)
            { Enabled = true, AutoReset = true, };

            timer.Elapsed += TimerElapsed;
            base.OnAppearing();
        }
        protected override void OnDisappearing()
        {
            timer?.Dispose();
            base.OnDisappearing();
            
        }

        public void TimerElapsed(object sender,ElapsedEventArgs e)
        {
            Device.BeginInvokeOnMainThread(
                () =>
                {
                    if (ItemBanner.Position == 2)
                    {
                        ItemBanner.Position = 0;
                        return;
                    }

                    ItemBanner.Position += 1;


                });
        }

       
    }
}
        
        
    
