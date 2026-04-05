using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
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
      var uri = new Uri($"/images/wimmelbilder/{imageId}.jpeg", UriKind.Relative);
      MainImage.Source = new BitmapImage(uri);

      if (!main.State.FoundPerImage.ContainsKey(imageId))
        main.State.FoundPerImage[imageId] = 0;
    }

    private void FoundObject(object sender, RoutedEventArgs e)
    {
      Button btn = (Button)sender;

      if (!btn.IsEnabled)
        return;

      btn.IsEnabled = false;

      // remove image
      var image = btn.Content as Image;

      if (image != null)
        image.Source = null;

      // update scores
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