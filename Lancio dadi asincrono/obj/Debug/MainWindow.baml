   M S B A M L   `   `   `  ����P  LLancio dadi asincrono, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Lancio_dadi_asincronoLancio_dadi_asincrono  5   	   &     Lancio_dadi_asincrono.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Lancio_dadi_asincrono     5   	     � Title$  Estrazione dadi��5   	   $	��450��6!   $	��800��6.   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��1.5* �6    � RowDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Center=�6   $
��Wrap=�61   $)��#Programma per l'estrazione dei dadi��6E   $	��Top=�6p   $��36(�6�   $��3��6�   �� 5   
   -   5         ��Name$
 img1��5      $	��100��6   $	��100��6+   $
��Fill=�67   $��0��6F   $��1��6V   $��Right=�6c   �� 5   
   -   5        $
 img2��5      $	��100��6   $	��100��6+   $
��Fill=�67   $��1��6F   $��1��6V   �� 5   
   -   5         ��Name$ 	btnEstrai��5      $��Estrai��6$   $	��105��65   $��64��6A   $��2��6e   $��1��6u   �� 5   
   -   5        $
 img3��5      $	��100��6   $	��100��6+   $
��Fill=�67   $��0��6F   $��2��6V   $��Right=�6c   �� 5   
   -   5        $
 img4��5      $	��100��6   $	��100��6+   $
��Fill=�67   $��1��6F   $��2��6V   �� 5   
   -   5         ��Name$ lblPiu��5      $��+��6    $��72(�6,   $	��130��6:   $
��Left=�6G   $��1��6b   $��2��6r   �� 5    
   -   5        $ 	lblUguale��5       $��=��6#   $��Right=�6/   $��72(�6K   $	��130��6Y   $��1��6f   $��2��6v   �� 5!   
   -   5        $ lblRisultato��5!      $�� ��6&   $
��Left=�61   $��Center=�6L   $��72(�6g   $��2��6u   $��2��6�   $	��130��6�   5$      5%      