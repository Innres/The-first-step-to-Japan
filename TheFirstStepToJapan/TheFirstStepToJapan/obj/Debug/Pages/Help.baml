   M S B A M L   `   `   `  ����^  ZПервый шаг к Японии, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:TheFirstStepToJapan.PagesTheFirstStepToJapan.Pages  5      $    TheFirstStepToJapan.Pages.Help   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:TheFirstStepToJapan.Pages     5        N� Title$
  Help��5	       � 	Resources 5       �� 
TargetType   ABC �� Property �� Value �� EndPoint � MappingMode �� 
StartPoint � Color	 � Offset��%9  &	        �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      $ 0.5,1&�6*   $ RelativeToBoundingBox=�6;   $ 0.5,0&�6_   .��5      � $ 	#FFF4F4F4��6'   $	 0.423Q�69   � 5      $ 	#FFDEDEDE��6'   $	 0Q�69   5      5      �� 5       � ��$ Calibri)�6+   �� 5       � �� �	#FF1B24526+   �� 5       � ��$ 2q�6'   �� 5       � ��$ 20(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��$
 Wrap=�67   �� 5       �@��TextAlignment$ Center=�68   5      5      .��5       � -   5        
 �Name$

 grid��5        J� Effect 5!   
   3  -System.Windows.Media.Effects.DropShadowEffect  5"         
BlurRadius$ 2Q�6      Opacity$	 0.3Q�6.    � RowDefinitions 5$   
   �� 5%      $	��41* �6   �� 5&      $
��408* �6   �� 5'      $
��110* �6   �� 5(      $	��41* �6    � ColumnDefinitions 5*   
   �� 5+      $	��93* �6   �� 5,      $
��307* �6   �� 5-      $
��307* �6   �� 5.      $	��93* �6   .+�51   
   �� -   5         ��Name$	 fon��52      {�.  J� Opacity$ 0Q�54      $��4��55      $��0q�56      $��3��57      5:      �� 5=   
   -   5        $
 Back��5?      $��
Назад��5>      $��0��5@      $��0��5A      #��[  5C      �� 5F   
   -   5        $	 hir��5I      $��	15,2,30,2q�5G      $��Хирагана��5H      $��2��5J      $��2��5K      #��[  5M      �� 5P   
   -   5        $	 kat��5S      $��	30,2,15,2q�5Q      $��Катакана��5R      $��1��5T      $��2��5U      #��[  5W      �� 5Z   
   -   5         ��Name$
 text��5[      $#��Горячие клавиши��5\       �� TextWrapping$
 Wrap=�5]      $��1��5^      $��1��5_      $��30q�5`      $��15q�5a      $��Calibri)�5b      $��20(�5c      $
��Bold"�5d      $
��Left=�5e      $��Center=�5f      ���	#FF1B2452 �� 
IsReadOnly . $��2��5h      �� 5l   
   -   5         ��Name$ 	fon_black��5m      $��0��5n      $��0��5o      $��10��5q      $��10��5r      $��0��5t      $��0��5u      
���   ���5|      �� 5}       �� Color$ Black��6"    �� Opacity$	 0.3Q�60   5      �� 5�   
   -   5         ��Name$	 Abc��5�      $ 0Q�5�      $��Katakana.jpg��5�      $��Center=�5�      $��Center=�5�      $��4��5�      $
��1000q�5�      $��6��5�      �� 5�   
   -	   5        $
 Abc2��5�      $ 0Q�5�      $��Hiragana.jpg��5�      $��Center=�5�      $��Center=�5�      $��4��5�      $
��1000q�5�      $��6��5�      5�      5�      