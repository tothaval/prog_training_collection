   M S B A M L   `   `   `  ����F  BMVVM_Trial3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MVVM_Trial3MVVM_Trial3  5   	   ?$clr-namespace:MVVM_Trial3.ViewModelsMVVM_Trial3.ViewModels  5   	       MVVM_Trial3.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:MVVM_Trial3     5   	   ;
ViewModels$clr-namespace:MVVM_Trial3.ViewModels     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � 	Resources 5
      )  #MVVM_Trial3.ViewModels.CarViewModel   DataContext��%   &	          5   
   6#   5      .��5      ��  �� Orientation$ Vertical=�6   .+�5   
   �� $ 
Horizontal=�6   $	��Top=�6.   .+�5      �� .��6   Customer name:6$   �� 5      $	��136��5   .   ��5      �� *Customer.Name+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors$
 True��5   .   �� 5      ��6   �� *UpdateCommand+.��67   Update6?   5      � 5       � DataContext# [  6   $��10q�5       � RowDefinitions 5      �� 5      �� 5      �� 5      .+�5       �� -   5        $��CarName��5       ��6&   �� *	Car.MyCar+$
 True��$ PropertyChanged=� =� ErrorTemplate 5!      Z�  =� ValidationAdornerSite 5"      �� 	 �� ElementName$	 AdornerSite���� 5#      -   5        $��AdornerSite��5#      $��1��6'   
���  ��$
��Bold"�5$   )   ��5#   4   �� $	 CarName��
 �� Path$2
 ,(Validation.Errors).CurrentItem.ErrorContent�5$   )   �� 5%      $��2��6   
���  ��$
��Bold"�5&   )   ��5%   !   �� $	 CarName��$2
 ,(Validation.Errors).CurrentItem.ErrorContent�5&   )   5'      5(      5)      