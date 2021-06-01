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
using ChessCore;

namespace WPFChess
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //List<ChessCore.Figure> figures;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void x1y1_Click_1(object sender, RoutedEventArgs e)
        {
            x1y1.Content = Selector.DATA;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            SelectorWindow slcWin = new SelectorWindow();
            slcWin.Owner = this;
            slcWin.ShowDialog();
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            Selector.DATA = null;
        }
    }

    static class Selector
    {
        public static string DATA { get; set; }
    }
}
