   M S B A M L   `   `   `  ����>  :xqf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:xqfxqf  5   	       xqf.Registered   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962ac _MaterialDesignThemes.MahApps, Version=0.2.2.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   localclr-namespace:xqf   5   	   -   5          � Title$  用户登录��5	   	   $	��500��6   $	��350��6#    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   $��Segoe UI Emoji)�5   	   .��5      � .+�5   
   �� $	��280��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ #FFC1C1��6#   � 5      $ 	#FF34268A��6#    � Offset$ 1Q�65   � 5      $ #8470FF��6#   $ 0.546Q�63   5      5      �� 5   
   $
�� 220��6   $��Bottom=�6"   ��5      �� 5       �� Color$
 Snow��6"   5      �� 5   
   $	��280��6   $	��240��6    $��Bottom=�6-   $
��0,80q�6I   	 �� RadiusY$	 10��6W   
 �� RadiusX$
 10��6d   
������� J� Effect 5       3  -System.Windows.Media.Effects.DropShadowEffect  5!         
BlurRadius$ 15Q�6#      	Direction$ 0Q�63      RenderingBias$ Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ 	#FFBBBBBB��6i   5#      � 5%   
   $��Bottom=�6   $��35,80q�6*   $	��240��69   .+�5&      �� $��用户注册��6   $��Center=�6#   $	��Top=�6@   $��5q�6X   
���   �$��18(�6v   �� 5'      $��Center=�6   $��20q�64   .+�5(      �� -   5         ��Name$ 
Re_Account��5(      $	��0,5q�6.   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 请输入账号��6;    %  !MaterialDesignFloatingHintTextBox#��[  6b   $��Champagne & Limousines)�6�   $��16(�6�   G� 5)      -   5         G�Name$ Re_Password��5)      $	��0,5q�63   $ 请输入密码��6@    ) %MaterialDesignFloatingHintPasswordBox#��[ 6g   $��Champagne & Limousines)�6�   $��16(�6�   G� 5*      -   5        $ Re_PasswordAgain��5*      $	��0,5q�68   $ 请确认密码��6E   #��[ 6l   $��Champagne & Limousines)�6�   $��16(�6�   5+      5,      �� 5.   
   -   5        $	��150��5.      $��Center=�6   $��Bottom=�6:   $
��0,65q�6U   $��
确    定��6c   $��20(�6�    � Cursor$
 Hand��6�   �� 50   
    �� CornerRadius$ 30��6   ���	#FFFFFFFF$��2q�6;   $	��100��6O   $	��100��6[   $	��Top=�6h   $��30q�6�   ��51      �� 52       �� ImageSource$ ./picture/gdh.png��6   54      �� 56   
   -   5        $��Right=�56      $	��Top=�6-   ��6E   Z� ��6[   Z� .��57      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6&   58      5:      5;      