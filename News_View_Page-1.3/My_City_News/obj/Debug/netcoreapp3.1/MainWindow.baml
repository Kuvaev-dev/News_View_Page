   M S B A M L   `   `   `  ����G  CMy_City_News, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:My_City_NewsMy_City_News  5   	   I)clr-namespace:My_City_News.MVVM.ViewModelMy_City_News.MVVM.ViewModel  5   	   ?$clr-namespace:My_City_News.MVVM.ViewMy_City_News.MVVM.View  5   	       My_City_News.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:My_City_News     5   	   ?	viewModel)clr-namespace:My_City_News.MVVM.ViewModel     5   	   5view$clr-namespace:My_City_News.MVVM.View     5   	     � Title$  
MainWindow��5
   	   $	��600��6   $	��920��6)    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency$
 true��5   	    � DataContext 5      /  )My_City_News.MVVM.ViewModel.MainViewModel  5   
   .��5      �� ���#272537 �� CornerRadius$ 10��5      ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5       � RowDefinitions 5      �� 5      $��75 �6    �� 5      .+�5       �� $
��NEWS��6   $��Center=�5!      $
��Left=�5"      
�������$��22(�5$      $��20,0,0,0q�5%      $��/Fonts/#Poppins)�5&      �� 5(      $��1��6   .+�5)      	� $
��Home��6   $��50��5*      
�������$��14(�5,         MenuButtonTheme#��[  5-       d� 	IsChecked$
 TrueY�5.      $��/Fonts/#Poppins)�50      ��5/      �� *HomeViewCommand+50      	� 52      $��Popular��6   $��50��53      
�������$��14(�55      #��[  56      $��/Fonts/#Poppins)�58      ��57      �� *DiscoveryViewCommand+58      	� 5:      $��Topical��6   $��50��5;      
�������$��14(�5=      #��[  5>      $��/Fonts/#Poppins)�5?      5@      �� 5B      $	��250��6   $��40��5C      $��Center=�5D      $
��Left=�5E      $��5q�5F      $��1��5G        ModernTextBox#��[ 5H      �� 5J      $��1��6   $��1��5K      $��10q�5L      ��5M      �� *CurrentView+5N      5O      5P      