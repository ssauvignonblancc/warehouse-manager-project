   M S B A M L   `   `   `  ����A  =Aramey, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ArameyAramey  5   	       Aramey.ListEmployee   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Aramey     5   	   -   5          � Title$'  !Список работников��5   	   $	��450��6#   $	��800��60    � WindowStartupLocation$ CenterScreen=�6<    � 	Resources 5	          Aramey.АрамейDataSet   арамейDataSet  приемщикViewSource �� Source �� Source��%a   &	        &	      7     5
   
   6   �� 5   
    6:   �� *Приемщик+8   5      .��5      �  � DataContext# [ 6   .+�5   
   �� $4��.Список работников склада��6   $
��Left=�63   $��	68,10,0,0q�6N   $	��Top=�6a   $��48(�6y   $��Segoe UI Black)�6�   �� 5   
   -   5         ��Name$
 Back��5      $��
Назад��6   $
��Left=�6/   $��	10,87,0,0q�6J   $	��Top=�6]   $	��772��6u   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ приемщикDataGrid��5         AutoGenerateColumns .  	   EnableRowVirtualization	 . $��10,181,10,10q�6�   
   RowDetailsVisibilityMode$
 VisibleWhenSelected=�6�   ��6h   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        фИОColumn��,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��5   Q      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6^   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *ФИО+6^     5      -   5         времяРаботыColumn��$ Время Работы��5   `   $ SizeToHeader 6v    6@   �� *ВремяРаботы+6v     5      -   5        должностьColumn��$ Должность��5   \   $ SizeToHeader 6o    6>   �� *Должность+6o     5      -   5        стажРаботыColumn��$ Стаж Работы��5   ^   $ SizeToHeader 6s    6?   �� *СтажРаботы+6s   5      �� 5   
   -   5         ��Name$ 
TextSearch��5      $
��Left=�6&   $��26��6A   $��572,138,0,0q�6M    �� TextWrapping$
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��120��6�   �� 5   
   -	   5        $ Search��5      $��
Поиск��6!   $
��Left=�61   $��707,132,0,0q�6L   $	��Top=�6a   $��75��6y   ���	#DD000000��6�   Z� 6�   5      5      