   M S B A M L   `   `   `  ����A  =Aramey, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ArameyAramey  5   	       Aramey.DeletePostav   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Aramey     5   	   -   5          � Title$+  %Удаление потавщиков��5   	   $	��450��6%   $��542.152��62    � WindowStartupLocation$ CenterScreen=�6B    � 	Resources 5	          Aramey.АрамейDataSet   арамейDataSet   поставщикViewSource �� Source �� Source��%c   &	        &	      7     5
   
   6   �� 5   
    6;   �� *Поставщик+8   5      .��5      �  � DataContext# [ 6   
�������.+�5   
   �� $)��#Список поставщиков��6   $
��Left=�6-   $��0,-2,0,0q�6H   $	��Top=�6Z   $��48(�6r   $��Segoe UI Black)�6�   $	��653��6�   �� 5   
   -   5         ��Name$
 Back��5   !   $��
Назад��6   $��10,70,274,0q�6/   $	��Top=�6D   6\   �� 5   
   -   5        $	 Del��5   #   $��Удалить��6   $
��Left=�60   $��
274,70,0,0q�6K   $	��Top=�6_   $	��250��6w   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$  поставщикDataGrid��5         AutoGenerateColumns .  	   EnableRowVirtualization	 . $��10,107,10,10q�6�   
   RowDetailsVisibilityMode$
 VisibleWhenSelected=�6�   ��6i   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        названиеColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Название��5   Z      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6l   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Название+6l     5      -   5        ВидТехникиColumn��$ Вид Техники��5   ^   $ SizeToHeader 6s    6?   �� *ВидТехники+6s     5      -   5        АдресColumn��$ 
Адрес��5   T   $ SizeToHeader 6c    6:   �� *
Адрес+6c     5      -   5        $ НомерТелефонаColumn��$! Номер Телефона��5   d   $ SizeToHeader 6|    6B   �� *НомерТелефона+6|   5      5      5      