   M S B A M L   `   `   `  ����A  =Boerse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BoerseBoerse  5   	       Boerse.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Boerse     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	      )  #System.Windows.Controls.DataGridRow �� 
TargetType �� Property �� Value   
BaseButton �� BasedOn  ver��%S  '        &	  H     &	 �     7   �� 5
   
   "  6   .�5      ��  � ��$ 25��6'   5      �� 5   
   " ��6   .�5      ��  � ��
 �� ��6+   �� 5       � ��
 ��ح�6+   �� 5       � ��$ SemiBold"�6+   5      �� 5   
   " ��6   8   .�5      ��  � ��
 � � �6+   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      .+�5   
   �� $��0��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   $��25��6N   $��0 0 20 0q�6Z   .+�5      �� $��Mein Capital: ��6   $
��Bold"�62   $��Center=�6D   �� 5      $
��1000��6   
���  �� �� Padding$ 10 0 0 0q�69   $��18(�6L   5       � 5!      .+�5"      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 AktienTable��5"      $��1��60   
   AutoGenerateColumns
 .     Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$ Aktie��6-      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6X   �� *Name+  5%      $ Im Depot��6-    . $ 65 6Q    6\   �� *Anzahl+  5&      $ Preis��6-    . $ 50 6N    6Y   �� *
StartPreis+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�4  .System.Windows.Controls.DataGridTemplateColumn  5'      $ Anzahl��61   $	 100 6A      CellTemplate 5(      �� 5)   "   .R�5*   &   �  � ColumnDefinitions 5+   *   �� 5,   .   �� 5-   .   $��2* �6?   .+�5/   *   ��  ��Name$ AnzahlKaufen��6B   $��0��62   6B   �� 50   *    ��Name$ 	KaufenBtn��6R   -   5        $��1��50   1   $��Kaufen��6A   #��[  6�   51   '   52   #   54        55      $ Anzahl��61   $	 100 6A    56      �� 57   "   .R�58   &   �  59   *   �� 5:   .   �� 5;   .   $��2* �6?   .+�5=   *   �� $ AnzahlVerkaufen��6B   $��0��62   6B   �� 5>   *   $ VerkaufenBtn��6U   -   5        $��1��5>   1   $��	Verkaufen��6A   #��[ 6�   5?   '   5@   #   5B      5D      5E      5F      � 5H   
   $��1��6   .+�5I      �� -   5         ��Name$ MeineAktienList��5I      .@�5J      �� .R�5K      �� $ 
Horizontal=�6!   .+�5L      �� ��6$   �� *Name+�� 5M      ��6$   �� *Anzahl+5N      5O      5P      5Q      5R      5S      