using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using monopoly;
using System.Security.Cryptography;
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
    private int money = 50000;
    private long numOfTilePlayerOwn = 0;
    private string tileDescription = "";
    public int Tile { 
        get => tile; 
        set => tile = value; // tile's position
    }
    public Point Position { 
        
        set => destination.Location = new Point(value.X + offset[playerId].X,value.Y + offset[playerId].Y);

    
    }
    
    public int Money { get => money; set => money = value; }
    public int NumOfTilePlayerOwn { get => (int)numOfTilePlayerOwn; set => numOfTilePlayerOwn = value; }
    public string TileDescription { set => tileDescription = value; } // value same as declare type

    public Player(int id)
    {
        playerId = id;
    }
    public void Draw(SpriteBatch batch)
    {
        batch.Draw(textures[playerId], destination, null, Color.White); // draw player image

    
    }

    public void update()
    {
        throw new System.NotImplementedException();
    }

    public string toString()
    {
        string result =  "Money: " + Money + "\n";
        result += "Number of Tiles Owned: ";
        for (int i = 0; i < 40; i++)
        {
            if((numOfTilePlayerOwn & (1 << i)) != 0)
            {
                result += i + ", ";

            }
        }
        result += "\n" + tileDescription;
        return result;
    }
}
