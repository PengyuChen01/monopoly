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

class RealEstateTile : NonCornerTile,ITile
{

    private int id;
   
    int ITile.ID => id;

    public int BelongTo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    Rectangle source = new Rectangle(0, 0, 79, 59);
    Rectangle desination = new Rectangle(0, 0, 79, 59);
   

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
        // modify the size of the tile except the corner
        var map = new Dictionary<int, Rectangle>();
        if(this.id <= 10)
        {

             int x = 33 + (9 - this.id) * 16;
             int y = 7 + 9 * 16 + 33;
            /**  int x = 1404;
           int y = 1404;
         **/
            return new Rectangle(x, y, 79, 59);
        }
        else if(this.id <= 20)
        {
             int x = 0;
            int y = 7 + (19-this.id)* 16 + 33;
            /**  int x = 1404;
               int y = 1404;
             **/
            return new Rectangle(x, y, 79, 59);
        }
        else if (this.id <= 30)
        {
            int x = 33 + (this.id - 21) * 16;
            int y = 7;
          /**  int x = 1404;
            int y = 1404;
          **/
            return new Rectangle(x, y, 79, 59);
  
           
        }
        else
        {
            int x = 33 + 16 * 9;
            int y = 7 + (this.id-31) * 16 + 33;
            return new Rectangle(x, y, 79, 59);
        }
    }
    private Rectangle dstRectFromID()
    {
        return new Rectangle((int)(Game1.scale * source.X), (int)(Game1.scale*source .Y), (int)(Game1.scale * source.Width), (int)(Game1.scale * source.Height));
      
    }


    public void Draw(SpriteBatch batch)
    {
        // fix the problem of rotation the board
       // if (this.id > 20 && this.id < 30)
        //{
            batch.Draw(Game1.boardTexture, desination, source, Color.White);
            //batch.DrawString(Game1.font, "" + id, new Vector2(desination.Location.X,desination.Location.Y), Color.Gray);
        //}
       // else
        //{
        //    batch.Draw(Game1.boardTexture, desination, source, Color.White);
           // batch.DrawString(Game1.font, "" + id, new Vector2(desination.Location.X, desination.Location.Y), Color.Gray);
        //}
    }

    public Point position(int playerId)
    {
        return desination.Center;
    }

    public void DosomethingToPlayer(IPlayer player)
    {
        throw new NotImplementedException();
    }

    public override void Draw(SpriteBatch batch)
    {
        throw new NotImplementedException();
    }

    public override Point position(int playerId)
    {
        throw new NotImplementedException();
    }

    public override void DosomethingToPlayer(IPlayer player)
    {
        throw new NotImplementedException();
    }
}


