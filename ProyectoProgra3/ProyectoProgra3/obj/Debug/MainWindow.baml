   M S B A M L   `   `   `  ����J  FProyectoProgra3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ProyectoProgra3ProyectoProgra3  5   	        ProyectoProgra3.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ProyectoProgra3     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   -   5           MaterialDesignBody#���   5	   
   $��Regular"�5
   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignPaper#���  5   
     MaterialDesignFont#���  5   
    � Title$
 Menu��5   	   $	��500��6   $	��850��6#    � WindowStartupLocation$ CenterScreen=�6/    � 
ResizeMode$ NoResize=�6k   .��5      � .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $��2��6I   .+�5      � ���	#FF76C8BE$	��240��6*   .+�5      �� -   5         ��Name$ lvMenu��5      $��Center=�6+   $��Disabled=�6F   .@�5      �� -   5         ��Name$ lv_CrearConferencia��5   #   .��5      �� $ 
Horizontal=�6%   
�������$	��220��6S   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	UserGroup=�66   $��30��6G   $��30��6R   $��Center=�6^   $��5q�6y   �� 5      $��Crear Conferencia��6(   $��17(�6A   $��Center=�6O   $
��10 0q�6j   	 � Cursor$	 Arrow��6x   5      5      �� 5      -   5        $ lv_ConferenciaOrganizador��5   #   .��5      �� $ 
Horizontal=�6%   
�������$	��220��6S   .+�5        $ ClipboardList=�66   $��30��6K   $��30��6V   $��Center=�6b   $��5q�6}   �� 5      $��Ver Conferencias��6(   $��17(�6@   $��Center=�6N   $
��10 0q�6i   5       5!      �� 5"      -   5        $ lv_ConferenciaCliente��5"   $   .��5#      �� $ 
Horizontal=�6%   
�������$	��220��6S   .+�5$        $ ClipboardList=�66   $��30��6K   $��30��6V   $��Center=�6b   $��5q�6}   �� 5%      $��Lista Conferencias��6(   $��17(�6B   $��Center=�6P   $
��10 0q�6k   5&      5'      �� 5(      -   5        $ lv_MisConferencias��5(   #   .��5)      �� $ 
Horizontal=�6%   
�������$	��220��6R   .+�5*        $ ClipboardListOutline=�66   $��30��6R   $��30��6]   $��Center=�6i   $��5q�6�   �� 5+      $��Mis Conferencias��6(   $��17(�6@   $��Center=�6N   $
��10 0q�6i   5,      5-      �� 5.      -   5        $ lv_ListaClientesAgregadas��5.   #   .��5/      �� $ 
Horizontal=�6%   
�������$	��220��6R   .+�50        $ ClipboardMinus=�66   $��30��6L   $��30��6W   $��Center=�6c   $��5q�6~   �� 51      $��Lista de Cliente��6(   $��17(�6@   $��Center=�6N   $
��10 0q�6i   52      53      54      55      �� 56      .+�57      �� -   5        
 ��Name$
 btnSalir��57      $��Cerrar Sesion��6+   $	��120��6C   $��Right=�6O   ���	#FF8A5DD86�   � 58      -	   5         �Name$ grd_main��58      $	��610��6)   $	��450��65   .+�59      �� $��Imagen/home.png��6   $��0,0,0,0q�65   5;      5=      5>      5@      5A      