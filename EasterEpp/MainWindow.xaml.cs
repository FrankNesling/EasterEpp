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
        new int[] {677,300, 73, 90},
        new int[] {275,350, 30, 200},
        new int[] {410,35, 0, 100},
    },
      ["de"] = new int[][]
    {
        new int[] {273,145, 0, 70},
        new int[] {497,177, 53, 60},
        new int[] {312,470, 15, 50},
    },
      ["lt"] = new int[][]
    {
        new int[] {87,480, 0, 120},
        new int[] {468,170, 0, 30},
        new int[] {618,190, 0, 60},
    },
      ["pl"] = new int[][]
    {
        new int[] {207,423, 15, 65},
        new int[] {456,348, 0, 40},
        new int[] {643,50, 0, 110},
    },
      ["tw"] = new int[][]
    {
        new int[] {75,30, 330, 70},
        new int[] {484,406, 90, 50},
        new int[] {728,62, 320, 65},
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