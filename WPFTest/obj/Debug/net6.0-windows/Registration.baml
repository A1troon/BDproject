   M S B A M L   `   `   `  ����B  >WPFTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WPFTestWPFTest  5   	       WPFTest.Registration   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WPFTest     5   	     � Title$  Registration��5   	   $	��192��6   $	��390��6+   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $��20 �6   �� 5      $��20 �6   �� 5      $��20 �6   �� 5      $��20 �6   �� 5      $
��Auto �6   .+�5   
   �� Введите Логин:6$   �� 5   
   -   5        $��loginBox��5      $��1��6"   $	��250��6/   6@   �� 5   
   $��2��6   Введите пароль:62   G� 5   
   -   5        $��passwordBox��5      $��3��6)   $	��250��66   6G   � 5   
   $��4��6   $��Right=�6!   $��0,15,0,0q�6=   .+�5      �� -   5         �� 	IsDefault$
 True��5      $��60��6;   $��0,0,10,0q�6I   .��6[   OK6_   �� 5       �� IsCancel$
 True��6   $��60��6%   .��63   Отмена6;   5      5      5      