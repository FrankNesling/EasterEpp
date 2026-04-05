using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace EasterEpp
{
  public partial class MainWindow : Window
  {
    public GameState State = new GameState();
    Dictionary<string, GameView> wimmelGames = new Dictionary<string, GameView>();

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
      if (!wimmelGames.ContainsKey(imageId))
      {
        wimmelGames[imageId] = new GameView(this, imageId);
      }
      
      MainContent.Content = wimmelGames[imageId];
      UpdateScore();
    }

    public void UpdateScore()
    {
      GlobalScore.Text = $"Total: {State.TotalFound} / {State.TotalAvailable}";
    }
  }
}