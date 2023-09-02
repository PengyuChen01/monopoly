using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using monopoly;


class Player : IPlayer
{
    
    private int playerId;

    Rectangle desination1 = new Rectangle(0, 0, 20, 20);
    Rectangle desination2 = new Rectangle(10, 0, 20, 20);
    Rectangle desination3 = new Rectangle(10, 10, 20, 20);
    Rectangle desination4 = new Rectangle(0, 10, 20, 20);
 //   Point battleshipPosition = desination4.Location;
    public int PlayerID => playerId;
    private int tile;
    public int Tile { 
        get => tile; 
        set => tile = value; 
    }
    public Point Position { 
        
        set => desination1.Location = value;
       // return battleshipPosition = value;
    }

    public Player(int id)
    {
        playerId = id;
    }
    public void Draw(SpriteBatch batch)
    {
     batch.Draw(Game1.thimbleTexture, desination1, null, Color.White);
        batch.Draw(Game1.hatTexture, desination2, null, Color.White);
        batch.Draw(Game1.racecarTexture, desination3, null, Color.White);
        batch.Draw(Game1.battleshipTexture, desination4, null, Color.White);
    }

    public void update()
    {
        throw new System.NotImplementedException();
    }
}
