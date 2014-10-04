using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace ncku_autologin_wpf
{
    public class NotifyingDateTimeHelper : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private DateTime _now;
        private String _now_string;

        public NotifyingDateTimeHelper()
        {

            _now = DateTime.Now;

            DispatcherTimer timer = new DispatcherTimer();

            timer.Interval = TimeSpan.FromMilliseconds(1000);

            timer.Tick += new EventHandler(timer_Tick);

            timer.Start();

        }

        public String Now
        {

            get { return _now_string; }

            private set
            {

                _now_string = value;

                if (PropertyChanged != null)

                    PropertyChanged(this, new PropertyChangedEventArgs("Now"));

            }

        }

        void timer_Tick(object sender, EventArgs e)
        {

            Now = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");

        }

    }
}
