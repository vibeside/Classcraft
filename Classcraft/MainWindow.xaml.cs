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

namespace Classcraft
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainLoop();
        }
        private void mainLoop()
        {
            List<string> characters = new List<string>()
            {
                "a","a",
                "b","b",
                "c","c",
                "d","d",
                "e","e",
                "f","f",
                "g","g",
                "h","h",
            };
            Random random = new Random();
            foreach (TextBlock tBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int i = random.Next(characters.Count);
                string nextchar = characters[i];
                tBlock.Text = nextchar;
                characters.RemoveAt(i);
            }
        }
    }
}
