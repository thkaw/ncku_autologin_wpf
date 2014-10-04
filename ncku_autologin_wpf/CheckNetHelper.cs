using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace ncku_autologin_wpf
{
    public class CheckNetHelper : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private String netStatus;
        public String NetStatus
        {
            get { return netStatus; }

            private set
            {

                netStatus = value;

                if (PropertyChanged != null)

                    PropertyChanged(this, new PropertyChangedEventArgs("NetStatus"));

            }
        }
        DispatcherTimer timer;
        bool isSecondTick = false;
        public CheckNetHelper()
        {

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1000);

            timer.Tick += new EventHandler(timer_Tick);

            timer.Start();

        }


        private async void timer_Tick(object sender, EventArgs e)
        {
            //第二次之後都不用變更timer的Interval了
            if (!isSecondTick)
            {
                //300000 = 5miniute
                timer.Interval = TimeSpan.FromMilliseconds(300000);
            }

            await UpdateNetStatusAttribute();

            isSecondTick = true;
        }

        public async Task UpdateNetStatusAttribute()
        {
            bool result = await Check_Net_Status();

            if (result)
            {
                NetStatus = "Connection";
            }
            else
            { NetStatus = "NoConnection"; }
        }

        public async Task<bool> Check_Net_Status()
        {

            try
            {
                using (var client = new WebClient())
                using (var stream = await client.OpenReadTaskAsync("http://www.hinet.net/"))
                {
                    return true;
                }
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.ToString());
                return false;
            }
        }


    }
}
