   M S B A M L   `   `   `  ����O  KRoomReservation_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:RoomReservation_MVVM.ViewsRoomReservation_MVVM.Views  5      P LLoadingSpinnerControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null\Bclr-namespace:LoadingSpinnerControl;assembly=LoadingSpinnerControlLoadingSpinnerControl 5      4    .RoomReservation_MVVM.Views.MakeReservationView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:RoomReservation_MVVM.Views     5      UcustomBclr-namespace:LoadingSpinnerControl;assembly=LoadingSpinnerControl     5        � 	Resources  5
          BooleanToVisibilityConverter��%   &	        �� 5   
   6'   5      .��5      �  � IsSharedSizeScope$
 True��6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��5       
 Header#��[ 5      $��Make Reservation��5      � 5   
   $��1��6   $��0,25,0,0q�6    5      �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5"      �� $��0��6   $��Username��6%   �� 5#      $��1��5$      $��0,5,0,0q�5%      4  .System.Windows.Automation.AutomationProperties   AutomationId$$ MakeReservationUsernameTextBox��5&      ��5'      �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�5(      � 5*   
   $��2��6   $��0,10,0,0q�6    5+      �� 5,      $
��auto �6    �� 5-      $
��auto �6     � ColumnDefinitions 5/      �� 50      $
��auto �6#    z� SharedSizeGroup$ FirstColumn��60   �� 51      $
��auto �6#   $ SecondColumn��60   .+�54      �� $��0��55      $��0��56      $��	Floor No.��57      �� 58      $��1��59      $��0��5:      $��0,5,0,0q�5;      $' !MakeReservationFloorNumberTextBox��5<      ��5=      �� *FloorNumber+$ PropertyChanged=��� 5?      $��0��5@      $��1��5A      $��10,0,0,0q�5B      $��Room No.��5C      �� 5D      $��1��5E      $��1��5F      $��10,5,0,0q�5G      $&  MakeReservationRoomNumberTextBox��5H      ��5I      �� *
RoomNumber+$ PropertyChanged=�5J      � 5L   
   $��3��6   $��0,10,0,0q�6    5M      �� 5N      $
��auto �6    �� 5O      $
��auto �6     5Q      �� 5R      $
��auto �6#   $ FirstColumn��60   �� 5S      $
��auto �6#   $ SecondColumn��60   .+�5V      �� $��0��5W      $��0��5X      $��
Start Date��5Y      (  "System.Windows.Controls.DatePicker  5Z      $��1��5[      $��0��5\      $��0,5,0,0q�5]      $$ MakeReservationStartDatePicker��5^         SelectedDate 5_      �� *	StartDate+$ PropertyChanged=��� 5a      $��0��5b      $��1��5c      $��10,0,0,0q�5d      $��End Date��5e        5f      $��1��5g      $��1��5h      $��10,5,0,0q�5i      $" MakeReservationEndDatePicker��5j       5k      �� *	EndDate+$ PropertyChanged=�" �� ValidatesOnNotifyDataErrors$
 True��5l      �� 5n   
   $��4��5o      $��0,25,0,0q�5p      	 �� Orientation$	 
Horizontal=�5q      .+�5r      �� $! MakeReservationSubmitButton��5s      $��Submit��5u      ��5t      �� *SubmitCommand+5u      �� 5v      $��10,0,0,0q�5w      $��Cancel��5y      ��5x      �� *CancelCommand+��5z      �� 5{      
 �� BasedOn#
 [B��6    �� 
TargetType" ��6G    �� Triggers 5|      �� 5}       �� Binding 6*   �� *IsSubmitting+ �� Value True6K   .a�5~   "   ��  �� Property � {� �� Value$ False��6>   5      5�      5�      *  $LoadingSpinnerControl.LoadingSpinner  5�      $��10,0,0,0q�5�      $��Center=�5�         Diameter$ 25Q�5�         	Thickness$ 3Q�5�         Color
 �   �   	IsLoading 5�      �� *IsSubmitting+5�      5�      �� 5�   
   $��5��5�      $��0,20,0,0q�5�      $' !MakeReservationSubmitErrorMessage��5�      
���  ����5�      �� *SubmitErrorMessage+y�5�      �� *HasSubmitErrorMessage+ �� 	Converter# [  5�      5�      