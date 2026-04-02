using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace EasterEpp
{
  public partial class GameView : UserControl
  {
    private MainWindow main;
    private string imageId;

    public GameView(MainWindow mainWindow, string imageId)
    {
      InitializeComponent();

      main = mainWindow;
      this.imageId = imageId;

      MainImage.Source = new BitmapImage(
          new System.Uri($"Images/{imageId}.jpg", System.UriKind.Relative));

      if (!main.State.FoundPerImage.ContainsKey(imageId))
        main.State.FoundPerImage[imageId] = 0;
    }

    private void FoundObject(object sender, RoutedEventArgs e)
    {
      Button btn = (Button)sender;

      if (!btn.IsEnabled)
        return;

      btn.IsEnabled = false;

      main.State.TotalFound++;
      main.State.FoundPerImage[imageId]++;

      main.UpdateScore();
    }

    private void Back(object sender, RoutedEventArgs e)
    {
      main.ShowMenu();
    }
  }
}