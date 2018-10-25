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
using Exam.DAL.Model;

namespace Exam.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListOfCars.xaml
    /// </summary>
    public partial class ListOfCars : Page
    {
        EntityModel db = new EntityModel();
        public ListOfCars()
        {
            InitializeComponent();
            ListCars.ItemsSource = db.newEquipment.ToList();
        }

        private void miLogOn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
