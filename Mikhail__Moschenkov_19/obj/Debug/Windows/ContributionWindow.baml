   M S B A M L   `   `   `  ����H  DBankSystemApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:BankSystemApp.UI.ViewsBankSystemApp.UI.Views  5   	   &     BankSystemApp.ContributionWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:BankSystemApp.UI.Views     5   	     � Title$  ContributionWindow��5   	   $	��210��6$   $	��450��61   $	��450��6=   $	��210��6L    � DataContext 5	      (  "BankSystemApp.UI.Views.ViewModelCC  5
   
   -   5        VMCC��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $��3* �6   �� 5      $	��100 �6    � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      $
��312* �6   .+�5   
   �� -   5         ��Name$ 	tb_client��5      $��Center=�6'   $��5q�5      $
��Wrap=�5      $	��Top=�5      ��5      �� *Client+5      �� 5   
   -   5         ��Name$ btn_contribution��5      $��Закрепить��6+   $��Right=�5      $��	0,32,10,0q�5      $��1��5      $	��Top=�5      $��75��5      $��1��6C   ��6   �� *Contribution_btn_click+6C   �� 5    
   -   5         ��Name$ 
tb_contrib��5       $
��Left=�5!      $��23��5"      $��	10,31,0,0q�5#      $��1��5$       �� TextWrapping$
 Wrap=�5%      $	��Top=�5'      $	��120��5(      ��5&      �� *Contribution.contribut+5(      �� 5)   
   $
��Left=�6   $��	10,10,0,0q�5*      $��1��6    $
��Wrap=�5+      $��Сумма вклада:��5,      $	��Top=�5-      (  "System.Windows.Controls.DatePicker  5.   
   -   5          Name$ dp_deadLine��5.      $
��Left=�5/      $��
135,30,0,0q�50      $��1��51      $	��Top=�52      	   SelectedDate	 6%   �� *Contribution.dateEnd+�� 53   
   -   5        
 ��Name$
 cb_capitalization��53      $ ��Капитализация��6.   $
��Left=�6F   $��	10,59,0,0q�6a   $��1��6t   $	��Top=�6�    d� 	IsChecked 6�   �� *Contribution.capitalization+55      56      