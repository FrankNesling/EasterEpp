using System.Windows;

namespace EasterEpp
{
  public partial class MainWindow : Window
  {
    public GameState State = new GameState();

    public MainWindow()
    {
      InitializeComponent();
      ShowMenu();
      UpdateScore();
    }

    public void ShowMenu()
    {
      MainContent.Content = new MenuView(this);
      UpdateScore();
    }

    public void OpenGame(string imageId)
    {
      MainContent.Content = new GameView(this, imageId);
      UpdateScore();
    }

    public void UpdateScore()
    {
      GlobalScore.Text = $"Total: {State.TotalFound} / {State.TotalAvailable}";
    }
  }
}