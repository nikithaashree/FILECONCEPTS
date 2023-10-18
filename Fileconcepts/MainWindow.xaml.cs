using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media.Animation;

namespace Fileconcepts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Student>   liststring { get; set; } 
        public List<Student> BackupCollection { get; set; }

        public MainWindow()
        {
            liststring = new List<Student>();
            {
                new Student { Sid = 123, Name = "Niki", Description = "Training" };
                new Student { Sid = 234, Name = "Gowtham", Description = "Working" };
            };

            liststring.Add(new Student { Name = "Sow", Sid = 456, Description = "Topper" });
            liststring.Add(new Student { Name = "Subi", Sid = 789, Description = "Second Topper" });
            liststring.Add(new Student { Name = "Niki", Sid = 122, Description = "Third Rank" });
            liststring.Add(new Student { Name = "Gow", Sid = 788, Description = "Fourth Rank" });

            InitializeComponent();

            datavalue.ItemsSource = liststring;

            // listviewitem.ItemsSource = liststring;
          //  cmblist.DisplayMemberPath = "Name";
         //   cmblist.ItemsSource = liststring;
        }

        private void Register_Click(object sender, RoutedEventArgs e)
                {

           

        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            int[] values = { 10, 20, 30, 40, 50, 60, 70, 80 };
            //IEnumerable<int> ints = from x in values
            //                     where x > 40
            //                     select x;
            IEnumerable<int> datas = values.Where(x => x > 40);

            List<int> listint = datas.ToList();
            int[] sdf = datas.ToArray();
            int x = datas.FirstOrDefault();
            int y = datas.First();

        }

        private void txtname_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
               {

           //// int[] values = { 10, 20, 30, 40, 50, 60, 70, 80 };
           //    //IEnumerable<int> ints = from x in values
           //    //                     where x > 40
           //    //                     select x;
           // //IEnumerable<int> datas = values.Where(x => x > 40);

           // List<int> listint = datas.ToList();
           // int[] sdf = datas.ToArray();
           // int x = datas.FirstOrDefault();
           // int y = datas.First();

            //Lambda expression          
         
            var listofdata = liststring.Where(s => s.Name.Contains(txtname.Text) == true);
            var x = listofdata.FirstOrDefault();
            MessageBox.Show("First Value is " + x.Name + " ID is" + x.Sid.ToString());
            var y = listofdata.First();
            datavalue.ItemsSource = null;
            datavalue.ItemsSource = listofdata;
        }
    }

    public class Student
    {
        public int Sid { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    } }

