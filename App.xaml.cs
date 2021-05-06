using MojaAplikacja.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MojaAplikacja
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //          // "override" bo napisujemy metodektóa już istnieje w "Application"
        //protected override void OnActivated(EventArgs e)
        //{
        //    base.OnActivated(e);

        //        // poniżej swtorzyliśmy nowy obiket który przypisaliśmy do MainWidnow.DataContext linijke później
        //    var mainWidnowViewModel = new MainWindowViewModel();
        //             // "DataContext" jest naszym mechanizmem bindowania i do nich bindujemy View Modele
        //    MainWindow.DataContext = mainWidnowViewModel;
        //}
    }
}
