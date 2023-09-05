using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization.Metadata;

abstract class NonCornerTile : ITile
{   // draw of the  non corner tile
    private int id;
    public static int Width = 112;
    public static int Height = 198;
    int ITile.ID => id;

    public abstract int BelongTo { get; set; }

    public abstract void Draw(SpriteBatch batch);

    public abstract Point position(int playerId);
    public abstract void DosomethingToPlayer(IPlayer player);
}
