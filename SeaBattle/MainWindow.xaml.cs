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
using MahApps.Metro.Controls;
using System.Diagnostics;
using SeaBattle.ViewModel;

namespace SeaBattle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
       

        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void Button_DragOver(object sender, DragEventArgs e)
        {
            ((Button)sender).Content = "nadomnoiutishina";
        }

        private void Button_DragLeave(object sender, DragEventArgs e)
        {
            ((Button)sender).Content = "nebopolnoeognya";
        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Label but = (Label)sender;
            
            DragDrop.DoDragDrop(but, but.Content, DragDropEffects.All);
        }
    }
}