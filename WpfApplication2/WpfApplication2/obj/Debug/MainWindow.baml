   M S B A M L   `   `   `  ����J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2  5   	        WpfApplication2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   /localclr-namespace:WpfApplication2     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5      � -   5        $��grid1��5       � RowDefinitions 5   
   �� 5      �� 5	      �� 5
      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��Center=�6   $��Center=�6-   .��6H   资源支持6N   �� 5   
   -   5        $��resourceBtn��5   :   $��1��6   $��0��6!   $��15q�6.      MyBrush#���   6M   .��6t   金色按钮6z   �� 5   
   $��Center=�6   $��Center=�6-   $��0��6H   $��2��6U   .��6e   样式支持6k   �� 5   
   -   5        $��styleBtn��5   :   $��3��6   $��0��6!   $��15q�6.     GreenButtonStyle#��[ 6J   .��6t   绿色按钮6z   �� 5   
   $��Center=�6   $��Center=�6-   $��1��6H   $��0��6U   .��6e   动画支持6k   �� 5   
   -   5        $��antimationBtn��5   :   $��1��6   $��1��6   $��15q�6.   ��5      �� 5      -   5        	AnimBrush��5   "    � Triggers 5      :� 5       :� RoutedEvent$ Button.Loaded��6   .[�5       �� .��5!      �� .��5"      ��  �� 
TargetName$ 	AnimBrush��6-    �� TargetProperty$ (SolidColorBrush.Color)�6O    �� From$	 RedX�6�   	 �� To$ GreenX�6�   	 g� Duration$	 0:0:5D�6�   
 g� AutoReverse
 .  g� RepeatBehavior$ Forever��6�   5#      5$      5%      .��5&      动画按钮5'      �� 5)   
   $��Center=�6   $��Center=�6-   $��1��6H   $��2��6U   .��6e   数据绑定支持6m   �� 5*   
   -   5        $��
BindingBtn��5*   :   $��1��6   $��3��6   $��15q�6.   ��6L   ��   MyDataSource �� Source# [  �� Path$ 	ColorName�.��6�   我被绑定成红色6�   �� 5,   
   $��Center=�6   $��Center=�6-   $��2��6H   $��0��6U   .��6e   属性继承支持6m   �� 5-   
   -   5        $��FontSizeWinBtn��5-   :   $��2��6   $��1��6   $��15q�6.   .��6m   设置窗口字体:166x   �� 5.   
   -   5        $��FontSizeBtn��5.   :   $��2��6   $��2��6   $��15q�6.   .��6g   设置按钮字体:86q   �� 5/   
   -	   5        $��ResetFontSizeBtn��5/   :   $��2��6   $��3��6   $��15q�6.   .��6q   重置字体6w   !   WpfApplication2.SpaceButton  51   
   -
   5          Name$ btnSpace��51   9   !   WpfApplication2.SpaceButton   Click$ btnSpace_Click��6n   $��3��6   $��0��6)   $��15q�6K      Text$# 设置按钮字符空格：2��6W   6�     52   
   -   5        $ winSpace��52   9   $ winSpace_Click��6n   $��3��6   $��1��6)   $��15q�6K   $# 设置窗口字符空格：2��6W   6�   53      54      