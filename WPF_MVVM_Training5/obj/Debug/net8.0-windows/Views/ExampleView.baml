   M S B A M L   `   `   `  ����M  IWPF_MVVM_Training5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:WPF_MVVM_Training5.ViewsWPF_MVVM_Training5.Views  5      *    $WPF_MVVM_Training5.Views.ExampleView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:WPF_MVVM_Training5.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��24(�5      $��20q�5      $��0��5      ��5      �� *ExampleBinding+5      �� 5   
   $��24(�5      $��20q�5      $��1��5      ��5      �� *ExampleBinding+ �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��2��5      .+�5      �� $��Example��6   $��ExampleButton��5      $��20q�5      ��5   '   �� *ExampleCommand+5      �� 5      $��24(�5       $��20q�5!      ��5      �� *BindingExample+5!      5"      �� 5$   
   $��Switch��6   $��SwitchToTargetButton��5%      $��20q�5&      $��3��5'      ��5$   "   �� *SwitchToTargetCommand+5'      5(      5)      