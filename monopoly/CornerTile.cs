using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Text.Json.Serialization.Metadata;

abstract class CornerTile : ITile
{   // dimension of the corner tile
    private int id;

    public int BelongTo { get => -1; set { } }

    public static int Width = 198;
    public static int Height = 198;
    public static int pictureSize = 1404; // whole picture
    public static int distanceToCorner = 1206;
    int ITile.ID => id;

    public abstract void Draw(SpriteBatch batch);


    public abstract Point position(int playerId);


    public abstract void DosomethingToPlayer(IPlayer player);

    public string toString()
    {
        throw new System.NotImplementedException();
    }
}
