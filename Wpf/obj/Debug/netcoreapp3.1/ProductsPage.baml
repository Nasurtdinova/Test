   M S B A M L   `   `   `  ����>  :Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfWpf  5          Wpf.ProductsPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:Wpf     5        N� Title$  ProductsPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      6!    � RowDefinitions 5   
   �� 5      $��60 �6   5      �� 5      $	��340 �6   5      �� 5      $��70 �6   5      .+�5   
   �� $��
Поиск��6   $��20(�6!   $
��Left=�60   $��0��6K   6Z   �� 5   
   -   5        $��	txtSearch��5   ,   $��0��6   $	��200��6    $��78,6,522,14q�6a   $��40��6v   �� 5   
   -   5         ��Name$ 	manFilter��5   �   $��Right=�6   $	��200��6/   $��50��6;    �� DisplayMemberPath$
 Name��6G   6�   �� 5   
   $��Products��6   $��Lucida Calligraphy)�6$   $
��Bold"�6D   $��35(�6V   $��Center=�6d   $��Center=�6   6�   �� 5   
   -   5        $��lvUsers��5       $��1��6    �� View 5      �� 5      .P�5      ��  �� Width$	 120��6%    �� DisplayMemberBinding 61   �� *Name+��5      �� 5       -   5        
 � Tag$
 Name��5    3   .��6`   Name6f   5"      �� 5#      $	 120��6%    61   �� *Description+��5$      �� 5%      -   5        $ Description��5%   3   .��6g   Description6t   5'      �� 5)      $ 80��6%    60   �� *Price+��5*      �� 5+      -   5        $ Price��5+   3   .��6a   Price6h   5-      �� 5.      $ 80��6%    60   �� *
Activity+��5/      �� 50      -   5        $ Activity��50   3   .��6d   
Activity6n   52      �� 53      $ 80��6%    60   �� *Count+��54      �� 55      -   5        $ Count��55   3   .��6a   Count6h   57      58      5:      �� 5;   
   $��6��6   	 �� Orientation$	 
Horizontal=�6"   $��0��6;   $��2��6K   $��Center=�6_   $��Center=�6}   5=      5>      