   M S B A M L   `   `   `  ����S  OWPF_MVVM_Training6_Login, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:WPF_MVVM_Training6_Login.Components#WPF_MVVM_Training6_Login.Components  5      7    1WPF_MVVM_Training6_Login.Components.NavigationBar   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:WPF_MVVM_Training6_Login.Components     5        � 	Resources  5	       �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value    BooleanToVisibilityConverter��%  '��       &	  �    �� 5
   
   " ��6   .�5      ��  � ��
 ���� 6+   �� 5       � ��
 �����6+   �� 5       � ��$ 0q�60   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6$   5      5       5      P� 5       �@J�IsMouseOver$
 True��61   . �5      ��  � �� 5      �� 5      " ��6.   .R�5   "   �� #��z��6,   $��	Underline{�6M   5      5      5      5!      �� 5"   
   6'   5#      .��5$      � $
��1000��6   $��20 10q�6   
���\\�� � ColumnDefinitions 5%   
   �� 5&      $��* �6   �� 5'      $
��auto �6   �� 5(      $
��auto �6   �� 5)      $
��auto �6   �� 5*      $
��auto �6   �� 5+      $
��auto �6   .+�5.   
   �� $��0��5/      $��14(�50      
�������$��Navigation Demo��52      �� 54   
   $��1��55      $��10 0 0 0q�56      $
��Home��58      ��57      �� *NavigateHomeCommand+58      �� 5:   
   $��2��5;      $��10 0 0 0q�5<      $��People��5>      ��5=      �� *NavigatePeopleListingCommand+5>      �� 5@   
   $��3��5A      $��10 0 0 0q�5B      $��Login��5D      ��5C      �� *NavigateLoginCommand+5D      �� 5F   
   $��4��5G      $��10 0 0 0q�5H      $��Account��5J      ��5I      �� *NavigateAccountCommand+y�5K      �� *
IsLoggedIn+	 �� 	Converter#	 [  �� 5M   
   $��5��5N      $��10 0 0 0q�5O      $��Logout��5Q      ��5P      �� *LogoutCommand+y�5R      �� *
IsLoggedIn+#	 [  5S      5T      