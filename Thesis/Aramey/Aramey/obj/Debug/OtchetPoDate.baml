   M S B A M L   `   `   `  ����A  =Aramey, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ArameyAramey  5   	       Aramey.OtchetPoDate   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Aramey     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � Title$  
Отчет��5	   	   $	��450��6   $	��727��6$   .��5
      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ техникаDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��10,76,10,107q�6      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6g   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        названиеColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Название��5   Z      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6l   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Название+6l     5      -   5        стоимостьColumn��$ Стоимость��5   \   $ SizeToHeader 6o    6>   �� *Стоимость+6o   4  .System.Windows.Controls.DataGridTemplateColumn  5      -   5         времяЗаписиColumn��$ Время Записи��5   D   $ SizeToHeader 6Z   	   CellTemplate	 5      �� 5      .R�5      (  "System.Windows.Controls.DatePicker  
   SelectedDate
 6)   �� *ВремяЗаписи+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 5      5        5      -   5        поставщикColumn��$ Поставщик��5   \   $ SizeToHeader 6o    6>   �� *Поставщик+6o     5      -   5        количествоColumn��$ Количество��5   ^   $ SizeToHeader 6r    6?   �� *Количество+6r   5      �� 5   
   -   5        $��
Назад��5      $
��Left=�6!   $��
10,354,0,0q�6<   $	��Top=�6P   $	��143��6h   6t     5   
   -	   5          Name$	 one��5      $
��Left=�6"   $��
282,10,0,0q�6=   $	��Top=�6Q   $	��144��6i   6u     5   
   -
   5        $	 two��5      $
��Left=�6"   $��
282,43,0,0q�6=   $	��Top=�6Q   $	��146��6i   6u   �� 5   
   $��от:��6   $
��Left=�6   $��
244,12,0,0q�69   $	��Top=�6M   $��Arial Black)�6e   �� 5   
   $��до:��6   $
��Left=�6   $��
244,49,0,0q�69   $	��Top=�6M   $��Arial Black)�6e   �� 5   
   -   5        $��Создать отчет��5      $
��Left=�6)   $��
503,27,0,0q�6D   $	��Top=�6X   $	��177��6p   6|   %  MaterialDesignThemes.Wpf.Badged  5!   
   $��Badged��6    $��842,225,0,0q�61   5#      5$      