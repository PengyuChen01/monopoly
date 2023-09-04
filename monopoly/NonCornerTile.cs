using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization.Metadata;

abstract class NonCornerTile : ITile
{   // draw of the  non corner tile
    private int id;
    public static int Width = 108;
    public static int Height = 216;
    int ITile.ID => id;

    public int BelongTo { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public abstract void Draw(SpriteBatch batch);

    public abstract Point position(int playerId);
    public abstract void DosomethingToPlayer(IPlayer player);
}
