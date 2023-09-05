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

class ParkingTile : CornerTile
{

    private int id;

    int ID => id;

   
  

  

    Rectangle source = new Rectangle(0, 0, Width, Height);
    Rectangle destination;


    public ParkingTile(int id)
    {
        //load your texture
        // e.g. gameBoard = Content.Load<Texture2D>("monopoly");
        this.id = id;
        source = this.srcRectFromID();
        destination = this.dstRectFromID();

    }
    private Rectangle srcRectFromID()
    {
        // intialize the position of parking tile in the board without moving
        return new Rectangle(0, 0, Width, Height);
    }
    private Rectangle dstRectFromID()
    {
        return new Rectangle((int)(Game1.scale * source.X), (int)(Game1.scale * source.Y), (int)(Game1.scale * source.Width), (int)(Game1.scale * source.Height));

    }


    public override void Draw(SpriteBatch batch)
    {

        batch.Draw(Game1.boardTexture, destination, source, Color.White);

    }

    public override Point position(int playerId)
    {
        return destination.Center;
    }

    public override void DosomethingToPlayer(IPlayer player)
    {
        throw new NotImplementedException();
    }

    /**
public void DosomethingToPlayer(IPlayer player)
{
   throw new NotImplementedException();
}
**/
}


