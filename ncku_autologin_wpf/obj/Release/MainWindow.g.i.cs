﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1254F0890866AF76F66BB891204A0AC7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using ncku_autologin_wpf;


namespace ncku_autologin_wpf {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WebBrowser wb_1;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_account;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pb_password;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cb_RememberINFO;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cb_AutoReconnect;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cb_Minimize;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_login;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_chknet;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar pb_Prgress;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_NetworkStatus;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_CurrentIP;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_CurrentTime;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ncku_autologin_wpf;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 6 "..\..\MainWindow.xaml"
            ((ncku_autologin_wpf.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.wb_1 = ((System.Windows.Controls.WebBrowser)(target));
            return;
            case 3:
            this.tb_account = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\MainWindow.xaml"
            this.tb_account.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_account_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.pb_password = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 54 "..\..\MainWindow.xaml"
            this.pb_password.PasswordChanged += new System.Windows.RoutedEventHandler(this.pb_password_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cb_RememberINFO = ((System.Windows.Controls.CheckBox)(target));
            
            #line 60 "..\..\MainWindow.xaml"
            this.cb_RememberINFO.Click += new System.Windows.RoutedEventHandler(this.cb_RememberINFO_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cb_AutoReconnect = ((System.Windows.Controls.CheckBox)(target));
            
            #line 61 "..\..\MainWindow.xaml"
            this.cb_AutoReconnect.Click += new System.Windows.RoutedEventHandler(this.cb_AutoReconnect_Click);
            
            #line default
            #line hidden
            
            #line 61 "..\..\MainWindow.xaml"
            this.cb_AutoReconnect.Checked += new System.Windows.RoutedEventHandler(this.cb_AutoReconnect_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cb_Minimize = ((System.Windows.Controls.CheckBox)(target));
            
            #line 64 "..\..\MainWindow.xaml"
            this.cb_Minimize.Click += new System.Windows.RoutedEventHandler(this.cb_Minimize_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_login = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\MainWindow.xaml"
            this.btn_login.Click += new System.Windows.RoutedEventHandler(this.btn_login_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_chknet = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\MainWindow.xaml"
            this.btn_chknet.Click += new System.Windows.RoutedEventHandler(this.btn_chknet_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.pb_Prgress = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 11:
            
            #line 86 "..\..\MainWindow.xaml"
            ((System.Windows.Forms.MenuItem)(target)).Click += new System.EventHandler(this.OnMenuItemAboutClick);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 88 "..\..\MainWindow.xaml"
            ((System.Windows.Forms.MenuItem)(target)).Click += new System.EventHandler(this.OnMenuItemOpenClick);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 90 "..\..\MainWindow.xaml"
            ((System.Windows.Forms.MenuItem)(target)).Click += new System.EventHandler(this.OnMenuItemExitClick);
            
            #line default
            #line hidden
            return;
            case 14:
            this.tb_NetworkStatus = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 15:
            this.tb_CurrentIP = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 16:
            this.tb_CurrentTime = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 17:
            
            #line 137 "..\..\MainWindow.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).RequestNavigate += new System.Windows.Navigation.RequestNavigateEventHandler(this.Hyperlink_RequestNavigate);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
