   M S B A M L   `   `   `  ����G  CWPF_Commands, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WPF_CommandsWPF_Commands  5   	       WPF_Commands.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WPF_Commands     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ 
MainWindow��5	   	   $	��450��6   $	��800��6)    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$
 Open��5      6Q     5   
   -   5        $ local:MyCommand.Hello��5      6`   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   o� $	��Top=�6   $��25��6'   .@�5      m� $
��File��6   $��25��6%   .@�5      m�  m� Command$
 Open��6   m� 5      $ local:MyCommand.Hello��6    m� CommandParameter$ Stephan��6;   m� 5      $��open new��6   $ local:MyCommand.Hello��6-   5      5      �� 5   
   -   5        $��textBox��5      $��25��6"   $	��200��6.   $��20 40 20 10q�6:   $��0��6O   �� 5   
   $��Paste Button��6   $��Paste��6(   $��25��6f   $	��200��6r   $��20 10 20 10q�6~   $��1��6�   ��68   ��  �� ElementName$ textBox��6�   �� 5    
   $��Copy Button��6   $
��Copy��6'   $��25��6d   $	��200��6p   $��20 10 20 10q�6|   $��2��6�   ��66   �� $ textBox��6�       WPF_Commands.CommandButton  5"   
      Command$
 Open��6   	   CommandParameter$	 
Hi Stephan��6-   $��25��6K   $	��200��6W   $��3��6c   5#      5$      