   M S B A M L   `   `   `  ����C  ?Zadanie3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Zadanie3Zadanie3  5   	       Zadanie3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Zadanie3     5   	     � Title$  
MainWindow��5      $	��360��6   $	��500��6(   .��5	      � 
������� � ColumnDefinitions 5
   
   �� 5      $	��100 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      �� 5      $��0 �6   �� 5      $��76 �6   .+�5   
   �� $��Пример 3��6   $��0��5      $��1��5      $��Center=�5      $��Center=�5      $
��14.4��6/   $��19.953,7.8,119.953,7.8q�6=   $��54.094��6]   �� 5   
   $��Число:��6   $��1��5      $��0��5      $
��Left=�5       $��Center=�5!      $��
10,13,0,13q�5"      $��14��6(   $��56��64   �� 5#   
   $��Его значение:��6   $��2��5$      $��0��5%      $
��Left=�5&      $��Center=�5'      $��
10,13,0,13q�5(      $��14��6(   $��90��64   �� 5,   
   -   5         ��Name$ TextBlockAnswer��5,      $��Ответ: ��5-      $��3��5.      $��0��5/      $��2��50      $��Stretch=�51      $��Stretch=�52      $��10,10,20.667,10q�53      �� 54   
   -   5         ��Name$ 	TbNumberA��54      $��1��55      $��1��56      $��Center=�57      $
��10 0q�58      $��1q�59      �� 5:   
   -   5        $ 	TbNumberB��5:      $��2��5;      $��1��5<      $��Center=�5=      $
��10 0q�5>      $��1q�5?      �� 5B   
   $��4��6   $��0��5C      $��2��5D       �� Orientation$ 
Horizontal=�5E      $��Center=�5F      $
��61,0q�62   $	��100��6@   $��2��6L   .+�5G      �� -   5         ��Name$ BtnOK��5G      $��OK��6$   $��80��5H      $��24��6    $��3q�6,   
���   �
�������5K      5M      5N      5O      