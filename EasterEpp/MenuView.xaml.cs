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

    private void Open1(object sender, RoutedEventArgs e) => main.OpenGame("img1");
    private void Open2(object sender, RoutedEventArgs e) => main.OpenGame("img2");
    private void Open3(object sender, RoutedEventArgs e) => main.OpenGame("img3");
    private void Open4(object sender, RoutedEventArgs e) => main.OpenGame("img4");
    private void Open5(object sender, RoutedEventArgs e) => main.OpenGame("img5");
    private void Open6(object sender, RoutedEventArgs e) => main.OpenGame("img6");
    private void Open7(object sender, RoutedEventArgs e) => main.OpenGame("img6");
    private void Open8(object sender, RoutedEventArgs e) => main.OpenGame("img6");
    private void Open9(object sender, RoutedEventArgs e) => main.OpenGame("img6");

  }
}