   M S B A M L   `   `   `  ����A  =Aramey, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ArameyAramey  5   	       Aramey.ListTechnics   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Aramey     5   	   -   5          � Title$!  Список техники��5   	   $	��450��6    $	��692��6-    � WindowStartupLocation$ CenterScreen=�69   ��6u   Z�  � 	Resources 5	          Aramey.АрамейDataSet   арамейDataSet  техникаViewSource �� Source �� Source��%_   &	        &	      7     5
   
   6   �� 5   
    69   �� *Техника+8   5      .��5      �  � DataContext# [ 6   
�������.+�5   
   �� $3��-Список техники на складе��6   $
��Left=�63   $��
12,-2,-2,0q�6N   $	��Top=�6b   $��48(�6z   $��Segoe UI Black)�6�   $	��674��6�   �� 5   
   -   5         ��Name$ LoadBD_Copy��5   !   $��
Назад��6   $
��Left=�66   $��	28,70,0,0q�6Q   $	��Top=�6d   $	��323��6|   6�   �� 5   
   -   5         ��Name$ 
TextSearch��5      $
��Left=�6&   $��26��6A   $��464,130,0,0q�6M    �� TextWrapping$
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��120��6�   �� 5   
   -   5        $ Search��5      $��
Поиск��6!   $
��Left=�61   $��599,124,0,0q�6L   $	��Top=�6a   $��75��6y   ���	#DD000000��6�   Z� 6�   �� 5   
   -   5        $��Продать��5      $
��Left=�6#   $��
368,70,0,0q�6>   $	��Top=�6R   $	��291��6j   	 � Cursor$
	 Hand��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        
  Name$
 техникаDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��10,173,10,10q�6      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6g   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        названиеColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Название��5   Z      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6l   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Название+6l     5      -   5        стоимостьColumn��$  Стоимость, руб��5   \   $ SizeToHeader 6t    6>   �� *Стоимость+6t   4  .System.Windows.Controls.DataGridTemplateColumn  5      -	   5         времяЗаписиColumn��$ Время Записи��5   D   $ SizeToHeader 6Z      CellTemplate 5      �� 5      .R�5      (  "System.Windows.Controls.DatePicker     SelectedDate 6)   �� *ВремяЗаписи+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 5      5        5      -
   5        поставщикColumn��$ Поставщик��5   \   $ SizeToHeader 6o    6>   �� *Поставщик+6o     5      -   5        количествоColumn��$$ Количество, штук��5   ^   $ SizeToHeader 6x    6?   �� *Количество+6x   5!      �� 5"   
   -   5        $ count��5"      $
��Left=�6!   $
 Wrap=�6<   $�� ��6P   $	��Top=�6X   $	��120��6p   $	 IBeam��6|   $��
28,128,0,0q�6�   5$      5%      