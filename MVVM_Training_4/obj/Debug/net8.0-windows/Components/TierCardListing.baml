   M S B A M L   `   `   `  ����J  FMVVM_Training_4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:MVVM_Training_4.ComponentsMVVM_Training_4.Components  5      0    *MVVM_Training_4.Components.TierCardListing   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?
components(clr-namespace:MVVM_Training_4.Components     5      .��5	      �   � ColumnDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   )   #MVVM_Training_4.Components.TierCard  )   #MVVM_Training_4.Components.TierCard   	JoinClick$ OnJoinBasicClick��5         Description$ The most basic tier.��5         RectangleFill$ Yellow��5      $��0��5         Header 5      �� 5      $��Basic��6   $��24(�5      5        5   
   $ OnJoinProClick��5      $ The hightened tier.��5      $ Green��5      $��1��5       5       �� 5!      $	��Pro��6   $��24(�5"      5$        5&   
   $ OnJoinEnterpriseClick��5)      $ The enterprise tier.��5&      $
 Blue��5'      $��2��5(       5*      �� 5+       �� Orientation$ 
Horizontal=�6   .+�5,      �� $��
Enterprise��6    $��24(�5-      �� 5.      $��/Resources/siegel.png��6   $��30��5/      $��30��50      $��10 0 0 0q�51      52      54      55      56      