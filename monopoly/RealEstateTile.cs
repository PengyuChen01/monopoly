using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using monopoly;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text.Json.Serialization.Metadata;
using static System.Formats.Asn1.AsnWriter;

class RealEstateTile : ITile
{

    private int id;
   
    int ITile.ID => id;
    Rectangle source = new Rectangle(0, 7, 33, 33);
    Rectangle desination = new Rectangle(0, 0, 33, 33);
   

    public RealEstateTile(int id)
    {
        //load your texture
        // e.g. gameBoard = Content.Load<Texture2D>("monopoly");
        this.id = id;
        source = this.srcRectFromID();
        desination = this.dstRectFromID();
       
    }
    private Rectangle srcRectFromID()
    {
        var map = new Dictionary<int, Rectangle>();
        if(this.id <= 10)
        {
            
            int x = 33 + (9 - this.id) * 16;
            int y = 7 + 9 * 16 + 33;
            return new Rectangle(x, y, 16, 33);
        }
        else if(this.id <= 20)
        {
            int x = 0;
            int y = 7 + (19-this.id)* 16 + 33;
            return new Rectangle(x, y, 33, 16);
        }
        else if (this.id <= 30)
        {
            int x = 33 + (this.id - 21) * 16;
            int y = 7;
            return new Rectangle(x, y, 16, 33);
  
           
        }
        else
        {
            int x = 33 + 16 * 9;
            int y = 7 + (this.id-31) * 16 + 33;
            return new Rectangle(x, y, 33, 16);
        }
    }
    private Rectangle dstRectFromID()
    {
        return new Rectangle((int)(Game1.scale * source.X), (int)(Game1.scale*source .Y), (int)(Game1.scale * source.Width), (int)(Game1.scale * source.Height));
      
    }


    public void Draw(SpriteBatch batch)
    {

        batch.Draw(Game1.boardTexture, desination, source, Color.White);
    }

    public Point position(int playerId)
    {
        return desination.Center;
    }
}


