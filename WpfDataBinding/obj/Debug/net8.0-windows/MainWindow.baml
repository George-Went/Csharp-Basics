   M S B A M L   `   `   `  ����I  EWpfDataBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfDataBindingWpfDataBinding  5   	       WpfDataBinding.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfDataBinding     5   	     � Title$  
MainWindow��5   	   $	��300��6   $	��400��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��10 �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��10 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��10 �6   �� 5       $��* �6   .+�5#   
   �� $��1��6   $��1��6   $��2q�6-   $
��Name��68   �� 5$   
   $��2��6   $��1��6   $��2q�6-   $	��Age��68   �� 5%   
   $��1��6   $��2��6   $��2q�6/   ��6:   �� *Name+ �� Mode$ OneWay=��� 5&   
   $��2��6   $��2��6   $��2q�6/   ��6:   �� *Age+$ OneWay=��� 5(   
   -   5        $��3��5(      $��1��6   $
��Info��6.   6=   �� 5*   
   $��5��6   $��1��6   $��2q�6-   $��One Way��68   �� 5+   
   $��6��6   $��1��6   $��2q�6-   $��Two Way��68   �� 5,   
   $��7��6   $��1��6   $��2q�6-   $��One Way to Source��68   �� 5-   
   $��5��6   $��2��6   $��2q�6/   ��6:   �� *OneWay+$ OneWay=��� 5.   
   $��6��6   $��2��6   $��2q�6/   ��6:   �� *TwoWay+$ TwoWay=��� 5/   
   $��7��6   $��2��6   $��2q�6/   ��6:   �� *OneWaySource+$ OneWayToSource=��� 51   
   -   5        $��8��51      $��1��6   $
��Info��6.   6=   54      55      