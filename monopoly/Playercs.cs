using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using monopoly;
using System.Windows.Markup;

class Player : IPlayer
{
    
    private int playerId;
    
    Rectangle destination = new Rectangle(0,0,20,20);
    Point[] offset =
    {
      new Point (0,0),
      new Point (-30, 0),
      new Point (0, -30),
      new Point (-30, -30)
     
};
    Texture2D[] textures =
    {
        Game1.battleshipTexture,
        Game1.thimbleTexture,
        Game1.hatTexture,
        Game1.racecarTexture

    };
 
    public int PlayerID => playerId;
    private int tile;
    public int Tile { 
        get => tile; 
        set => tile = value; // tile's position
    }
    public Point Position { 
        
        set => destination.Location = new Point(value.X + offset[playerId].X,value.Y + offset[playerId].Y);

    
    }

    public Player(int id)
    {
        playerId = id;
    }
    public void Draw(SpriteBatch batch)
    {
        batch.Draw(textures[playerId], destination, null, Color.White);
    
    }

    public void update()
    {
        throw new System.NotImplementedException();
    }
}
