   M S B A M L   `   `   `  ����M  IWPF_MVVM_Training9, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:WPF_MVVM_Training9.ViewModelsWPF_MVVM_Training9.ViewModels  5   	   C&clr-namespace:WPF_MVVM_Training9.ViewsWPF_MVVM_Training9.Views  5   	   &     WPF_MVVM_Training9.Views.AddUser   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;vms+clr-namespace:WPF_MVVM_Training9.ViewModels     5   	   8local&clr-namespace:WPF_MVVM_Training9.Views     5   	   -   5        $��AddUserWindow��5	   	     � Title$  AddUser��5
   	   $	��450��6   $	��400��6&    � DataContext 5      4  .WPF_MVVM_Training9.ViewModels.AddUserViewModel  5   
   .��5      � .+�5   
   �� $
��Name��6   $��25q�6   $	��Top=�6+   $
��Left=�6C   �� 5   
   $��30��6   $	��200��6   $��25, 50q�6*   $��2q�5      $	��Top=�5      $
��Left=�5      ��5      �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5   
   $��Email��6   $��25, 100q�6    $	��Top=�61   $
��Left=�6I   �� 5   
   $��30��6   $	��200��6   $��25, 125q�6*   $��2q�5      $	��Top=�5      $
��Left=�5   
   ��5      �� *Email+$ PropertyChanged=�5   
   �� 5   
   $��30��6   $	��Add��6   $��70��6+   $��Center=�5       $��Center=�63   $��5q�5!      $��25q�6   $��Bottom=�5"      $��Right=�6,   ��5      �� *AddUserCommand+��5      ��  �� ElementName$ AddUserWindow��5"   ,   5$      5%      