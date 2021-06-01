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

namespace WPFChess
{
    /// <summary>
    /// Логика взаимодействия для SelectorWindow.xaml
    /// </summary>
    public partial class SelectorWindow : Window
    {
        public SelectorWindow()
        {
            InitializeComponent();
        }

        private void King_Click(object sender, RoutedEventArgs e)
        {
            Selector.DATA = Convert.ToString(King.Name);
            this.Close();
        }

        private void Queen_Click(object sender, RoutedEventArgs e)
        {
            Selector.DATA = Convert.ToString(Queen.Name);
            this.Close();
        }

        private void Bishop_Click(object sender, RoutedEventArgs e)
        {
            Selector.DATA = Convert.ToString(Bishop.Name);
            this.Close();
        }

        private void Knight_Click(object sender, RoutedEventArgs e)
        {
            Selector.DATA = Convert.ToString(Knight.Name);
            this.Close();
        }

        private void Rook_Click(object sender, RoutedEventArgs e)
        {
            Selector.DATA = Convert.ToString(Rook.Name);
            this.Close();
        }

        private void Pawn_Click(object sender, RoutedEventArgs e)
        {
            Selector.DATA = Convert.ToString(Pawn.Name);
            this.Close();
        }
    }
}
