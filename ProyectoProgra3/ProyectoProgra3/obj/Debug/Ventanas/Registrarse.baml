   M S B A M L   `   `   `  ����J  FProyectoProgra3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ProyectoProgra3.VentanasProyectoProgra3.Ventanas  5   	   *    $ProyectoProgra3.Ventanas.Registrarse   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:ProyectoProgra3.Ventanas     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5	   
   $��Regular"�5
   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignPaper#���  5   
     MaterialDesignFont#���  5   
    � Title$ Registrarse��5   	   $	��400��6   $	��550��6*    � WindowStartupLocation$ CenterScreen=�66    � 
ResizeMode$ NoResize=�6[   .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      �� $��Center=�6   $��0 20 0 0q�66   .+�5      �� $��Registrarse��6   $��26(�6.   $
��Bold"�6<   5      �� 5      $ 
Horizontal=�6   $��Center=�62   .+�5      �� $��Center=�6   .+�5      �� $ 
Horizontal=�6!   $��10 20q�6:   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Account=�62   $��30��6B   $��30��6N   $��Center=�6Y   �� 5      -   5         ��Name$ txt_usuario��5   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Usuario��67    % !MaterialDesignFloatingHintTextBox#��[ 6`   $	��210��6�   $��5 0 0 0q�6�   $��16(�6�   	 � Cursor$	 Arrow��6�   5      �� 5      $ 
Horizontal=�6!   $��10 20q�6:   .+�5        $	 Key=�62   $��30��6>   $��30��6J   $��Center=�6U   G� 5      -   5        
 G�Name$
 pwb_contrasenia��5   &   $ Contraseña��6@    ) %MaterialDesignFloatingHintPasswordBox#��[ 6l   $	��210��6�   $��5 0 0 0q�6�   $��16(�6�   $	 Arrow��6�   5      �� 5       $ 
Horizontal=�6!   $��10 20q�6:   .+�5!        $	 Key=�62   $��30��6>   $��30��6J   $��Center=�6U   G� 5"      -   5        $
 txt_repassword��5"   &   $ Repetir Contraseña��6>   #��[ 6r   $	��210��6�   $��5 0 0 0q�6�   $��16(�6�   $	 Arrow��6�   5#      5$      �� 5%      .+�5&      �� $ 
Horizontal=�6!   $��10 20q�6:   .+�5'        $ ClipboardAccount=�62   $��30��6K   $��30��6W   $��Center=�6b   �� 5(      -   5        $ 
txt_Nombre��5(   "   $ Nombre��66   #��[ 6^   $�� ��6�   $	��210��6�   $��5 0 0 0q�6�   $��16(�6�   $	 Arrow��6�   5)      �� 5*      $ 
Horizontal=�6!   $��10 20q�6:   .+�5+        $ ClipboardAccount=�62   $��30��6K   $��30��6W   $��Center=�6b   �� 5,      -   5        $ txt_Apellido��5,   "   $ Apellido��68   #��[ 6b   $�� ��6�   $	��210��6�   $��5 0 0 0q�6�   $��16(�6�   $	 Arrow��6�   5-      5.      5/      �� 51      $��Center=�6   $��0 15 0 0q�66   .+�52      �� -   5         ��Name$ btn_registrar��52      $��	Registrar��60   6D   53      54      55      56      