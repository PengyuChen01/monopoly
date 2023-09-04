using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Text.Json.Serialization.Metadata;

abstract class CornerTile : ITile
{   // dimension of the corner tile
    private int id;

    public int BelongTo { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public static int Width = 216;
    public static int Height = 216;
    int ITile.ID => id;

    public void Draw(SpriteBatch batch)
    {
        throw new System.NotImplementedException();
    }

    public Point position(int playerId)
    {
        throw new System.NotImplementedException();
    }

    void ITile.DosomethingToPlayer(IPlayer player)
    {
        throw new System.NotImplementedException();
    }
}
