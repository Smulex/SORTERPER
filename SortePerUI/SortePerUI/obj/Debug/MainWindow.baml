   M S B A M L   `   `   `  ����E  ASortePerUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SortePerUI
SortePerUI  5   	       SortePerUI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:SortePerUI     5   	     � Title$  
MainWindow��5   	   $	��720��6   $
��1280��6)    � WindowStartupLocation$ CenterScreen=�66    � 
ResizeMode$ NoResize=�6[   .��5	      � $��0q�6   .+�5
   
   �� -   5         ��Name$ playerOneSP��5
      $��200,0,200,10q�6*    �� Orientation$ 
Horizontal=�6@   $	��874��6Y   $	��150��6h   $	��150��6x   $��Bottom=�6�   .+�5      �� -   5         ��Name$ playerOneLBL��5      $��Player 1��6*   $��Center=�6=   $��Bottom=�6Z   $��16(�6u   $y�Hidden=�6�   5      �� 5   
   -   5        $ playerTwoSP��5      $��200,10,200,0q�6*   $	��Top=�6@   $	��150��6X   $	��874��6h   $	��150��6w   $ 
Horizontal=�6�   .+�5      �� -   5        $ playerTwoLBL��5      $��Player 2��6*   $	��Top=�6=   $��16(�6U   $��Center=�6c   $y�Hidden=�6�   5      �� 5   
   -   5        $ playerTreeSP��5      $
��Left=�6+   $��10,140,0,140q�6F   $	��150��6\   $	��411��6k   $	��150��6{   .+�5      �� -   5        $ playerTreeLBL��5      $��Player 3��6+   $
��Left=�6>   $��Center=�6Y   $��16(�6t   $y�Hidden=�6�   5      �� 5   
   -   5        $ playerFourSP��5      $��0,121,178,159q�6+   $��Right=�6B   $	��150��6^   $	��411��6m   $	��150��6}    J� RenderTransformOrigin$ 0.5,0.5&�6�   $ 
Horizontal=�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 90Q�6&   T� 5      5      .+�5      �� -   5        $ playerFourLBL��5      $��Player 4��6+   $��Right=�6>   $��Center=�6Z   $��16(�6u   $y�Hidden=�6�   5      �� 5   
   -	   5         ��Name$ StartBTN��5      $��Start��6#   $
��Left=�63   $��561,302,0,0q�6N   $	��Top=�6c   $	��150��6{   $��70��6�   $��36(�6�   6�   �� 5   
   -
   5        	 ��Name$	 comboBox��5      $
��Left=�6%   $��561,377,0,0q�6@   $	��Top=�6U   $��40��6m   
 �� SelectedIndex$
 0��6x   $��16(�6�   $��31��6�   $��Center=�6�   .@�5       �� $��2��6   $��16(�6'   $��Center=�65   �� 5!      $��3��6   $��16(�6'   �� 5"      $��4��6   $��16(�6'   5#      �� 5$   
   -   5        $ 
playersLBL��5$      $��Players��6$   $
��Left=�66   $��606,377,0,0q�6Q   $	��Top=�6f   $��16(�6~   $��Center=�6�   �� 5%   
   -   5         ��Name$ nicknameTXT��5%      $
��Left=�6'   $��30��6B   $��561,449,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��150��6�   $��16(�6�   $��Center=�6�   �� 5&   
   -   5        $ nicknameLBL��5&      $��Enter nickname:��6%   $
��Left=�6?   $��563,413,0,0q�6Z   $	��Top=�6o   $��16(�6�   $	��148��6�   $��Center=�6�   5(      5)      