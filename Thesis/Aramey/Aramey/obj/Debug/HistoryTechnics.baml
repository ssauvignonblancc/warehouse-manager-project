   M S B A M L   `   `   `  ����A  =Aramey, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ArameyAramey  5   	       Aramey.HistoryTechnics   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Aramey     5   	   -   5          � Title$#  История техники��5   	   $	��450��6!   $	��712��6.    � WindowStartupLocation$ CenterScreen=�6Q    � 	Resources 5	          Aramey.АрамейDataSet   арамейDataSet , (историяПоставокViewSource �� Source �� Source��%o   &	        &	      7     5
   
   6   �� 5   
    6A   �� * ИсторияПоставок+8   5      .��5      �  � DataContext# [ 6   .+�5   
   �� -   5        $��
Назад��5      $
��Left=�6!   $��	10,87,0,0q�6<   $	��Top=�6O   $	��685��6g   6s   �� 5   
   $5��/История техники на складе��6   $
��Left=�64   $��	10,10,0,0q�6O   $	��Top=�6b   $��Segoe UI Black)�6z   $��48(�6�   �� 5   
   $��от:��6   $
��Left=�6   $��
10,336,0,0q�69   $	��Top=�6M   $��Segoe UI Black)�6e   $��30(�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��H_picker��5      $
��Left=�6%   $��
97,349,0,0q�6@   $	��Top=�6T   $	��184��6l   $��35��6x   �� 5   
   -   5         ��Name$ Search��5      $��
Найти��6!   $
��Left=�61   $��353,349,0,0q�6L   $	��Top=�6a   $	��148��6y   $��35��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$, &историяПоставокDataGrid��5         AutoGenerateColumns .  	   EnableRowVirtualization	 . $��10,136,10,83q�6�   
   RowDetailsVisibilityMode$
 VisibleWhenSelected=�6�   ��6o   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        названиеColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Название��5   Z      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6l   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Название+6l     5      -   5        стоимостьColumn��$  Стоимость, руб��5   \   $ SizeToHeader 6t    6>   �� *Стоимость+6t     5      -   5        поставщикColumn��$ Поставщик��5   \   $ SizeToHeader 6o    6>   �� *Поставщик+6o     5      -	   5        количествоColumn��$$ Количество, штук��5   ^   $ SizeToHeader 6x    6?   �� *Количество+6x   4  .System.Windows.Controls.DataGridTemplateColumn  5      -
   5         времяЗаписиColumn��$ Время Записи��5   D   $ SizeToHeader 6Z      CellTemplate 5      �� 5      .R�5           SelectedDate 6)   �� *ВремяЗаписи+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 5      5      5!      5#      5$      