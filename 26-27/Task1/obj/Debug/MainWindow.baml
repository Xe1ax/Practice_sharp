   M S B A M L   `   `   `  ����	  Task1    Task1.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Aav2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  Application��5      $	��450��6   $	��800��6&   .��5      �  � RowDefinitions 5	   
   �� 5
      $��2* �6   �� 5      $��5* �6   �� 5      $��5* �6   �� 5      $��2* �6    � ColumnDefinitions 5   
   �� 5      $��5* �6   �� 5      $��2* �6   .+�5   
   �� -   5        $��
Выход��5      $��10,10,10,10q�6!   $��3��66   $	��NaN��6C   $	��NaN��6P   $��1��6\   6l   �� 5   
   -   5        $��Добавить��5      $��10,10,10,10q�6$   $��3��69   $	��NaN��6F   $	��NaN��6S   6_   �� 5   
   -   5        $��1��5      $��Открыть��6!   $��Center=�63   $��Center=�6P   $��42��6k   $	��209��6w   6�   �� 5   
   
���   �$��1q�6%   $��10,10,10,10q�69   ._�5      �� -   5         ��Name$ 
XmlDocName��5      $�� ��6,   $��9,3,9,3q�64   $��24(�6E   $
��Bold"�6S   $��Center=�6e   5      �� 5   
   -   5         ��Name$ 
XmlDocView��5      $��
10,9,10,10q�6&   $��2��6:   $��1��6K   5      9� 5    
   $
��Left=�6   $	��100��6.   $�� ��6;   $��	10,10,0,0q�6E   $��1��6X   $	��Top=�6e   $	��197��6}   $��1��6�    9� 
IsExpanded . ��5!      � 5"      $��	0,0,0,-68q�6   .+�5#      �� $��
Найти��6   $
��Left=�6,   $	��Top=�6G   $��	10,10,0,0q�6_   �� 5$      -   5         ��Name$ SearchTextBox��5$      $��Stretch=�65   $	��Top=�6S   $��25��6k   $��	10,5,10,0q�6w   �� 5%      -   5        $��
Найти��5%      $��Center=�6-   $	��Top=�6J   $��
10,35,10,0q�6b   $��75��6v   $��25��6�   6�   �� 5&      $��Удалить��6   $
��Left=�6.   $	��Top=�6I   $��	10,65,0,0q�6a   �� 5'      -   5        $ 
DelTextBox��5'      $��Stretch=�62   $	��Top=�6P   $��25��6h   $��
10,70,10,0q�6t    �� TextWrapping$
 Wrap=�6�   ��6�   �� *SelectedItem+ �� ElementName$ 
XmlDocView���� 5(      -	   5        $��Удалить��5(      $��Center=�6/   $	��Top=�6L   $��10,100,10,0q�6d   $��75��6y   $��25��6�   6�   5)      5+      �� 5,   
   $��2��6   $��2��6"   $��571,18,0,77q�66   .+�5-      	� -
   5        	 	�Name$	 radioButton1��5-      $��	TextBlock��60   	� 5.      -   5        $	 radioButton2��5.      $��TreeView��60   	� 5/      -   5        $	 radioButton3��5/      $��ListBox��60   50      51      52      