   M S B A M L   `   `   `  ����D  @BookStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BookStore	BookStore  5   	       BookStore.Registration   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:BookStore     5   	     � Title$  Registration��5   	   $	��450��6   $	��800��6+   .��5	      �  � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��Фамилия:��6    �� TextAlignment$ Center=�6$   $��1��6;   $��1��6H   $��2��6X   6n   �� 5   
   -   5         ��Name$ Surname��5         defaultInput#��[  6#   $��1��6U   $��1��6b   $��2��6r   6�   �� 5   
   $��Имя:��6   $ Center=�6    $��2��67   $��1��6D   $��2��6T   6j   �� 5    
   -   5        $
 Name��5       #��[  6    $��2��6R   $��1��6_   $��2��6o   6�   �� 5"   
   $��Отчество:��6   $ Center=�6%   $��3��6<   $��1��6I   $��2��6Y   6o   �� 5#   
   -   5        $ 
Patronymic��5#      #��[  6&   $��3��6X   $��1��6e   $��2��6u   6�   �� 5%   
   $��Логин:��6   $ Center=�6"   $��1��69   $��3��6F   $��2��6V   6l   �� 5&   
   -   5        $ Login��5&      #��[  6!   $��1��6S   $��3��6`   $��2��6p   6�   �� 5(   
   $��Пароль:��6   $ Center=�6#   $��2��6:   $��3��6G   $��2��6W   6m   G� 5)   
   -   5         G�Name$ Password��5)        	defaultPB#��[ 6(   $��2��6W   $��3��6d   $��2��6t   6�   �� 5+   
   $&�� Повторите пароль:��6   $ Center=�6-   $��3��6D   $��3��6Q   $��2��6a   6w   G� 5,   
   -   5        $ 
RePassword��5,      #��[ 6*   $��3��6Y   $��3��6f   $��2��6v   6�   �� 5.   
   -   5         ��Name$ 	GoBackBtn��5.      $��Назад!��6$   $��4��65   $��1��6B   $��2��6R     
defaultBtn#��[ 6f   6�   �� 5/   
   -   5        $ GoRegistrationBtn��5/      $��Вперед!��6,   $��4��6>   $��3��6K   $��2��6[   #��[ 6o   6�   50      51      