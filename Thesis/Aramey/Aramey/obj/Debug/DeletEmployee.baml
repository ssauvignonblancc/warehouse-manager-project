   M S B A M L   `   `   `  ����A  =Aramey, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ArameyAramey  5   	       Aramey.DeletEmployee   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Aramey     5   	   -   5          � Title$)  #Удаление работника��5   	   $	��450��6$   $��668.75��61    � WindowStartupLocation$ CenterScreen=�6W    � 	Resources 5	          Aramey.АрамейDataSet   арамейDataSet  приемщикViewSource �� Source �� Source��%a   &	        &	      7     5
   
   6   �� 5   
    6:   �� *Приемщик+8   5      .��5      �  � DataContext# [ 6   
�������.+�5   
   �� $9��3Список работников на складе��6   $
��Left=�66   $��0,-2,0,0q�6Q   $	��Top=�6c   $��42(�6{   $��Segoe UI Black)�6�   $	��653��6�   �� 5   
   -   5        $��Delete��5   #   $��Удалить��6   $
��Left=�61   $��
334,70,0,0q�6L   $	��Top=�6`   $	��319��6x   6�   �� 5   
   -   5         ��Name$
 Back��5   !   $��
Назад��6   $
��Left=�6/   $��	10,70,0,0q�6J   $	��Top=�6]   $	��319��6u   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ приемщикDataGrid��5         AutoGenerateColumns .  	   EnableRowVirtualization	 . $��10,107,10,10q�6�   
   RowDetailsVisibilityMode$
 VisibleWhenSelected=�6�   ��6h   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        фИОColumn��,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��5   P      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *ФИО+6]     5      -   5         времяРаботыColumn��$ Время Работы��5   `   $ SizeToHeader 6v    6@   �� *ВремяРаботы+6v     5      -   5        должностьColumn��$ Должность��5   \   $ SizeToHeader 6o    6>   �� *Должность+6o     5      -   5        стажРаботыColumn��$ Стаж Работы��5   ^   $ SizeToHeader 6s    6?   �� *СтажРаботы+6s   5      5      5      