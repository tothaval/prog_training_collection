   M S B A M L   `   `   `  ����O  KWPF_CustomMainWindow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WPF_CustomMainWindowWPF_CustomMainWindow  5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'    !WPF_CustomMainWindow.ThemedWindow  �� 
TargetType   ThemedWindowStyle �� 	Resources  Key �� Color6  0WPF_CustomMainWindow.MaximizeVisibilityConverter6  0WPF_CustomMainWindow.MinimizeVisibilityConverter �� Property �� Value �� 
TargetType �� Padding �� CornerRadius �Name	 � ColumnDefinitions
 � RowDefinitions ��Name  BorderBrush  CaptionBackgroundBrush �� Orientation ��Name  MinimizeVisibilityConverter �� 	Converter  MaximizeVisibilityConverter ��Name �� Padding ��Name � Icon J� SnapsToDevicePixels �� EdgeMode �� BaselineAlignment � Title  CaptionForegroundBrush �� Triggers P� 
SourceName P� Value P� Property �� 
TargetName�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      ,local"clr-namespace:WPF_CustomMainWindow  5      %�  &	        7  7  �� 5      "    6    5   
   ���� 5      BorderBrush $ #FAAF00��62   �� 5      CaptionBackgroundBrush $ #FAAF00��6=   �� 5      CaptionForegroundBrush $ #0A0F00��6=     5      MaximizeVisibilityConverter 60     5      MinimizeVisibilityConverter 60   5      .�5   
   ��  � �� �	#98FFFFFF6'   �� 5   
    �@�AllowsTransparency$
 True��6/   �� 5   
    � ��$	 100��6&   �� 5   
    � ��$	 100��6%   �� 5   
    �@�WindowStyle$
 None=�6(   �� 5   
    � �� 5      �� 5      "   6"   PART_WindowTemplate��.R�5!      �� $ 3q�6   $��10q�6)   $ 4��65   
������ 
�����@�$��2q�5$      ._�5%      � $ PART_WindowFrame��6   	 5&      �� 5'   "   $��4 �63   �� 5(   "   $��* �63   �� 5)   "   $��4 �63   
 5+      �� 5,   "   $��4 �60   �� 5-   "   $
��Auto �60   �� 5.   "   $��* �60   �� 5/   "   $��4 �60   .+�52      �� $ PART_WindowBorderLeft��53   !   #���  52   %   $��0��54   !   $��1��55   !   $��2��6.   �� 56      $ PART_WindowBorderTopLeft��57   !   #���  56   %   $ 7��58   %   $��0��59   !   $��0��5:   !   �� 5;      $ PART_WindowBorderTop��5<   !   #���  5;   %   $��1��5=   !   $��0��5>   !   �� 5?      $ PART_WindowBorderTopRight��5@   !   #���  5?   %   $��2��5A   !   $��0��5B   !   �� 5C      $ PART_WindowBorderRight��5D   !   #���  5C   %   $��2��5E   !   $��1��5F   !   $��2��6.   �� 5G      $" PART_WindowBorderBottomRight��5H   !   #���  5G   %   $��2��5I   !   $��3��5J   !   �� 5K      $ PART_WindowBorderBottom��5L   !   #���  5K   %   $��1��5M   !   $��3��5N   !   �� 5O      $! PART_WindowBorderBottomLeft��5P   !   #���  5O   %   $��0��5Q   !   $��3��5R   !   $��2��6.   �� 5T      $ PART_WindowCaption��6%   $��1��5U   !   $��1��61   #���  5V   !   ._�5W   "   ]� $
��True��6,   .+�5X   &   �� $��Right=�61   $ 
Horizontal=�5Y   -   $��Center=�5Z   -   .+�5[   *   �� $ 5��61   $ 5q�6B   
�������$	��2 0q�5]   -   ._�5^   .   �� $&  PART_WindowCaptionMinimizeButton��65   $��  _  ��5_   -   
���   �y�5`   1   �� *
ResizeMode+8   5b   +   �� 5d   *   $ 5��61   $ 5q�6B   
�������$	��2 0q�5f   -   ._�5g   .   �� $&  PART_WindowCaptionMaximizeButton��65   $�� [ ] ��5h   -   
���   �y�5i   1   �� *
ResizeMode+8  5k   +   �� 5m   *   $ 5��61   $ 5q�6B   
�������$	��2 0q�5o   -   ._�5p   .   �� $# PART_WindowCaptionCloseButton��65   $��  X  ��5q   -   
���   �6=   5r   +   5s   '   �� 5u   &   $ PART_WindowCaptionText��60   $
��Left=�5v   ,   $��6 0 0 0q�5w   ,   $ 0q�5x   ,   �� 5y   &   $ PART_WindowCaptionIcon��6,   $��16��5z   ,   $��16��5{   ,   $��0 0 6 0q�5|   ,   #��z 5}   ,   $
 True��5~   ,   $ Aliased=�5   ,    �� 5�   &   $ Center=�6*   #�z 5�   *   #���  5�   *   5�   '   5�   #   5�      ]� 5�      $��2��6(   $��1��65   #��z��5�   (   .+�5�   "   �� 5�      5�      5�       5�      P� 5�      $ PART_WindowCaptionIcon��6"    5�   4   Z�  � ��. �5�      �� $ PART_WindowCaptionIcon��6%    � y�$ 	Collapsed=�5�   ;   �� 5�      $ PART_WindowCaptionText��6%    � ��$ 0q�5�   7   5�      5�      5�      5�      5�      