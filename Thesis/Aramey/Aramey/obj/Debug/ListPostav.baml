   M S B A M L   `   `   `  ����A  =Aramey, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ArameyAramey  5   	       Aramey.ListPostav   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Aramey     5   	   -   5          � Title$  Поставщики��5   	   $��430.176��6   $��508.152��6-    � WindowStartupLocation$ CenterScreen=�6=    � 	Resources 5	          Aramey.АрамейDataSet   арамейDataSet   поставщикViewSource �� Source �� Source��%c   &	        &	      7     5
   
   6   �� 5   
    6;   �� *Поставщик+8   5      .��5      �  � DataContext# [ 6   $��0,0,50,0q�6>   .+�5   
   �� $��Поставщики��6   $
��Left=�6%   $��	91,10,0,0q�6@   $	��Top=�6S   $��48(�6k   $��Segoe UI Black)�6y   �� 5   
   -   5        $��
Назад��5      $
��Left=�6!   $��10,82,-32,0q�6<   $	��Top=�6Q   $	��463��6i   6u   �� 5   
   -   5         ��Name$ 
TextSearch��5      $
��Left=�6&   $��26��6A   $��258,141,0,0q�6M    �� TextWrapping$
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��120��6�   �� 5   
   -   5         ��Name$ Search��5      $��
Поиск��6!   $
��Left=�61   $��398,135,-32,0q�6L   $	��Top=�6c   $��75��6{   ���	#DD000000��6�   Z� 6�   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$ 	 поставщикDataGrid��5      
   AutoGenerateColumns
 .     EnableRowVirtualization . $��10,189,-32,10q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6i   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        названиеColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Название��5   Z      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6l   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Название+6l     5      -   5        ВидТехникиColumn��$ Вид Техники��5   ^   $ SizeToHeader 6s    6?   �� *ВидТехники+6s     5      -   5        АдресColumn��$ 
Адрес��5   T   $ SizeToHeader 6c    6:   �� *
Адрес+6c     5      -	   5        $ НомерТелефонаColumn��$! Номер Телефона��5   d   $ SizeToHeader 6|    6B   �� *НомерТелефона+6|   5      5      5      