   M S B A M L   `   `   `  ����M  IWPF_MVVM_Training7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:WPF_MVVM_Training7.ViewsWPF_MVVM_Training7.Views  5      M+clr-namespace:WPF_MVVM_Training7.ViewModelsWPF_MVVM_Training7.ViewModels  5      (    "WPF_MVVM_Training7.Views.LoginView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:WPF_MVVM_Training7.Views     5      B
viewmodels+clr-namespace:WPF_MVVM_Training7.ViewModels     5        � DataContext  5
      2  ,WPF_MVVM_Training7.ViewModels.LoginViewModel  5   
   .��5      ��  �� Orientation$ Vertical=�6   .+�5   
   �� $��Login��6   $��25(�5      $��Center=�5      $	��Top=�5      $
��Bold"�5       �� Padding$ 10q�5      � 5   
   $��Center=�6   $��Center=�5       � RowDefinitions 5      �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    .+�5      �� $��	User Name��6   $��0��5      $
��0 15q�5       $
��Left=�5!      �� 5"      $��1��6   $	��0 5q�5#      $	��255��5$      $
��Left=�5%      ��5&      �� *
UserName+ �� UpdateSourceTrigger$ PropertyChanged=��� 5(      $��Password��6   $��2��5)      $
��0 15q�5*      $
��Left=�5+      �� 5-      $��3��6   $	��0 5q�5.      $	��255��5/      $
��Left=�50      ��51      �� *
Password+$ PropertyChanged=�52      �� 53   
   -   5         ��Name$ LoginBtn��53      $��Login��56      
�������
���   �$
��0 25q�59      $��35��5:      $	��250��5;      ��54      �� *LoginCommand+��55      �� *
UserName+5;      5=      5>      