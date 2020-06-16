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
using System.Xml;
using BE;
using ToDoList.viewModels;

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for Calendar.xaml
    /// </summary>
    public partial class Calendar : Window
    {
       
        public Calendar()
        {
            InitializeComponent();
            

            //bl.addList(l);
           
            calander1.SelectedDate = DateTime.Today;
            AddTask(DateTime.Today);
        }
        private void DatePicker_SelectedDateChanged(object sender,
           SelectionChangedEventArgs e)
        {
            // ... Get DatePicker reference.
            var picker = sender as DatePicker;

            // ... Get nullable DateTime from SelectedDate.
            DateTime? date = picker.SelectedDate;
            if (date == null)
            {
                // ... A null object.
                this.Title = "No date";
            }
            else
            {
                // ... No need to display the time.
                this.Title = date.Value.ToShortDateString();
            }
        }
        public void AddTask(DateTime dt)
        {
            List<ListOfTasks> ls = new List<ListOfTasks>();
            SelectedDatesCollection theDates = calander1.SelectedDates;
            theDates.Clear();
            theDates.Add(dt);
            ViewModel vm = new ViewModel(popAlert);
            vm.getAll(ls);
            foreach (Task t in ls[0].Tasks.ToList())
            {
                DateTime d = t.DateTask;
                theDates.Add(d);
            }
            foreach (Task t in ls[1].Tasks.ToList())
            {
                theDates.Add(t.DateTask);
            }
            foreach (Task t in ls[2].Tasks.ToList())
            {
                theDates.Add(t.DateTask);
            }
            //theDates.Add(new DateTime(2000, 2, 9));
            //theDates.Add(new DateTime(2000, 2, 16));
            //theDates.Add(new DateTime(2000, 2, 23));
        }
        private void popAlert(object sender, EventArgs e)
        {
            if (sender is Task)
            {
                Task ms = sender as Task;
                MessageBox.Show("Hey we remind you: Mission " + ms.NameTask + " has to be done, GoodLuck:)");
            }
        }
        private void Calendar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //txtDate.Text = cld.SelectedDate.ToString();

        }

        private void btn_Down_Click(object sender, RoutedEventArgs e)
        {
           // gd_calendar.Visibility = Visibility.Hidden;
        }

       

     

        private void schedule_MouseEnter(object sender, MouseEventArgs e)
        {
           // gd_calendar.Visibility = Visibility.Visible;
        }

        private void Calendar_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {

        }
      

        private void dp_month_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime dt = dp_month.SelectedDate.Value;
            AddTask(dt);
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            Manage m = new Manage();
            m.ShowDialog();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Tasks";
            dlg.DefaultExt = ".xml";
           // dlg.Filter = "Xml document (.hpa)|*.hpa";

            var result = dlg.ShowDialog();
            if (result == true)
            {
                xworkload.Load(dlg.FileName);

                string xmlcontents = xworkload.InnerXml;

                string textToSearch = txt_subject.Text;

                bool hasnode = (xworkload.DocumentElement.SelectNodes("//Task/Name[text()='" + textToSearch + "']").Count > 0);

                if (!hasnode)
                {
                    MessageBox.Show(String.Format("Part number {0}{1} found ", txt_subject.Text, (!hasNode ? " not" : String.Empty)));
                }
                else
                    MessageBox.Show(String.Format("Part number {0} found", txt_subject.Text));

            }

            }
        private bool hasNode;
        XmlDocument xworkload = new XmlDocument();

        private void btnPnoCheck_Click(object sender, RoutedEventArgs e)
        {
           // DateTime dt = dp_month.SelectedDate.Value;

            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Tasks";
            dlg.DefaultExt = ".hpa";
            dlg.Filter = "Xml document (.hpa)|*.hpa";

            var result = dlg.ShowDialog();
            if (result == true)
            {
                xworkload.Load(dlg.FileName);

                string xmlcontents = xworkload.InnerXml;

                string textToSearch = txt_subject.Text;

                bool hasnode = (xworkload.DocumentElement.SelectNodes("//Item/partnumber[text()='" + textToSearch + "']").Count > 0);

                if (!hasnode)
                {
                    MessageBox.Show(String.Format("Part number {0}{1} found ", txt_subject.Text, (!hasNode ? " not" : String.Empty)));
                }
                else
                    MessageBox.Show(String.Format("Part number {0} found", txt_subject.Text));

            }

        }

        private void btn_refresh_Click(object sender, RoutedEventArgs e)
        {
            AddTask(DateTime.Today);

        }

        private void calander1_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void calander1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            List<ListOfTasks> ls = new List<ListOfTasks>();
            List<Task> chosenT = new List<Task>();
            ViewModel vm = new ViewModel(popAlert);
            vm.getAll(ls);
            foreach (Task t in ls[0].Tasks.ToList())
            {
                if (t.DateTask.Equals(calander1.SelectedDate))
                    chosenT.Add(t);

            }
            foreach (Task t in ls[1].Tasks.ToList())
            {
                if (t.DateTask.Equals(calander1.SelectedDate))
                    chosenT.Add(t);

            }


            foreach (Task t in ls[2].Tasks.ToList())
            {
                if (t.DateTask.Equals(calander1.SelectedDate))
                    chosenT.Add(t);
            }

            TaskDetails td = new TaskDetails(chosenT);
            td.ShowDialog();

        }
    }
}
