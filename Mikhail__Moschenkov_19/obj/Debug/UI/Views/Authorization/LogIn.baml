   M S B A M L   `   `   `  ����H  DBankSystemApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:BankSystemApp.UI.Views.Authorization$BankSystemApp.UI.Views.Authorization  5      C&clr-namespace:BankSystemApp.ComponentsBankSystemApp.Components  5   W   0    *BankSystemApp.UI.Views.Authorization.LogIn   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Dlocal2clr-namespace:BankSystemApp.UI.Views.Authorization     5      M IFontAwesome.Sharp, Version=5.15.3.0, Culture=neutral, PublicKeyToken=nullFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5      7
components&clr-namespace:BankSystemApp.Components  6W     � DataContext  5
      9  3BankSystemApp.UI.Views.Authorization.LoginViewModel  5   
   .��5      � .+�5   
   �� $��Login��6   $��5q�6P   $
��Left=�5      $	��Top=�6/   ��5   !   �� *darkMod.brushForeground+5   /   �� 5   
   $
��5,30q�6   $	��250��6    $
��Left=�5      $	��Top=�6/   ��5   ,   �� *Login+5   /   �� 5   
   $��Password��6   $
��5,55q�6S   $
��Left=�5      $	��Top=�6/   ��5   $   �� *darkMod.brushForeground+5   /   2   ,BankSystemApp.Components.BindablePasswordBox  5   
   $
��5,75q�6)   $	��250��67   $
��Left=�5   )   $	��Top=�6D      Password 5   )   �� *
Password+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=��� 5   
   $
��Left=�6   $��30��5      $��90��6   $��160,100q�5      $��1��5      $	��Top=�5   5   ��5      Z� ��6'   Z� ��5      �� *LogIn_btn_click+.��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      !  FontAwesome.Sharp.IconBlock  $��1,2,0,0q�6   $��30��5       �� Padding$ 3q�6*   �  �FontAwesome.Sharp.IconBlockBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=5.15.3.0, Culture=neutral, PublicKeyToken=null]]   Icon$ Keycdn=�5       $��18(�6-   $
��Left=�5"      ��5!      �� *dMod.brushForeground+5"      �� 5#      $	��1,4q�6o   ��6   �� *currentLanguage.Enter+��6C   �� *dMod.brushForeground+6o   5$      5%      5&      5'      