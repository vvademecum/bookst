   M S B A M L   `   `   `  ����D  @BookStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BookStore	BookStore  5   	       BookStore.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:BookStore     5   	     � Title$  Авторизация��5   	   $	��450��6   $	��800��6*   .��5	      �  � RowDefinitions 5
   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   �� $��Логин:��6    �� TextAlignment$ Center=�6"   $��1��69   $��2��6F   $��2��6V   $��
58,0,58,64q�6j   6�   �� 5   
   -   5         ��Name$ LoginTxt��5      $��30��6$   $	��150��60   $��1��6<   $��2��6I   $��2��6Y   6o   �� 5   
   $��Пароль:��6   $ Center=�6#   $��2��6:   $��2��6G   $��2��6W   $��
58,0,58,64q�6k   6�   G� 5   
   -   5         G�Name$ PasswordTxt��5      $��30��6+   $	��150��67   $��2��6C   $��2��6P   $��2��6`   6v   �� 5!   
   -   5         ��Name$ RegistrationBtn��5!      $��Регистрация��6*      
defaultBtn#��[  6@   $��3��6p   $��2��6}   6�   �� 5"   
   -   5        $ LoginBtn��5"      $��
Войти��6#   #��[  63   $��3��6c   $��3��6p   6�   �� 5$   
   -   5        $ LoginClientBtn��5$      $$��Войти как клиент��6)   #��[  6D   $	��230��6t   $��4��6�   $��2��6�   $��2��6�   6�   5'      5(      