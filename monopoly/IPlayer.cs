
using Microsoft.Xna.Framework;

interface IPlayer : IDisplayable
{
    int Tile { get; set; }
    int PlayerID { get; }
    void update(); // 人物钱

    Point Position { set; }
}
