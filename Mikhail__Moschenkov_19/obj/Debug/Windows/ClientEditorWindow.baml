   M S B A M L   `   `   `  ����H  DBankSystemApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:BankSystemApp.UI.ViewsBankSystemApp.UI.Views  5   	   &     BankSystemApp.ClientEditorWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:BankSystemApp.UI.Views     5   	     � Title$  ClientEditorWindow��5   	   $	��195��6$   $	��550��61   $	��195��6=   $	��550��6M   $	��195��6\   $	��550��6l    � DataContext 5	      (  "BankSystemApp.UI.Views.ViewModelCE  5
   
   -   5        VM��5
      .��5      � 
�������.+�5   
   �� -   5         ��Name$ tb_firstName��5      $
��Left=�6(   $��23��6C   $��	10,31,0,0q�6O    �� TextWrapping$
 Wrap=�6b   $	��Top=�6�   $	��120��6�   ��6v   �� *Client.firstName+6�   �� 5   
   -   5        $ tb_lastName��5      $
��Left=�6'   $��23��6B   $��
135,31,0,0q�6N   $
 Wrap=�6b   $	��Top=�6�   $	��120��6�   ��6v   �� *Client.lastName+6�   �� 5   
   -   5        $ tb_middleName��5      $
��Left=�6)   $��23��6D   $��
260,31,0,0q�6P   $
 Wrap=�6d   $	��Top=�6�   $	��120��6�   ��6x   �� *Client.middleName+6�   �� 5   
   -   5        $ 
tb_pasport��5      $
��Left=�6&   $��23��6A   $��
385,31,0,0q�6M   $
 Wrap=�6a   $	��Top=�6�   $	��120��6�   ��6u   �� *Client.pasport+6�   �� 5   
   -   5        $ 
tb_account��5      $
��Left=�6&   $��23��6A   $��	10,79,0,0q�6M   $
 Wrap=�6`   $	��Top=�6�   $	��120��6�   ��6t   �� *Client.account+6�   �� 5   
   -   5         ��Name$ cb_IsVIP��5      $	��VIP��6%   $
��Left=�63   $��135,107,0,0q�6N   $	��Top=�6c    d� 	IsChecked 6{   �� *Client.isVip+�� 5   
   -   5        $ 
cb_IsLegal��5      $��Юр. лицо��6'   $
��Left=�6:   $��260,107,0,0q�6U   $	��Top=�6j    6�   �� *Client.isLegal+�� 5   
   -	   5         ��Name$ btn_edit��5      $��Изменить��6#   $
��Left=�66   $��115,133,0,0q�6Q   $	��Top=�6f   $	��100��6~   $y�Hidden=�6�   �� 5   
   $
��Left=�6   $��	10,10,0,0q�6/   $
��Wrap=�6B   $��Имя:��6V   $	��Top=�6b   �� 5   
   $
��Left=�6   $��
135,10,0,0q�6/   $
��Wrap=�6C   $��Фамилия:��6W   $	��Top=�6g   �� 5   
   $
��Left=�6   $��
260,10,0,0q�6/   $
��Wrap=�6C   $��Отчество:��6W   $	��Top=�6h   �� 5   
   $
��Left=�6   $��
385,10,0,0q�6/   $
��Wrap=�6C   $-��'Серия/Номер паспорта:��6W   $	��Top=�6t   �� 5   
   $
��Left=�6   $��	10,59,0,0q�6/   $
��Wrap=�6B   $��Баланс:��6V   $	��Top=�6e   �� 5   
   -
   5        $ 
btn_cancel��5      $��Отмена��6%   $
��Left=�66   $��
10,133,0,0q�6Q   $	��Top=�6e   $	��100��6}   ��6�   �� *Cancel_btn_click+�� 5   
   -   5        $ cb_isBanned��5      $��Заблокирован��6(   $
��Left=�6?   $��
10,107,0,0q�6Z   $	��Top=�6n    6�   �� *Client.isBanned+�� 5   
   -   5        $ tb_creditID��5      $
��Left=�6'   $��23��6B   $��
135,79,0,0q�6N   $
 Wrap=�6b   $	��Top=�6�   $��60��6�   ��6v   �� *Client.creditID+6�   �� 5   
   -   5        $ tb_contributionID��5      $
��Left=�6-   $��23��6H   $��
200,78,0,0q�6T   $
 Wrap=�6h   $	��Top=�6�   $��60��6�   ��6|   �� *Client.contributionID+6�   �� 5   
   $
��Left=�6   $��
135,58,0,0q�6/   $
��Wrap=�6C   $��Кредит ID:��6W   $	��Top=�6i   �� 5   
   $
��Left=�6   $��
200,57,0,0q�6/   $
��Wrap=�6C   $��Вклад ID:��6W   $	��Top=�6h   5       5!      