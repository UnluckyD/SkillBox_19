   M S B A M L   `   `   `  ����H  DBankSystemApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:BankSystemApp.UI.ViewsBankSystemApp.UI.Views  5   	       BankSystemApp.AddWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:BankSystemApp.UI.Views     5   	     � Title$  	AddWindow��5   	   $	��205��6   $	��550��6(   $	��205��64   $	��550��6D    � DataContext 5	      -  'BankSystemApp.UI.Views.ViewModelCreator  5
   
   -   5        VM��5
   !   .��5      � .+�5   
   �� -   5         ��Name$ tb_name��5      $
��Left=�6#   $��23��6>   $��	10,31,0,0q�6J    �� TextWrapping$
 Wrap=�6]   $	��Top=�6�   $	��120��6�   ��6q   �� *Client.firstName+6�   �� 5   
   -   5        $ tb_lastName��5      $
��Left=�6'   $��23��6B   $��
135,31,0,0q�6N   $
 Wrap=�6b   $	��Top=�6�   $	��120��6�   ��6v   �� *Client.lastName+6�   �� 5   
   -   5        $ tb_middleName��5      $
��Left=�5      $��23��5      $��
260,31,0,0q�6*   $
 Wrap=�5      $	��Top=�6U   $	��120��6m   ��62   �� *Client.middleName+6m   �� 5   
   -   5        $ 
tb_pasport��5      $
��Left=�5      $��23��5      $��
385,31,0,0q�6*   $
 Wrap=�5      $	��Top=�5      $	��120��66   ��5   2   �� *Client.pasport+5   6   �� 5   
   -   5        $ 
tb_account��5      $
��Left=�5      $��23��5      $��	10,79,0,0q�6*   $
 Wrap=�5      $	��Top=�5      $	��120��66   ��5   2   �� *Client.account+5   6   �� 5   
   -   5         ��Name$ cb_IsVIP��5      $	��VIP��6%   $
��Left=�63   $��
260,81,0,0q�6N   $	��Top=�6b    d� 	IsChecked 6z   �� *Client.isVip+�� 5   
   -   5        $ 
cb_IsLegal��5      $��Юр. лицо��6'   $
��Left=�6:   $��
385,81,0,0q�6U   $	��Top=�6i    6�   �� *Client.isLegal+�� 5   
   -	   5         ��Name$ btn_add��5      $��Добавить��6"   $
��Left=�65   $��	10,0,0,10q�6P   $��75��6c   $��20��6n   $��Bottom=�6z   ��6�   �� *AddClient_btn+�� 5    
   $
��Left=�6   $��	10,10,0,0q�6/   $
��Wrap=�6B   $��Имя:��6V   $	��Top=�6b   �� 5!   
   $
��Left=�6   $��
135,10,0,0q�6/   $
��Wrap=�6C   $��Фамилия:��6W   $	��Top=�6g   �� 5"   
   $
��Left=�6   $��
260,10,0,0q�6/   $
��Wrap=�6C   $��Отчество:��6W   $	��Top=�6h   �� 5#   
   $
��Left=�6   $��
385,10,0,0q�6/   $
��Wrap=�6C   $-��'Серия/Номер паспорта:��6W   $	��Top=�6t   �� 5$   
   $
��Left=�6   $��	10,59,0,0q�6/   $
��Wrap=�6B   $��Баланс:��6V   $	��Top=�6e   5%      5&      