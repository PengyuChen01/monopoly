
using Microsoft.Xna.Framework;
using System.Dynamic;

public interface IPlayer : IDisplayable
{
    // player within the game
    int Tile { get; set; } // get tile, set tile function
    int PlayerID { get; }
    void update(); // 人物钱

    Point Position { set; }
    int Money { get; set; }// get money, set money function
    int NumOfTilePlayerOwn { get; set; }
    string toString();
    string TileDescription { set; }

  
}
