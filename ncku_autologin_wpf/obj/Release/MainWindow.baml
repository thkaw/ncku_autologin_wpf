   M S B A M L   `   `   `  ���� M  Incku_autologin_wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ncku_autologin_wpfncku_autologin_wpf  [ WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms #    ncku_autologin_wpf.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     .l clr-namespace:ncku_autologin_wpf     Rforms@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     -     � Title$3  -NCKU Success dorm 4 logger WPF Edition Ver1.0��$��411.826��$��1047.904�� � 
ResizeMode$ CanMinimize=� � 	Resources 0   *ncku_autologin_wpf.NotifyingDateTimeHelper   notifyingDate'   !ncku_autologin_wpf.CheckNetHelper  checkNet��%   &	        &	          .���  � RowDefinitions �� $
��auto ��� $��* ��� $
��auto �.+�� $��1�� � ColumnDefinitions �� $	��255 ��� $��* �.+�(  "System.Windows.Controls.WebBrowser  -     Name$
 wb_1��   Source$9 3http://10.25.243.58/sys_dhcp_authcheck_content.html?�$��3��$��255,0,-0.4,0.4q��� .+���  �� Orientation$ 
Horizontal=�$��0,10,0,0q�.+��� $��Account   :��$��Right=�$	��Top=�(�  (� Stretch$ Uniform=�$��1,0,0,0q�.���� -   	 ��Name$	 
tb_account��$��18(�
 �� TextWrapping$

 Wrap=�$	��175���� $ 
Horizontal=�$��0,10,0,0q�.+��� $��
Password :��$��Right=�$	��Top=�(� .��G� -    G�Name$ pb_password��$��18(�$	��175���� $ Vertical=�.+��� $ 
Horizontal=�.+��� -    ��Name$ cb_RememberINFO��$��Remeber Accout��$��	10,10,0,0q��� -   $ cb_AutoReconnect��$��AutoReconnect��$��	10,10,0,0q��� .+��� -   $ cb_Minimize��$��Minimize when close��$��	10,10,0,0q��� $��
10,15,10,2q��� -    ��Name$ 	btn_login��$��Login��$��
10,15,10,0q�$��Center=�$��36���� -	   $ 
btn_chknet��$��Check network��$��
10,15,10,0q�$��Center=�$��36���� $��
10,15,10,2q�� -
    �Name$ 
pb_Prgress�� � Value$ 0Q�$��16��$��
10,10,10,0q� � IsIndeterminate . $y�	Collapsed=�-   'ncku_autologin_wpf.NotificationAreaIcon  -   'ncku_autologin_wpf.NotificationAreaIcon   MouseDoubleClick$' !OnNotificationAreaIconDoubleClick��   Text$ NCKU DORM LOGGER��$��2��   Icon$( "Resources/NotificationAreaIcon.ico��.    	MenuItems #  System.Windows.Forms.MenuItem  -      Text$ About��  $ -��  -   $
 Open��   DefaultItem .   $ -��  -   $
 Exit��. ]� $��2��.+��� $��Bottom=����� .R��  �� $��* ��� $
��Auto ��� $��* ��� $
��Auto ��� $��2* ��� $
��Auto ��� $��* �.@��� .���� $ 
Horizontal=�.+��� $��Internet Status: ���� -    ��Name$ tb_NetworkStatus������  �� Source# [  �� Path$ 	NetStatus��� $��1���� $��2��.���� $ 
Horizontal=�.+��� $��Current IP: ���� -   $ tb_CurrentIP��$��192.168.1.1���� $��3���� $��4��$��Center=�.���� $ 
Horizontal=�.+��� $��CurrentTime: ���� -   $ tb_CurrentTime������ # [  $	 Now��� $��5���� $��6��$��Center=�.���� -   $��http://www.ntex.tw/?�.�.��� $��Author's WebSite��