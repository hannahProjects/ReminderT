using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BL;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using BL;
using ToDoList.viewModels;
using BE;
using System.Data.SqlClient;
using System.Data;
using System.Xml;

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for TaskUserControl.xaml
    /// </summary>
    public partial class TaskUserControl : UserControl
    {
        public static int op;
        private ViewModel vm;
        List<ListOfTasks> ls;
        public Task CurrentMission { get; private set; }
        public TaskUserControl( )
        {
            InitializeComponent();
            //ls = new List<ListOfTasks>();

            
            //vm = new ViewModel(popAlert);
            //vm.getAll(ls);
          
            //switch (Manage.ContentProperty.Name)
            //{
            //    case "family":
            //        TaskListBox.ItemsSource = ls[0].Tasks.ToList();
            //        TaskListBox.DisplayMemberPath = "NameTask";
            //        break;

            //    case "work":
            //        TaskListBox.ItemsSource = ls[1].Tasks.ToList();
            //        TaskListBox.DisplayMemberPath = "NameTask";
            //        break;

            //    case "studies":
            //        TaskListBox.ItemsSource = ls[2].Tasks.ToList();
            //        TaskListBox.DisplayMemberPath = "NameTask";
            //        break;


            //}
          

            // m = _listBox[(int)_target].SelectedValue as Mission;
            //  gr.DataContext = m;





        }
        private List<string> convertTableToListTask(DataSet ds)
        {
            List<string> list = new List<string>();
            foreach (DataRow dtrow in ds.Tables[0].Rows)
            {
                list.Add(dtrow.ItemArray[0].ToString());
            }
            return list;
        }
        private void popAlert(object sender, EventArgs e)
        {
            if (sender is Task)
            {
                Task ms = sender as Task;
                MessageBox.Show("Hey we remind you: Mission " + ms.NameTask + " has to be done, GoodLuck:)");
            }
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            op = 1;
            Adddd dlg = new Adddd(op,null);
            if (dlg.ShowDialog() == true)
            {
               


                //    // Get the document
                //    XmlDocument document = ((XmlDataProvider)FindResource("tasks")).Document;

                //    // Create the Task element
                //    XmlElement task = document.CreateElement("Task");

                //    // Create the Name element
                //    XmlElement name = document.CreateElement("Name");
                //    name.InnerText = dlg.TaskTitle.Text;
                //    task.AppendChild(name);

                //    // Create the Priority element
                //    XmlElement priority = document.CreateElement("Priority");
                //    priority.InnerText = dlg.TaskPriority.Text;
                //    task.AppendChild(priority);

                //    // Create the Done element
                //    XmlElement done = document.CreateElement("Done");
                //    done.InnerText = "No";
                //    task.AppendChild(done);

                //    // Create the Description element
                //    XmlElement description = document.CreateElement("Description");
                //    description.InnerText = dlg.description.Text;
                //    task.AppendChild(description);

                //    document.DocumentElement.AppendChild(task);
            }
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Task t=null;
            if (TaskListBox.SelectedIndex != -1)
            {
               t = TaskListBox.SelectedValue as Task;
            }
            op = 2;
            Adddd dlg = new Adddd(op, t);
            dlg.ShowDialog();
            //    try
            //    {
            //        if (TaskListBox.SelectedIndex != -1)
            //        {
            //            Task t =TaskListBox.SelectedValue as Task;
            //            vm.deleteTask(t);
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }

        }

        //private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    XmlDataProvider tasks = (XmlDataProvider)FindResource("tasks");
        //    tasks.Document.Save("Tasks.xml");
        //}





     //   ItemsSource="{Binding Source={StaticResource tasks}}"




               //<TextBlock Name = "title" Grid.Row="0" Grid.Column="1" FontWeight="Bold"   Foreground="{Binding XPath=Priority, Converter={StaticResource PriorityConverter}}" Text="{Binding XPath=Name}" />
               // <TextBlock Name = "description" Grid.Row="1" Grid.Column="1" Text="{Binding XPath=Description}"/>
               // <TextBlock Name = "location" Grid.Row="2" Grid.Column="1" Text="{Binding XPath=Location}"/>
               // <TextBlock Name = "date" Grid.Row="3" Grid.Column="1" Text="{Binding XPath=DateTask}"/>
               // <TextBlock Name = "dateRemember" Grid.Row="4" Grid.Column="1" Text="{Binding XPath=WhenToRemember}"/>

        private void UpdateButton_Click_1(object sender, RoutedEventArgs e)
        {
            Task t = null;
            if (TaskListBox.SelectedIndex != -1)
            {
                t = TaskListBox.SelectedValue as Task;
            }
            op = 2;
            Adddd dlg = new Adddd(op, t);
            dlg.ShowDialog();
        }
    }
}
