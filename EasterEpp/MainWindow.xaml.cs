using System.Windows;

// hr, ch, de, lt, pl, tw, at, cn, it

namespace EasterEpp
{
  public partial class MainWindow : Window
  {
    public GameState State = new GameState();
    Dictionary<string, GameView> wimmelGames = new();
    Dictionary<string, int[][]> eeCoords = new Dictionary<string, int[][]>
    {
      ["hr"] = new int[][]
    {
        new int[] {50,345, 0, 80},
        new int[] {550,40, 30, 30},
        new int[] {300,380, 0, 60},
    },
      ["ch"] = new int[][]
    {
        new int[] {50,20, 45, 100},
        new int[] {10,20, 30, 200},
        new int[] {30,80, 45, 50},
    },
      ["de"] = new int[][]
    {
        new int[] {50,20, 45, 100},
        new int[] {10,20, 30, 200},
        new int[] {30,80, 45, 50},
    },
      ["lt"] = new int[][]
    {
        new int[] {50,20, 45, 100},
        new int[] {10,20, 30, 200},
        new int[] {30,80, 45, 50},
    },
      ["pl"] = new int[][]
    {
        new int[] {50,20, 45, 100},
        new int[] {10,20, 30, 200},
        new int[] {30,80, 45, 50},
    },
      ["tw"] = new int[][]
    {
        new int[] {50,20, 45, 100},
        new int[] {10,20, 30, 200},
        new int[] {30,80, 45, 50},
    },
      ["at"] = new int[][]
    {
        new int[] {50,20, 45, 100},
        new int[] {10,20, 30, 200},
        new int[] {30,80, 45, 50},
    },
      ["cn"] = new int[][]
    {
        new int[] {50,20, 45, 100},
        new int[] {10,20, 30, 200},
        new int[] {30,80, 45, 50},
    },
      ["it"] = new int[][]
    {
        new int[] {50,20, 45, 100},
        new int[] {10,20, 30, 200},
        new int[] {30,80, 45, 50},
    }
    };


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
        wimmelGames[imageId] = new GameView(this, imageId, eeCoords[imageId]);
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