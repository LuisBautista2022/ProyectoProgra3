   M S B A M L   `   `   `  ����J  FProyectoProgra3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ProyectoProgra3ProyectoProgra3  5   	       ProyectoProgra3.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ProyectoProgra3     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   
   $��Regular"�5
   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignPaper#���  5   
     MaterialDesignFont#���  5   
    � Title$ Login��5   	   $	��400��6   $	��750��6$    � WindowStartupLocation$ CenterScreen=�60    � 
ResizeMode$ NoResize=�6U   .��5      � .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $	��300��6   ���	#FFDBFBFF.+�5      �� .+�5      �� $��
Bienvenido��6   $��Center=�61   $
��0 20q�6N   $��26(�6\   $
��Bold"�6j   $��Arial Black)�6|   5      �� 5      $ 
Horizontal=�6   $��20q�66   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Account=�6.   $��30��6>   $��30��6J   $��Center=�6U   �� 5      -   5         ��Name$ txt_usuario��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Usuario��63    % !MaterialDesignFloatingHintTextBox#��[ 6\   $�� ��6�   $	��210��6�   $��5 0 0 0q�6�   $��16(�6�   	 � Cursor$	 Arrow��6�   5      �� 5      $ 
Horizontal=�6   $��20q�66   .+�5        $	 Key=�6.   $��30��6:   $��30��6F   $��Center=�6Q   G� 5      -   5        
 G�Name$
 pwb_contrasenia��5   "   $ Contraseña��6<    ) %MaterialDesignFloatingHintPasswordBox#��[ 6h   $	��210��6�   $��5 0 0 0q�6�   $��16(�6�   $	 Arrow��6�   5      �� 5      $ 
Horizontal=�6   $��Center=�66   .+�5       �� .+�5!      �� -   5         ��Name$ btn_ingresar��5!   !   $��Ingresar��67   $��16(�6K   $��Arial Black)�6t   $
��Bold"�6�   $
	 Hand��6�   ���	#FF284BB96�   5"      �� 5#      $��20 0 0 0q�6!   .+�5$      �� -   5        $ btn_Registrarse��5$   !   $��Crear Cuenta��6:   $��16(�6R   $��Arial Black)�6~   $
��Bold"�6�   $
	 Hand��6�   ���	#FF284BB96�   5%      5&      �� 5'      $��0 20 0 0q�6   .+�5(      � -   5         �Name$ 	pgb_Carga��5(   "    � Value$ 0Q�65   $��10��6?   $��	10 0 10 0q�6K   $y�Hidden=�6^   5)      5*      �� 5+      $	��450��6   .+�5,      �� $��/Imagen/login.jpg��6   $	��570��63   $	��385��6?    J� OpacityMask 5-      �� 5.       �� ImageSource$ /Imagen/login.jpg��6%   50      51      53      54      55      