   M S B A M L   `   `   `  ����P  LWPF_CustomizedListBox, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WPF_CustomizedListBoxWPF_CustomizedListBox  5   	   &     WPF_CustomizedListBox.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:WPF_CustomizedListBox     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         ListTemplate �� Orientation  TileTemplate � RowDefinitions �� TextAlignment  	TilePanel  	ListPanel)   #WPF_CustomizedListBox.LayoutListBox �� 
TargetType �� Triggers P� Property P� Value	 �� Property
 �� Value��%�  &	        &	 �     &	 �    &	 �    '  "    7  7   7  7  �� 5   
   .R�5      �� $ 
Horizontal=�6   .+�5      �� $��/folder-1484.png��6   $��10��62   �� 5      $��3 0 0 0q�62   ��6   �� *Name+62   5      5      �� 5   
   .R�5      �  5      �� 5      $��50 �6$   �� 5      $��* �6$   .+�5      �� $��0��6   $��/folder-1484.png��6%   $��5q�6?   �� 5      $��1��6   $��3 0 0 0q�6)   $ Center=�6:   ��6Q   �� *Name+5      5      �� 5   
   .R�5       � 5!      �� 5#   
   .R�5$      �� 5%      �� 5'   
   "  6    5(      P� 5)       �@ layout$
 List=�6,   . �5*      �� 	 � ��8
   63   �� 5+      	 � ��8
  65   5,      P� 5.       �@ layout$
 Tile=�6,   . �5/      �� 	 � ��8
  63   �� 50      	 � ��8
  65   51      53      55      .��56      � .+�57   
     -   5          Name$ 	MyListBox��57       � ContextMenu 58      �� 59      .@�5:      m� -   5        $
��Tile��5:   #   61   m� 5;      -   5        $
��List��5;   #   61   5<      5@      5A      5B      