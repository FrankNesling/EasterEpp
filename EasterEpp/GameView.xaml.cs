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

    public GameView(MainWindow mainWindow, string imageId, int[][] eeCoord)
    {
      InitializeComponent();

      // background
      main = mainWindow;
      this.imageId = imageId;
      var uri = new Uri($"/images/wimmelbilder/{imageId}.jpeg", UriKind.Relative);
      MainImage.Source = new BitmapImage(uri);

      if (!main.State.FoundPerImage.ContainsKey(imageId))
        main.State.FoundPerImage[imageId] = 0;

      // easter eggs
      for (int i = 0; i < 3; i++)
      {
        double scale = eeCoord[i][3] / 100.0;

        var btn = new Button
        {
          Width = 30 * scale,
          Height = 30 * scale,
          Content = new Image
          {
            Source = new BitmapImage(new Uri("/images/ee.png", UriKind.Relative))
          }
        };

        Canvas.SetLeft(btn, eeCoord[i][0]);
        Canvas.SetTop(btn, eeCoord[i][1]);

        btn.Click += FoundObject;

        var image = btn.Content as Image;

        if (image != null)
        {
          image.LayoutTransform = new RotateTransform(eeCoord[i][2]);
        }

          GameCanvas.Children.Add(btn);
      }
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