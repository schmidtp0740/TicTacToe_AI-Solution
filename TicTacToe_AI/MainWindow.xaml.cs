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

namespace TicTacToe_AI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            
        }

        private void CM_Click(object sender, RoutedEventArgs e)
        {
            CenterMiddleBtn.Content= "X";
        }

        private void TL_Click(object sender, RoutedEventArgs e)
        {
            Game.MarkPosition(Game.player, 0);
        }

        private void TM_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TR_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CL_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CR_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BL_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BC_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BR_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
