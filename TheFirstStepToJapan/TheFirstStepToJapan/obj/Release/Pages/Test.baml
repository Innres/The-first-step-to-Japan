   M S B A M L   `   `   `  ���� N  JTheFirstStepToJapan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:TheFirstStepToJapan.PagesTheFirstStepToJapan.Pages  $    TheFirstStepToJapan.Pages.Test   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     9local'clr-namespace:TheFirstStepToJapan.Pages       N� Title$
  Test�� � 	Resources  �� 
TargetType   ABC �� Property �� Value �� EndPoint � MappingMode �� 
StartPoint � Color	 � Offset��%^  &	        �� " ��.���  � �� �� $ 0.5,1&�$ RelativeToBoundingBox=�$ 0.5,0&�.��� $ 	#FFF4F4F4��$	 0.423Q�� $ 	#FFDEDEDE��$	 0Q���  � ��$ Calibri)���  � �� �	#FF1B2452��  � ��$ 2q���  � ��$ 20(���  � ��$
 Bold"���  � ��$
 Wrap=���  �@��TextAlignment$ Center=�.��� -   
 J� Effect
 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 2Q�   Opacity$	 0.3Q� � RowDefinitions �� $��2* ��� $��3* �.+��� -    ��Name$	 fon�� J� Opacity$ 0Q�$��4��$��0q�$��6��� $��0�� � ColumnDefinitions �� $��2* ��� $��2* ��� $��2* �.+��� -    ��Name$
 text��$��20,30,20,20q�$��Calibri)�$��20(�$
��Bold"�$��Center=�$��Center=� �� TextWrapping$
 Wrap=�$	��132��$��1�����	#FF35955C �� 
IsReadOnly . � $��0��$��0�� �� $	��93* ��� $
��464* ��� $
��138* ��� $
��105* � �� $	��29* ��� $	��12* ��� $	��28* ��� $	��15* ��� $	��40* ��� $
��120* �.+��� -   $
 Back��$��
Назад��#��[  $��2,2,2,0q�$��2���� -   $	 kat��#��[  $��Катакана [?]��$��2��$��1��$��2�����	#FF2CCB50�� -   $	 hir��#��[  $��Хирагана [?]��$��2��$��4�����	#FFAE3E1D� $��1�� �� $��2* ��� $��3* ��� $��3* ��� $��2* � �� $��3* ��� $��3* ��� $��* �.+��� -   $ 
proportion��$��Calibri)�$��20(�$
��Bold"�$��Center=�$��Center=�$
 Wrap=�$7��1Правильных ответов подряд:��$��0��$��15q����	#FF1B2452 . �� -   $ b1��
 � Tag$ 1��$��Button��#��[  $��1��$��60,20,20,20q��� -	   $ b2��$ 2��$��Button��#��[  $��2��$��20,20,60,20q��� -
   $ b3��$ 3��$��Button��#��[  $��1��$��60,20,20,20q�$��1���� -   $ b4��$ 4��$��Button��#��[  $��2��$��20,20,60,20q�$��1���� -   $ f1��$��1��$
��3000q����	#7FAAAAAA|�.  ��.   J� 	AllowDrop .   � Cursor$ Arrow���� -   $ f2��$��2��$
��3000q����	#7FAAAAAA|�.  ��.   .  $ Arrow���� -   $ f3��$��1��$
��3000q�$��1�����	#7FAAAAAA|�.  ��.   .  $ Arrow���� -   $ f4��$��2��$
��3000q�$��1�����	#7FAAAAAA|�.  ��.   .  $ Arrow���� -    ��Name$	 Abc��$ 0Q�$��Katakana.jpg��$��Center=�$��Center=�$��4��$
��1000q�$��6���� -   $
 Abc2��$ 0Q�$��Hiragana.jpg��$��Center=�$��Center=�$��4��$
��1000q�$��6��