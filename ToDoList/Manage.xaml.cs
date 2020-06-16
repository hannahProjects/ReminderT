using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BE;
using ToDoList.viewModels;
using System.IO;

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for Manage.xaml
    /// </summary>
    public partial class Manage : Window
    {
        // TaskUserControl t;
        private ViewModel vm;
        List<ListOfTasks> ls;

        public static int ListOfTasksIdUser;
        public Manage()
        {

            InitializeComponent();
            initilize();
            //Files = Directory.GetFiles(@"/im");
            //this.DataContext = this;



        }
        public void initilize()
        {
            ls = new List<ListOfTasks>();


            vm = new ViewModel(popAlert);
            vm.getAll(ls);

            foreach (Control item in grd_printers.Children)
            {
                if (item is TaskUserControl)
                {
                    TaskUserControl t = item as TaskUserControl;
                    switch (t.Name)
                    {
                        case "family":
                            t.TaskListBox.ItemsSource = ls[0].Tasks.ToList();
                            t.TaskListBox.DisplayMemberPath = "NameTask";
                            ListOfTasksIdUser = 1;
                            break;

                        case "work":
                            t.TaskListBox.ItemsSource = ls[1].Tasks.ToList();
                            t.TaskListBox.DisplayMemberPath = "NameTask";
                            ListOfTasksIdUser = 2;
                            break;

                        case "studies":
                            t.TaskListBox.ItemsSource = ls[2].Tasks.ToList();
                            t.TaskListBox.DisplayMemberPath = "NameTask";
                            ListOfTasksIdUser = 3;
                            break;


                    }
                }
            }
        }
            private void popAlert(object sender, EventArgs e)
            {
                if (sender is Task)
                {
                    Task ms = sender as Task;
                    //MessageBox.Show("Hey we remind you: Task " + ms.NameTask + " has to be done, GoodLuck:)");
               // MessageBox.Show("Hey we remind you: Task " + ms.NameTask + " has to be done, GoodLuck:)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            }

            private void work_MouseDoubleClick(object sender, MouseButtonEventArgs e)
            {

               // ListOfTasksIdUser = 2;

            }



            private void family_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
            {
              //  ListOfTasksIdUser = 1;

            }

            private void studies_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
            {
               // ListOfTasksIdUser = 3;
            }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            initilize();
        }
        public string[] Files
        { get; set; }
    }
    }

