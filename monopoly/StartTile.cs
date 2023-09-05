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

class StartTile : CornerTile
{

    private int id;

    int ID => id;


    Rectangle source = new Rectangle(0, 0, 108, 216); 
    Rectangle destination;


    public StartTile(int id)
    {
        //load your texture
        // e.g. gameBoard = Content.Load<Texture2D>("monopoly");
        this.id = id;
        source = this.srcRectFromID();
        destination = this.dstRectFromID();

    }
    private Rectangle srcRectFromID()
    {
        return new Rectangle(distanceToCorner, distanceToCorner, Width, Height);
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
        // switch 每个不同的id
        return destination.Center;
    }

     public override void DosomethingToPlayer(IPlayer player)
    {
        throw new NotImplementedException();
    }

    
}


