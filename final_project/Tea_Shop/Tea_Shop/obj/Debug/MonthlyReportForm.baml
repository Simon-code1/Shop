   M S B A M L   `   `   `  ����C  ?Tea_Shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:DemoWPFDemoWPF  5   	       DemoWPF.MonthlyReportForm   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:DemoWPF     5   	     � Title$  MonthlyReportForm��5   	   $��378.8��6#   $��379.2��62   ���#04c582.��5	      � .+�5   
   �� $��Monthly Report��6   $
��Left=�6)   $	��Top=�6D   $��93,0,0,0q�6\   $��24(�6n   
�������6|   �� 5   
   $��
From Date:��6   $
��Left=�6%   $	��Top=�6@    J� RenderTransformOrigin$ 
1.76,4.867&�6X   $��	10,58,0,0q�6{   
�������6�   (  "System.Windows.Controls.DatePicker  5      $
��Left=�6   $��
101,58,0,0q�6*   $	��Top=�6>   $	��120��6V   �� 5      $��To Date:��6
   $
��Left=�6   $	��Top=�68   $ 
1.76,4.867&�6P   $��
10,103,0,0q�6s   
�������6�     5      $
��Left=�6   $��101,103,0,0q�6*   $	��Top=�6?   $	��120��6W   �� 5      $��Total Revenue:��6
   $
��Left=�6#   $	��Top=�6>   $ 
1.76,4.867&�6V   $��
10,148,0,0q�6y   
�������6�   �� 5      -   5         ��Name$ txt_TotalRevenue��5      $
��Left=�6&   $��23��6A    �� TextWrapping$
 Wrap=�6M   $	��Top=�6a   $	��120��6y   $��101,151,0,0q�6�   ���#545d5a
�������6�   �� 5   
   -   5         ��Name$ 
btn_Search��5      $��Search��6%   $
��Left=�66   $	��Top=�6Q   $��75��6i   $��265,151,0,0q�6t   $��23��6�   $ 0.933,0.696&�6�      btnBlue#��[  6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
DataGrid_1��5      $
��Left=�6'   $	��114��6B   $	��Top=�6O   $	��353��6g   $��
10,188,0,0q�6s   6�   �� 5   
   -   5        $ btn_Exit��5      $
��Exit��6#   $
��Left=�62   $	��Top=�6M   $��75��6e   $��146,317,0,0q�6p   $��23��6�   $ 0.933,0.696&�6�   #��[  6�   5      5      