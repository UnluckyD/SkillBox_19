   M S B A M L   `   `   `  ����H  DBankSystemApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:BankSystemApp.UI.Views.DataBaseViews$BankSystemApp.UI.Views.DataBaseViews  5      8    2BankSystemApp.UI.Views.DataBaseViews.AddClientView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Dlocal2clr-namespace:BankSystemApp.UI.Views.DataBaseViews     5        � DataContext  5	      =  7BankSystemApp.UI.Views.DataBaseViews.AddClientViewModel  5
   
   .��5      � .+�5   
   �� -   5         ��Name$ tb_name��5      $
��Left=�6#   $��23��6>   $��	10,31,0,0q�5       �� TextWrapping$
 Wrap=�6%   $	��Top=�6[   $	��120��6s   ��5   J   �� *darkMod.brushForeground+��5   9   �� *Client.firstName+6s   �� 5   
   -   5        $ tb_lastName��5      $
��Left=�6'   $��23��6B   $��
135,31,0,0q�5      $
 Wrap=�6&   $	��Top=�6[   $	��120��6s   ��5   N   �� *darkMod.brushForeground+��5   :   �� *Client.lastName+6s   �� 5   
   -   5        $ tb_middleName��5      $
��Left=�5      $��23��5      $��
260,31,0,0q�6*   $
 Wrap=�5      $	��Top=�6U   $	��120��6m   ��5   >   �� *darkMod.brushForeground+��5   2   �� *Client.middleName+6m   �� 5   
   -   5        $ 
tb_pasport��5      $
��Left=�5      $��23��5      $��
385,31,0,0q�6*   $
 Wrap=�5      $	��Top=�5      $	��120��66   ��5   >   �� *darkMod.brushForeground+��5   2   �� *Client.pasport+5   6   �� 5   
   -   5        $ 
tb_account��5      $
��Left=�5      $��23��5      $��	10,79,0,0q�6*   $
 Wrap=�5      $	��Top=�5      $	��120��66   ��5   =   �� *darkMod.brushForeground+��5   2   �� *Client.account+5   6   �� 5   
   -   5         ��Name$ cb_IsVIP��5      $	��VIP��6%   $
��Left=�63   $��
260,81,0,0q�5       $	��Top=�6'   ��5   N   �� *darkMod.brushForeground+ d� 	IsChecked 5    ?   �� *Client.isVip+�� 5!   
   -   5        $ 
cb_IsLegal��5!      $��Юр. лицо��6'   $
��Left=�6:   $��
385,81,0,0q�5"      $	��Top=�6'   ��5!   U   �� *darkMod.brushForeground+ 5"   ?   �� *Client.isLegal+�� 5#   
   -   5         ��Name$ btn_add��5#      $��Добавить��6"   $��Right=�65   $��10q�6Q   $��75��6]   $��20��6h   $��Bottom=�6t   ��6�   �� *AddClient_btn+�� 5$   
   $
��Left=�6   $��	10,10,0,0q�6/   $
��Wrap=�6B   $��Имя:��5%      $	��Top=�6    ��5$   V   �� *darkMod.brushForeground+5%       �� 5&   
   $
��Left=�6   $��
135,10,0,0q�6/   $
��Wrap=�6C   $��Фамилия:��5'      $	��Top=�6$   ��5&   W   �� *darkMod.brushForeground+5'   $   �� 5(   
   $
��Left=�6   $��
260,10,0,0q�6/   $
��Wrap=�6C   $��Отчество:��5)      $	��Top=�6%   ��5(   W   �� *darkMod.brushForeground+5)   %   �� 5*   
   $
��Left=�6   $��
385,10,0,0q�6/   $
��Wrap=�6C   $-��'Серия/Номер паспорта:��5+      $	��Top=�61   ��5*   W   �� *darkMod.brushForeground+5+   1   �� 5,   
   $
��Left=�6   $��	10,59,0,0q�6/   $
��Wrap=�6B   $��Баланс:��5-      $	��Top=�6#   ��5,   V   �� *darkMod.brushForeground+5-   #   5.      5/      