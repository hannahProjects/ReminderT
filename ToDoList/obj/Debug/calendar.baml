   M S B A M L   `   `   `  ����C  ?ToDoList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ToDoListToDoList  5   	       ToDoList.Calendar   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ToDoList     5   	   J FWpfAnimatedGif, Version=1.4.15.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  5   
     � Title$  Calendar��5
   	   $��444.912��6   $	��440��6+   .��5      � $��0,-6,-0.4,21.2q�6   ��5   
   �� 5       �� ImageSource$Z Timages/sticky-note-paper-reminder-schedule-on-window-use-post-it-notes-to-jd2mh1.jpg��6   .+�5   
   �� -   5        $��btn_refresh��5      $
��Left=�6%   $��8,8,0,0q�6@   $	��Top=�6Q   $��75��6i   $��forte)�6t   $��20(�6�   $��51��6�    J� RenderTransformOrigin$ 1.078,0.517&�6�   ��5      �� 5      .R�5      �� "  WpfAnimatedGif.ImageBehavior   AnimatedSource$1 +images/InstructiveHighlevelFlea-max-1mb.gif��6   5      5      �� 5   
   -   5         ��Name$ lblDate��5      $��calendar��6!   $
��Left=�64   $��
147,24,0,0q�6O   $	��Top=�6c   $��Forte)�6{   $��24(�6�   (  "System.Windows.Controls.WebBrowser  5!   
   $
��Left=�6   $	��100��60   $��721,168,-527.4,0q�6=   $	��Top=�6W   $	��100��6o   (  "System.Windows.Controls.DatePicker  5"   
   -   5          Name$ dp_month��5"      $
��Left=�6'   $��
103,83,0,0q�6B   $	��Top=�6V   $	��201��6�   $��32��6�   &   System.Windows.Controls.Calendar  5#   
   -   5          Name$ 	calander1��5#         SelectionMode$ MultipleRange=�6&   $
��Left=�6D   $��103,147,0,0q�6_   $	��Top=�6t   $	��201��6�   6�   �� 5$   
   -   5         ��Name$ btn_add��5$      $��Manage Diary��6"   $
��Left=�69   $��
68,352,0,0q�6T   $	��Top=�6h   $	��143��6�   
���   �$��Forte)�6�   $��20(�6�   ��6�   Z� ��6�   Z� 6�   �� 5%   
   -   5        $��Search��5%      $
��Left=�6"   $��261,352,0,0q�6=   $	��Top=�6R   $	��108��6j   
���   �$��Forte)�6�   $��20(�6�   ��6�   Z� ��6�   Z� 6�   �� 5&   
   -   5        	 ��Name$	 txt_subject��5&      $
��Left=�6'   $��23��6B   $��280,324,0,0q�6N   
 �� TextWrapping$

 Wrap=�6c   $	��Top=�6w   $	��120��6�   5(      5-      