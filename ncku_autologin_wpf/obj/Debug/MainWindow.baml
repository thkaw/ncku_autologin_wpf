   M S B A M L   `   `   `  ����M  Incku_autologin_wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ncku_autologin_wpfncku_autologin_wpf  5   	   [ WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms 5   	   #    ncku_autologin_wpf.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   .l clr-namespace:ncku_autologin_wpf     5   	   Rforms@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     5   	   -   5          � Title$3  -NCKU Success dorm 4 logger WPF Edition Ver1.0��5   	   $��411.826��6?   $��1047.904��6P    � 
ResizeMode$ CanMinimize=�6x    � 	Resources 5      0   *ncku_autologin_wpf.NotifyingDateTimeHelper   notifyingDate'   !ncku_autologin_wpf.CheckNetHelper  checkNet��%:   &	        &	        5	   
   6$     5
   
   6   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5#   
   � $��1��6    � ColumnDefinitions 5$      �� 5%      $	��255 �6#   �� 5&      $��* �6#   .+�5)      (  "System.Windows.Controls.WebBrowser  -   5          Name$
 wb_1��5)         Source$9 3http://10.25.243.58/sys_dhcp_authcheck_content.html?�6'   $��3��6d   $��255,0,-0.4,0.4q�6x   �� 5+      .+�5,      ��  �� Orientation$ 
Horizontal=�6   $��0,10,0,0q�66   .+�5-      �� $��Account   :��6   $��Right=�62   $	��Top=�6O   (� 5.       (� Stretch$ Uniform=�6   $��1,0,0,0q�60   .��5/      �� -   5        	 ��Name$	 
tb_account��5/   "   $��18(�66   
 �� TextWrapping$

 Wrap=�6D   $	��175��6X   6d   50      51      �� 53      $ 
Horizontal=�6   $��0,10,0,0q�66   .+�54      �� $��
Password :��6   $��Right=�61   $	��Top=�6M   (� 55      .��56      G� -   5         G�Name$ pb_password��56   &   $��18(�6;   $	��175��6I   6U   57      58      �� 5:      $ Vertical=�6   .+�5;      �� $ 
Horizontal=�6!   .+�5<      �� -   5         ��Name$ cb_RememberINFO��5<   #   $��Remeber Accout��6<   $��	10,10,0,0q�6U   6h   �� 5=      -   5        $ cb_AutoReconnect��5=   #   $��AutoReconnect��6=   $��	10,10,0,0q�6U   6�   5>      �� 5?      .+�5@      �� -   5        $ cb_Minimize��5@   #   $��Minimize when close��68   $��	10,10,0,0q�6V   6i   5A      5B      �� 5C      $��
10,15,10,2q�6   �� 5E      -   5         ��Name$ 	btn_login��5E      $��Login��6F   $��
10,15,10,0q�6V   $��Center=�6j   $��36��6�   �� 5G      -	   5        $ 
btn_chknet��5G      $��Check network��6/   $��
10,15,10,0q�6G   $��Center=�6[   $��36��6v   6�   �� 5I      $��
10,15,10,2q�6   � 5K      -
   5         �Name$ 
pb_Prgress��5K       � Value$ 0Q�62   $��16��6<   $��
10,10,10,0q�6H    � IsIndeterminate . $y�	Collapsed=�6s   5M      5O      -   'ncku_autologin_wpf.NotificationAreaIcon  5Q   
   -   'ncku_autologin_wpf.NotificationAreaIcon   MouseDoubleClick$' !OnNotificationAreaIconDoubleClick��5S         Text$ NCKU DORM LOGGER��5R      $��2��5S   L      Icon$( "Resources/NotificationAreaIcon.ico��5T      . 6A      	MenuItems 5V      #  System.Windows.Forms.MenuItem  -   5           Text$ About��5V   !   6.     5W      $ -��6!     5X      -   5        $
 Open��5X   !      DefaultItem . 6I     5Y      $ -��6!     5Z      -   5        $
 Exit��5Z   !   6-   . 5[   0   5\      ]� 5^   
   $��2��6   .+�5_      �� $��Bottom=�6   ��5`      �� 5a      .R�5b      �  5c      �� 5d   "   $��* �63   �� 5e   "   $
��Auto �63   �� 5g   "   $��* �63   �� 5i   "   $
��Auto �63   �� 5j   "   $��2* �63   �� 5k   "   $
��Auto �63   �� 5l   "   $��* �63   5n      5o      .@�5q      �� .��5r      �� $ 
Horizontal=�6!   .+�5s      �� $��Internet Status: ��6$   �� 5t      -   5         ��Name$ tb_NetworkStatus��5t   $   ��6>   ��  �� Source# [  �� Path$ 	NetStatus�5u      5v      �� 5w      $��1��6   �� 5y      $��2��6    .��5z      �� $ 
Horizontal=�6!   .+�5{      �� $��Current IP: ��6$   �� 5|      -   5        $ tb_CurrentIP��5|   $   $��192.168.1.1��6:   5}      5~      �� 5�      $��3��6   �� 5�      $��4��6    $��Center=�60   .��5�      �� $ 
Horizontal=�6!   .+�5�      �� $��CurrentTime: ��6$   �� 5�      -   5        $ tb_CurrentTime��5�   $   ��6<   �� # [  $	 Now�5�      5�      �� 5�      $��5��6   �� 5�      $��6��6    $��Center=�60   .��5�      �� -   5        $��http://www.ntex.tw/?�5�       .�6n   .�5�      �� $��Author's WebSite��6$   5�      5�      5�      5�      5�      5�      