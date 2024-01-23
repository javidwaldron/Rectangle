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
using System.Drawing;
using System.Windows.Ink;

namespace Rectangle
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


        // User Enters Text into textbox as Input

        private void numberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            string userWidthInput = numberTextBox.Text;
            
            

              
            
        }

        // Makes sure input is numberical
        private void numberTextBox_previewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out int result);

            RectangleShape.Height = result;
           
                    
        }
        
        
    
    
    }
}
