   M S B A M L   `   `   `  ����H  DMojaAplikacja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:MojaAplikacjaMojaAplikacja  5   	       MojaAplikacja.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:MojaAplikacja     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��800��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value�� 5
   
   %�   '��       �� 5      " ��6   .�5      ��  � ��$	 100��6*   �� 5       � ��$ 35��6+   �� 5       � ��$ 1��6-   �� 5       � ��$ 22(�6-   �� 5       � ��$ 1��60   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $	��550 �6   �� 5       � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $	��400 �6   �� 5      .+�5    
   �� $��Type of Figure��6   $��1��6)   $��0��69   $	��Top=�6F   $��Center=�5!      $��15(�61   �� 5"   
   4  .System.Windows.Automation.AutomationProperties   Name$ figuresOption��6   $��15(�5'      $��25��6$   $	��120��5(      $��1��6   $��0��6/   $��0 25 0 0q�5)      ��5$      �� *	Figures+ �� SelectedValue 5%      �� *SelectedFigure+5+      �� 5/   
   $��	Walec.JPG��6   $��Stretch=�50      $��Stretch=�51      $��1��52      $��1��53      y�54      �� *IsCylinderFigure+    BooleanToVisibilityConverter	 �� 	Converter#	 [  �� 56   
   $��1��57   �   $��440,165,10,200q�6�   $��1��6�   y�56      �� *IsCylinderFigure+#	 [  ��57   G   �� *H+
 �� UpdateSourceTrigger$
 PropertyChanged=�6�   �� 58   
   $��1��59      $��440,303,10,62q�6�   $��1��6�   y�58      �� *IsCylinderFigure+#	 [  ��59   G   �� *R+$
 PropertyChanged=�6�   �� 5:   
    �� 
IsReadOnly$
 True��5=      $��1��6$   $��175,175,175,175q�64   $��1��6M   y�5:      �� *IsCylinderFigure+#	 [  ��5<      �� *V+$
 PropertyChanged=�5=   M   �� 5A   
   $��Cube.JPG��6   $��Stretch=�5B      $��Stretch=�5C      $��1��5D      $��1��5E      y�5G   	   �� *IsCubeFigure+#	 [  �� 5J   
   $��1��5M      $��440,165,10,200q�6"   $��1��6:   y�5J      �� *IsCubeFigure+#	 [  ��5L      �� *CH+$
 PropertyChanged=�5M   :   �� 5O   
   $��1��5R      $��116,320,334,44q�6"   $��1��6:   y�5O      �� *IsCubeFigure+#	 [  ��5Q      �� *CB+$
 PropertyChanged=�5R   :   �� 5T   
   $��1��5W      $��303,355,147,10q�6"   $��1��6:   y�5T      �� *IsCubeFigure+#	 [  ��5V      �� *CA+$
 PropertyChanged=�5W   :   �� 5Y   
   $
 True��5\      $��1��6$   $��253,125,197,240q�64   $��1��6M   y�5Y      �� *IsCubeFigure+#	 [  ��5[      �� *CV+$
 PropertyChanged=�5\   M   5]      5^      