   M S B A M L   `   `   `  ����>  :xqf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:xqfxqf  5   	       xqf.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962ac _MaterialDesignThemes.MahApps, Version=0.2.2.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   localclr-namespace:xqf   5   	   -   5          � Title$  用户登录��5	   	   $	��500��6   $	��350��6#    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   $��Segoe UI Emoji)�5   	   .��5      � .+�5   
   �� $	��280��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ #FFC1C1��6#   � 5      $ 	#FF34268A��6#    � Offset$ 1Q�65   � 5      $ #8470FF��6#   $ 0.546Q�63   5      5      �� 5   
   $
�� 220��6   $��Bottom=�6"   ��5      �� 5       �� Color$
 Snow��6"   5      �� 5!   
   $	��280��6   $	��240��6    $��Bottom=�6-   $
��0,80q�6H   	 �� RadiusY$	 10��6V   
 �� RadiusX$
 10��6c   
������� J� Effect 5"      3  -System.Windows.Media.Effects.DropShadowEffect  5#         
BlurRadius$ 15Q�6#      	Direction$ 0Q�63      RenderingBias$ Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ 	#FFBBBBBB��6i   5%      � 5'      $��Bottom=�6   $��35,80q�6.   $	��240��6=   .+�5(      �� $��登录��6   $��Center=�6!   $	��Top=�6>   $��5q�6V   
�������$��20(�6s   �� 5)      $��Center=�6   $��15q�64   .+�5*      �� -   5         ��Name$ Account��5*      $	��0,5q�6+   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 账号��68    %  !MaterialDesignFloatingHintTextBox#��[  6\   $��Champagne & Limousines)�6�   $��18(�6�   G� 5+      -   5         G�Name$ Password��5+      $	��0,5q�60   $ 密码��6=    ) %MaterialDesignFloatingHintPasswordBox#��[ 6a   $��Champagne & Limousines)�6�   $��18(�6�   5,      5-      � 5/   
   $��1��6   $��50��6   $	��Top=�6(   $	��120��6@   .+�50      �� -   5         �� 	IsDefault . $��20(�51       " MaterialDesignRaisedDarkButton#��[ 52      $��50��53      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 25��54      $��-9,393,9,-393q�6C   .��55      �� $��登  录��56      57      58      �� 5:   
   -   5        $��注册账户��5:      $
��Left=�6    $��Bottom=�6<   $��60 40q�6W   $��13(�6f   
������� � Cursor$
 Hand��6�   6�   �� 5<   
   $��忘记密码？��6   $��Right =�6!   $��Bottom=�6>   $��60 40q�6Y   $��13(�6i   
�������$
 Hand��6�   �� 5?   
   -   5        $��Right=�5?      $	��Top=�6-   ��6E   Z� ��6[   Z� .��5@      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6&   5A      �� 5C   
    �� CornerRadius$ 30��6   ���	#FF2281D1$��2q�6;   $	��100��6O   $	��100��6[   $	��Top=�6h   $��30q�6�   ��5D      �� 5E       �� ImageSource$ ./picture/小女孩.jpg��6   5G      5I      5J      