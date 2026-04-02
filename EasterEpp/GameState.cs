using System.Collections.Generic;

namespace EasterEpp
{
  public class GameState
  {
    public int TotalFound { get; set; }
    public int TotalAvailable { get; set; } = 50;

    public Dictionary<string, int> FoundPerImage { get; set; } = new();
  }
}