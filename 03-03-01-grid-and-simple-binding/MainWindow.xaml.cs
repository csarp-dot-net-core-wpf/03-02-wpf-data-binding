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

using oop.model;

namespace _03_03_01_grid_and_simple_binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            /// G1.18 Példányosítunk egy beteg objektumot
            Beteg beteg = new Beteg();

            /// G1.19 Megadjuk, hogy a beteg objektum az ablak adatkontextusa
            this.DataContext = beteg;

            InitializeComponent();
        }
    }
}
