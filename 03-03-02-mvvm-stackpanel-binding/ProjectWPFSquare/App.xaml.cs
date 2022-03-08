using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ProjectWPFSquare.View;
using ProjectWPFSquare.ViewModel;

namespace ProjectWPFSquare
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // MVVM.08 Felülírjuk az OnStartup metódust
        protected override void OnStartup(StartupEventArgs e)
        {
            // MVVM.09 Példányosítunk egy ViewModelt
            SquareViewModel squareViewModel = new SquareViewModel();

            // MVVM.10. Példányosítunk egy View ablakot
            MainWindow mainWindow = new MainWindow();

            // MVVM.11 Megadjuk az ablak adatkontextusát (összekötjük a View-t és ViewModelt)
            mainWindow.DataContext = squareViewModel;

            // MVVM.12 Megjelenítjük az ablakot
            mainWindow.Show();
            // Az ős osztály metódusát meghívjuk
            base.OnStartup(e);
        }
    }
}
