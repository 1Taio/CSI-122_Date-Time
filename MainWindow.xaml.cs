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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSI_122_Date_Time
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DateTime date = new DateTime();

            DateTime now = DateTime.Now;

            string shortTime = now.ToShortTimeString();
            string longTime = now.ToLongTimeString();

            string formatedstring = $"" + $"Short time {shortTime}\n" + $"Long time {longTime}\n" + $"Short Day {now.ToShortDateString()}\n" + $"Long Day {now.ToLongDateString()}\n" + $"Year {now.Year}\n" + $"Day of the week {now.DayOfWeek}\n" + $"";


            DateTime nowPlus7Months = now.AddMonths(7);

            TimeSpan math = nowPlus7Months - now;







            runDisplay.Text = (math.Days / 365.25).ToString();

        }

        private void btnDisplayTime_Click(object sender, RoutedEventArgs e)
        {
            DateTime bday = BirthdayObject();

            runDisplay.Text = $"Your BirthDay is {bday}";


        }

        public DateTime BirthdayObject()
        {
            int day = int.Parse(txtDay.Text);
            int month = int.Parse(txtMonth.Text);
            int year = int.Parse(txtYear.Text);

            DateTime birthday = new DateTime(year, month, day);

            return new DateTime(year, month, day);
        }

        private void btnDriverLis_Click(object sender, RoutedEventArgs e)
        {
            DateTime bday = BirthdayObject();
            DateTime now = DateTime.Now;

            TimeSpan ageInDays = now - bday;
            int age = (int)(ageInDays.Days / 365.25);
            runDisplay.Text = $"You are {age.ToString()} old \n";
        }

        private void btnResults_Click(object sender, RoutedEventArgs e)
        {
            DateTime selectedDate = dpDate.SelectedDate.Value;

            runDisplay.Text = selectedDate.ToString();
        }
    }
}
