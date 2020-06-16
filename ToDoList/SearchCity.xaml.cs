using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for SearchCity.xaml
    /// </summary>
    public partial class SearchCity : Window
    {
        string st = "Tel aviv";
        public SearchCity(string st)
        {
          
            InitializeComponent();
            lbl_city.Content = st;
            Show(st);
        }
        public void Show(string city)
        {
            StringBuilder query = new StringBuilder();
            query.Append("http://maps.google.com/maps?q=");
            query.Append(city + "," + "+");
            web1.Navigate(query.ToString());

        }

        
    }
}
