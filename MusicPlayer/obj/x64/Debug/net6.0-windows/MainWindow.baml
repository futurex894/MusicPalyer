   M S B A M L   `   `   `  ����F  BMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MusicPlayerMusicPlayer  5   	       MusicPlayer.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:MusicPlayer     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � 	Resources 5
         ImageRun W� From	 W� To g� RepeatBehavior g� Duration �� 
TargetName �� TargetProperty��%�   &	        �� 5   
   .��5      W�  06    3606'   $ Forever��60   $ 0:0:3D�6I   $ 	imageshow��5   .   $ Angle�5   .   5      5      .��5      � .+�5   
   �� 5      �� 5   
   $	��100��6   $	��100��6   $��Assets/RC.jpg��6)    J� Clip 5      @� 5      	 @� RadiusX$	 50Q�6"   
 @� RadiusY$
 50Q�6/    @� Center$ 50 50&�6<   6M    J� RenderTransformOrigin 5      8� 5       8� X$	 0.5Q�6    8� Y$	 0.5Q�6    6*   z�5      �� 5      -   5        	imageshow��5   7   5      �� 5    
   -   5         ��Name$ hello��5       .+�5!      ��  �� Right$ 0��6   $��17��6&   $��20��61   
���  �� �� CornerRadius$ 5 0 0 5��6N   6g   �� 5"      $ 0��6   
 �� Top$ 30��6&   $��30��66   $��20��6A   
���  ��$ 5 0 0 5��6^   5#      5$      �� 5%   
   -   5         ��Name$ 	btnUpdate��5%   (   $��30��6   $��30��6   5'      5)      5*      