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

namespace Gerenciador_de_veículos.Views
{
    /// <summary>
    /// Interaction logic for ActionsOptions.xaml
    /// </summary>
    public partial class ActionsOptions : UserControl
    {
        MainWindow main;
        public ActionsOptions(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
        }

        #region Buttons BackGround Events
        private void ActionOptions_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            button.Background = new SolidColorBrush(Color.FromRgb(00, 177, 255));
        }

        private void ActionOptions_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            button.Background = new SolidColorBrush(Color.FromRgb(00, 146, 255));
        }
        
        #endregion
    }
}
