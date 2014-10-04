using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using mshtml;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;
using System.Diagnostics;
using System.Net.Sockets;
using System.Linq;
using System.Windows.Threading;

namespace ncku_autologin_wpf
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        WindowState lastWindowState;
        bool loginPage = true;
        // static SerializeHelper serializer = new SerializeHelper();

        LoginInformation info;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Init_Loading();
        }

        private void Init_Loading()
        {

            //載入一些資料進去控制項裡面
            tb_account.Text = ncku_autologin_wpf.Properties.Settings.Default.s_UserAccountSetting;
            pb_password.Password = ncku_autologin_wpf.Properties.Settings.Default.s_UserPasswordSetting;
            cb_RememberINFO.IsChecked = ncku_autologin_wpf.Properties.Settings.Default.b_RememberINFOSetting;

            //如果自動連線有被設定，則在LOAD頁面時要把允許程式最小化設定為TRUE
            cb_AutoReconnect.IsChecked = ncku_autologin_wpf.Properties.Settings.Default.b_AutoReloginSetting;
            cb_Minimize.IsChecked = ncku_autologin_wpf.Properties.Settings.Default.b_isMinimizeSetting;
            if ((bool)cb_AutoReconnect.IsChecked)
            {
                ncku_autologin_wpf.Properties.Settings.Default.b_isMinimizeSetting = true;
                cb_Minimize.IsChecked = true;
                cb_Minimize.IsEnabled = false;
            }

            IPHostEntry IPHost = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());

            IPAddress host = IPAddress.None;
            foreach (IPAddress ip in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                host = ip;
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    break;
            }


        }

        /// <summary>
        /// 這是當WINDOW右上角要按下"X"的行為
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            //如果不要儲存帳密則砍掉setting區的帳號密碼欄位
            if (!ncku_autologin_wpf.Properties.Settings.Default.b_RememberINFOSetting)
            {
                ncku_autologin_wpf.Properties.Settings.Default.s_UserAccountSetting = "";
                ncku_autologin_wpf.Properties.Settings.Default.s_UserPasswordSetting = "";
            }

            //先把表單的東西存起來
            ncku_autologin_wpf.Properties.Settings.Default.Save();

            //如果有設定最小化到SYSTEM TRAY，則縮小，否則關閉程式
            if (ncku_autologin_wpf.Properties.Settings.Default.b_isMinimizeSetting)
            {
                e.Cancel = true;
                Hide();
            }
            else
            { Close(); }
        }

        protected override void OnStateChanged(EventArgs e)
        {
            lastWindowState = WindowState;
        }

        private void cb_RememberINFO_Click(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if ((bool)cb.IsChecked)
            {
                ncku_autologin_wpf.Properties.Settings.Default.b_RememberINFOSetting = true;
            }
            else
            {
                ncku_autologin_wpf.Properties.Settings.Default.b_RememberINFOSetting = false;
            }
        }

        private void cb_AutoReconnect_Click(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if ((bool)cb.IsChecked)
            {
                ncku_autologin_wpf.Properties.Settings.Default.b_AutoReloginSetting = true;
                ncku_autologin_wpf.Properties.Settings.Default.b_isMinimizeSetting = true;
                cb_Minimize.IsChecked = true;
                cb_Minimize.IsEnabled = false;


            }
            else
            {
                ncku_autologin_wpf.Properties.Settings.Default.b_AutoReloginSetting = false;
                cb_Minimize.IsEnabled = true;
            }

        }

        private void cb_Minimize_Click(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if ((bool)cb.IsChecked)
            {
                ncku_autologin_wpf.Properties.Settings.Default.b_isMinimizeSetting = true;
            }
            else
            {
                ncku_autologin_wpf.Properties.Settings.Default.b_isMinimizeSetting = false;
            }
        }


        private void btn_login_Click(object sender, RoutedEventArgs e)
        {


            if (tb_account.Text != "" && pb_password.Password != "")
            {
                loginPage = true;

                WebNavigate();

                info = new LoginInformation();

                info.Account = tb_account.Text;
                info.Password = pb_password.Password;
                //  serializer.SerializeBinary(info);

            }
            else
            {
                MessageBox.Show("Please input NCKU Dorm account and password!");
            }

        }

        private void WebNavigate()
        {
            //學校宿網真實位置
            wb_1.Navigate("http://10.25.243.58/sys_dhcp_authcheck_content.html");

            //測試用的站台
            //wb_1.Navigate("http://www.ntex.tw/sys_dhcp_authcheck_content.html");
            wb_1.LoadCompleted += wb_1_LoadCompleted;
        }

        private async void btn_chknet_Click(object sender, RoutedEventArgs e)
        {
            CheckNetHelper chknet = new CheckNetHelper();

            if (await chknet.Check_Net_Status())
            {
                MessageBox.Show("Have Internect connection.");
            }
            else
            {
                MessageBox.Show("No Internect connection.");
            }
        }

        void wb_1_LoadCompleted(object sender, NavigationEventArgs e)
        { 
            LoginProcess();
        }

        private void LoginProcess()
        {
            if (loginPage)
            {
                try
                {

                    HTMLDocument doc = (HTMLDocument)wb_1.Document;

                    IHTMLElementCollection theElementCollection = doc.getElementsByTagName("input");

                    IHTMLElementCollection theLoginButton = doc.getElementsByName("Login");
                    int i = 0;

                    foreach (IHTMLElement currentElement in theElementCollection)
                    {
                        switch (i)
                        {
                            case 1:
                                currentElement.innerText = info.Account;
                                break;

                            case 2:
                                currentElement.innerText = info.Password;
                                break;
                            case 3:
                                //  currentElement.onclick();
                                foreach (IHTMLElement currentButton in theLoginButton)
                                {
                                    currentElement.onclick("document.forms[0].form_act.value = 'login';if(false==sanity_check()) {return false;} document.forms[0].submit();");
                                }
                                break;
                            default:
                                break;
                        }


                        i++;
                    }

                    loginPage = false;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }


        /////////////Menu part
        private void OnMenuItemAboutClick(object sender, EventArgs e)
        {
            MessageBox.Show("Nathaniel Chen @ NCKU CSIE, www.ntex.tw");
        }


        private void OnNotificationAreaIconDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                Open();
            }
        }

        private void OnMenuItemOpenClick(object sender, EventArgs e)
        {
            Open();
        }

        private void Open()
        {
            Show();
            WindowState = lastWindowState;
        }

        private void OnMenuItemExitClick(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_account_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ncku_autologin_wpf.Properties.Settings.Default.b_RememberINFOSetting == true)
            {
                TextBox tb = sender as TextBox;
                ncku_autologin_wpf.Properties.Settings.Default.s_UserAccountSetting = tb.Text;
            }
        }

        private void pb_password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (ncku_autologin_wpf.Properties.Settings.Default.b_RememberINFOSetting == true)
            {
                PasswordBox pb = sender as PasswordBox;
                ncku_autologin_wpf.Properties.Settings.Default.s_UserPasswordSetting = pb.Password;
            }
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {

            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void cb_AutoReconnect_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)cb_AutoReconnect.IsChecked)
            { StartMonitor(); }
            else
            { StopMonitor(); }
        }

        private void StopMonitor()
        {
            timer.Tick -= timer_Tick;
            timer.Stop();
        }

        DispatcherTimer timer = new DispatcherTimer();
        public void StartMonitor()
        {

            //1 minute
            timer.Interval = TimeSpan.FromMilliseconds(60000);

            timer.Tick += new EventHandler(timer_Tick);

            timer.Start();

        }

        private async void timer_Tick(object sender, EventArgs e)
        {
            CheckNetHelper chknet = new CheckNetHelper();

            if (!await chknet.Check_Net_Status())
            {
                WebNavigate();
            }
        }



    }
}
