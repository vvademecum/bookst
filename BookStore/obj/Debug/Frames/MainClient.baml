   M S B A M L   `   `   `  ����D  @BookStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BookStore.FramesBookStore.Frames  5      !    BookStore.Frames.MainClient   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:BookStore.Frames     5      -   5          N� Title$  
MainClient��5	       � 	Resources 5      *   $BookStore.Frames.BookInCartConverter   BookInCartConverter��%   &	          5   
   6B   5      .��5      � .+�5   
   �� -   5        $��ProductsLstV��5       �� SelectionMode$ Single=�6'   ��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5      61   �� 5      61   �� 5      61   �� 5      61   .+�5      �� $��FullImagePath��6$   $y�	Collapsed=�6x   ��69   �� *	ImagePath+ �� StringFormat$ /Resources/Images/{0}��6�   �� 5      $	��100��6S   $	��100��6`   $��0��6l   ��6    �� *Text+ �� ElementName$ FullImagePath��6~   �� 5       �� Orientation$ Vertical=�6%   $��Center=�6<   $��1��6W   .+�5      �� ��6(   �� *Name+$ Название: {0}��6]   �� 5      ��6(   �� *Author+$ Автор: {0}��6\   �� 5       ��6(   �� *Price+$  Цена: {0} рублей��6a   5!      �� 5#      $��Center=�6%   $��2��6@   $��2��6P   .+�5$      ��  ��Name$ AdToCartBtn��6%   -   5        ��5%   "   �� 5&   &    �� 
TargetType" ��6,   .�5'   *   �� 	 �� Property	 � ��
 �� Value$	
 100��6B   6P   �� 5(   *   	 � ��$
 30��6C   6P   �� 5)   *   	 � ��

 �����6^   �� 5*   *   	 � ��

 �   �6W   �� 5+   *   	 � ��$
 15(�6E   6R   �� 5,   *   	 � ��$
 Roboto)�6G   6X   �� 5-   *   	 � ��$
 Добавить��6D   6W    �� Triggers 5/   *   �� 50   .    �� Binding 6:   �� *Id+ �� 	Converter# [   �� Value true6�   .a�51   2   �� 	 � ��$
 Добавлено��6L   6`   �� 52   2   	 � ��

 � � �6_   �� 53   2   	 � {�
 .  6^   54   /   56   '   58      59      5;      5<      ��5>      �� 5?      " ��6   .�5@      �� 	 � ��

 �����63   �� 5A      	 � ��$
 40 20q�6/   �� 5B      	 � ��$
 Stretch=�6C   5C      5E      5G      5H      