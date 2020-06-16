using BE;
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

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for TaskDetails.xaml
    /// </summary>
    public partial class TaskDetails : Window
    {
        public TaskDetails(List<Task> t)
        {
            InitializeComponent();
            lsv_details.ItemsSource = t.ToList();
            lsv_details.DisplayMemberPath = "NameTask";
        }

        private void lsv_details_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Task t = null;
            if (lsv_details.SelectedIndex != -1)
            {
                t = lsv_details.SelectedValue as Task;
            }
            Description.Text = t.DescriptionTask;
            TypeTask.Text = t.TypeTask.ToString();
            PriorityTask.Text = t.PriorityTask.ToString();

        }
    }
}
