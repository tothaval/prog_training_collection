   M S B A M L   `   `   `  ����M  IWPF_MVVM_Training7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:WPF_MVVM_Training7.ViewsWPF_MVVM_Training7.Views  5   	   )    #WPF_MVVM_Training7.Views.DialogView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:WPF_MVVM_Training7.Views     5   	     � Title$  
DialogView��5   	   $	��450��6   $	��800��6)   .��5	      ]� .+�5
   
   �� $��Bottom=�6    �� Orientation$ 
Horizontal=�6-   $��12q�6F   $��Right=�5      .+�5      �� $��Ok��6    �� 	IsDefault$
 True��5      $
��12 6q�6&   $
��12 0q�65   ��5   "   �� *	OkCommand+5   5   �� 5      $��Cancel��6    �� IsCancel$
 True��5      $
��12 6q�6%   ��5   &   �� *CancelCommand+5   %   5      �� 5   
   $��Center=�5      $��Center=�6/   ��5      �� *	Message+ �� FallbackValue$ DIALOG_MESSAGE��5   /   5      5      