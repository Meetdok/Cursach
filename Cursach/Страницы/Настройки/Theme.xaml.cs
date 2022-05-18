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

namespace Cursach.Страницы.Настройки
{
    /// <summary>
    /// Interaction logic for Theme.xaml
    /// </summary>
    public partial class Theme : Window
    {
        public Theme()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Theme t = new Theme();
            this.Close();
        }
    }
}
