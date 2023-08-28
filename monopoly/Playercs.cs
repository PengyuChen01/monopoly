using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using monopoly;


class Player : IPlayer
{
    
    private int playerId;

    Rectangle desination = new Rectangle(0, 0, 20, 20);
    public int PlayerID => playerId;
    private int tile;
    public int Tile { 
        get => tile; 
        set => tile = value; 
    }
    public Point Position { set => desination.Location = value; }

    public Player(int id)
    {
        playerId = id;
    }
    public void Draw(SpriteBatch batch)
    {
        batch.Draw(Game1.thimbleTexture, desination, null, Color.White);
    }

    public void update()
    {
        throw new System.NotImplementedException();
    }
}
