   M S B A M L   `   `   `  ����>  :Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfWpf  5          Wpf.BuingPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:Wpf     5        N� Title$  	BuingPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      5       � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��0��6   $��0��6!   $��Count��61   $��Center=�6>   $��Center=�6[   $��20(�6v   6�   �� 5   
   $��1��6   $��0��6!   $��Type payment��61   $��Center=�6E   $��Center=�6b   $��20(�6}   6�   �� 5   
   $��2��6   $��0��6!   $��Method delivery��61   $��Center=�6H   $��Center=�6e   $��20(�6�   6�   �� 5    
   $��3��6   $��0��6!   $��Surname��61   $��Center=�6@   $��Center=�6]   $��20(�6x   6�   �� 5!   
   $��4��6   $��0��6!   $
��Name��61   $��Center=�6=   $��Center=�6Z   $��20(�6u   6�   �� 5"   
   $��5��6   $��0��6!   $��
Patronymic��61   $��Center=�6C   $��Center=�6`   $��20(�6{   6�   �� 5#   
   $��6��6   $��0��6!   $��Phone��61   $��Center=�6>   $��Center=�6[   $��20(�6v   6�   �� 5$   
   -   5        $��tblockStreet��5$   ?   $��7��6   $��0��6!   $��Street��61   $y�Hidden=�6S   $��Center=�6g   $��Center=�6�   $��20(�6�   6�   �� 5%   
   -   5        $��
tblockHome��5%   =   $��8��6   $��0��6!   $
��Home��61   $y�Hidden=�6P   $��Center=�6d   $��Center=�6�   $��20(�6�   6�   �� 5&   
   -   5        $��typePayment��5&       $��1��6   $��1��63   ��5'      �� 5(      .R�5)      �� .+�5*      �� $��Lucida Calligraphy)�6:   $��20(�6Z   ��6$   �� *Name+6j   5+      5,      5.      �� 50   
   -   5        $��methodDelivery��50       $��2��6   $��1��66   ��51      �� 52      .R�53      �� .+�54      �� $��Lucida Calligraphy)�6:   $��20(�6Z   ��6$   �� *Name+6j   55      56      58      �� 59   
   -   5         ��Name$ tbCount��59   /   $��0��6   $��1��6   6B   �� 5:   
   -   5        $ 	tbSurname��5:   /   $��3��6   $��1��6   6D   �� 5;   
   -   5        $ tbName��5;   /   $��4��6   $��1��6   6A   �� 5<   
   -   5        $ tbPatronymic��5<   /   $��5��6   $��1��6   6G   �� 5=   
   -	   5        $ tbPhone��5=   /   $��6��6   $��1��6   6B   �� 5?   
   -
   5        $ tbStreet��5?   /   $��7��6   $��1��6   $y�Hidden=�6A   6W   �� 5@   
   -   5        $ tbHome��5@   /   $��8��6   $��1��6   $y�Hidden=�6?   6U   �� 5A   
    �� Orientation$ 
Horizontal=�6   $��2��6.   $��9��6B   $��Center=�6O   .+�5B      �� -   5        $
��Back��5B      $��2��6$   $	��100��68   $��9��6D   6h   �� 5C      -   5        $��btnOk��5C   O   $��Ok��6   $��2��6"   $	��100��66   $��9��6B   6r   5D      5F      5G      