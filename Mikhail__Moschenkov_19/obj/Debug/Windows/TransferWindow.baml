   M S B A M L   `   `   `  ����H  DBankSystemApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:BankSystemApp.UI.ViewsBankSystemApp.UI.Views  5   	   "    BankSystemApp.TransferWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:BankSystemApp.UI.Views     5   	     � Title$  TransferWindow��5   	   $	��450��6    $	��800��6-    � DataContext 5	      +   %BankSystemApp.UI.Views.ViewModelClass  5
   
   -   5        VM��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $
��370* �6   .+�5   
   �� $��0,5,0,0q�6   $��1��6&   .@�5      �� $��Клиенты��6   .��5      � ���	#FFE5E5E5$��0q�6.    � ColumnDefinitions 5      �� 5      $
��691* �6+   �� 5      $	��105 �6+   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid_client��5      $��10,10,4.911,10q�5         AutoGenerateColumns .     
IsReadOnly . ��5      �� *model.Clients+ �� SelectedItem 5      �� *Client+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Фамилия��61   
   
IsReadOnly
 . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *
lastName+6_     5       $	 Имя��61   
 .  6>   �� *	firstName+6\     5!      $	 Очество��61   
 .  6B   �� *
middleName+6a     5"      $.	 (Серия/номер парспорта��61   
 .  6P   �� *	pasport+6l     5#      $	 Номер счёта��61   
 .  6F   �� *accountNumber+6h     5$      $	 Счёт��61   
 .  6?   �� *	account+6[   4  .System.Windows.Controls.DataGridCheckBoxColumn  5%      $		 VIP��65   
 .   6B   �� *isVip+6\     5&      $	 Блок��65   
 .   6C   �� *
isBanned+6`   5(      �� 5)      -   5         ��Name$ transfer_btn��5)      $��1��63   $��Right=�6C   $��0,0,5,10q�6_   $��Bottom=�6q   $��90��6�   $��70��6�   ��6�   �� *Transfer_btn_click+��5*      �� 5+      $��75��5,   (   $��5q�5-   (   $:��4Перевести на выбранный счёт.��5.   (   $��Center=�5/   (   $��Center=�50   (   $
��None=�51   (   $
��Wrap=�52   (   54      �� 55      -   5         ��Name$ transfer_sum��55      $��1��64   $��Right=�6D   $��23��6`   $��	0,0,10,85q�6l    �� TextWrapping$
 Wrap=�6   $��Bottom=�6�   $��85��6�   ��6�   �� *TransferAmount+6�   �� 56      $��1��6    $��Right=�60   $��
0,0,56,113q�6L   $
��Wrap=�6`   $��Сумма:��6t   $��Bottom=�6�   57      58      59      �� 5:   
   -   5         ��Name$ tb_clientInfo��5:      $��Center=�6+   $��10q�6H   $
��Wrap=�6T   $	��Top=�6�   $��16��6�   ��6h   �� *Client+6�   5;      5<      