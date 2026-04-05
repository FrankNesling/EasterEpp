using System.Windows;
using System.Windows.Controls;

namespace EasterEpp
{
  public partial class MenuView : UserControl
  {
    private MainWindow main;

    public MenuView(MainWindow mainWindow)
    {
      InitializeComponent();
      main = mainWindow;
    }

    private void Open1(object sender, RoutedEventArgs e) => main.OpenGame("hr");
    private void Open2(object sender, RoutedEventArgs e) => main.OpenGame("ch");
    private void Open3(object sender, RoutedEventArgs e) => main.OpenGame("de");
    private void Open4(object sender, RoutedEventArgs e) => main.OpenGame("lt");
    private void Open5(object sender, RoutedEventArgs e) => main.OpenGame("pl");
    private void Open6(object sender, RoutedEventArgs e) => main.OpenGame("tw");
    private void Open7(object sender, RoutedEventArgs e) => main.OpenGame("at");
    private void Open8(object sender, RoutedEventArgs e) => main.OpenGame("cn");
    private void Open9(object sender, RoutedEventArgs e) => main.OpenGame("it");

  }
}