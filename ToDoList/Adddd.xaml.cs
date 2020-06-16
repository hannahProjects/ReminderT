using BE;
using BL;
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
using ToDoList.viewModels;

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for Adddd.xaml
    /// </summary>
    public partial class Adddd : Window
    {
       public static Task t;
        AddTaskVM Vm { set; get; }
        int op2;
        public Adddd(int op ,Task t1)
        {
            op2 = op;
            t = t1;
            InitializeComponent();
            
            Vm = new AddTaskVM();
            this.DataContext = Vm;

            //Vm.ListOfTasksId = Manage.ListOfTasksIdUser;

            for (int i = 0; i < 24; i++)
            {
                if (i < 10)
                {
                    hour.Items.Add("0" + i);
                    hour1.Items.Add("0" + i);
                }
                else
                {
                    hour.Items.Add("" + i);
                    hour1.Items.Add("" + i);
                }
            }
            
            for (int i = 0; i < 60; i++)
            {
                if (i < 10)
                {
                    minutes.Items.Add("0" + i);
                    minutes1.Items.Add("0" + i);
                }
                else
                {
                    minutes.Items.Add("" + i);
                    minutes1.Items.Add("" + i);
                }
                //cmb_city.Items.Add("Tel Aviv");
                //cmb_city.Items.Add("Natania");
                //cmb_city.Items.Add("Yavne");
                //cmb_city.Items.Add("Rehovot");
                //cmb_city.Items.Add("Jerusalem");
                //cmb_city.Items.Add("Haifa");
                //cmb_city.Items.Add("Tiberia");
                //cmb_city.Items.Add("Rishon Leztiyon");
                //cmb_city.Items.Add("Ashdod");
                //cmb_city.Items.Add("Elat");
            }
            if (op == 2)
            {
                OkayButton.Visibility = Visibility.Hidden;
                initilizeDelete();
                Vm.TaskId = t.TaskId;

            }
        }
        public void initilizeDelete()
        {
            
           
            if (t != null)
            {
              //  Task t = TaskUserControl.TaskListBox.SelectedValue as Task;
                dp_month.SelectedDate = t.DateTask;
                cmb_city.Text = t.LocationTask;
                TaskTitle.Text = t.NameTask;
                cmb_type.Text = t.TypeTask.ToString();
                TaskPriority.SelectedItem = t.PriorityTask.ToString();
                description.Text = t.DescriptionTask;
                hour1.Text= t.WhenToRemember.Hour.ToString();
                minutes1.DisplayMemberPath = t.WhenToRemember.Minute.ToString();

            }
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Vm.DateTask = dp_month.SelectedDate.Value;
            Vm.LocationTask = cmb_city.Text;
            Vm.NameTask = TaskTitle.Text;
            Vm.TypeTask = (BE.type1)(cmb_type.SelectedIndex);
            Vm.PriorityTask = (BE.priority)(TaskPriority.SelectedIndex);
            Vm.DescriptionTask = description.Text;
            Vm.WhenToRemember = Convert.ToDateTime(hour1.Text + ":" + minutes1.Text);
            switch ((BE.type1)(cmb_type.SelectedIndex))
            {
                case (type1.family):
                    Vm.ListOfTasksId = 1;
                    break;
                case (type1.work):
                    Vm.ListOfTasksId = 2;
                    break;
                case (type1.studies):
                    Vm.ListOfTasksId = 3;
                    break;

            }

            try
            {
                if (op2 == 2)
                    Vm.CurrentModel.Update();
                else
                    Vm.CurrentModel.Save();
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void minutes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btn_ShowCity_Click(object sender, RoutedEventArgs e)
        {
            string city = cmb_city.Text;
            SearchCity c = new SearchCity(city);
            c.ShowDialog();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            TaskUserControl tu = new TaskUserControl();
            try
            {
                Vm.DateTask = t.DateTask;
                Vm.LocationTask = t.LocationTask;
                Vm.NameTask = t.NameTask;
                Vm.TypeTask = t.TypeTask;
                Vm.PriorityTask = t.PriorityTask;
                Vm.DescriptionTask = t.DescriptionTask;
                Vm.WhenToRemember = t.WhenToRemember;
                Vm.ListOfTasksId = t.ListOfTasksId;
                
                Vm.CurrentModel.Delete();
                //if (tu.TaskListBox.SelectedIndex != -1)
                //{
                //    Task t = tu.TaskListBox.SelectedValue as Task;
                //    dp_month.SelectedDate=t.DateTask;
                //   cmb_city.Text=t.LocationTask;
                //    TaskTitle.Text=t.NameTask;
                //    cmb_type.Text=t.TypeTask.ToString();
                //    TaskPriority.Text = t.PriorityTask.ToString();
                //   description.Text=t.DescriptionTask;
                //    hour1.Text = t.WhenToRemember.Hour.ToString();
                //    minutes1.Text = t.WhenToRemember.Hour.ToString();

                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
