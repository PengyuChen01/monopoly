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

class JailTile : CornerTile,ITile
{

    private int id;

    int ITile.ID => id;

    public int BelongTo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    Rectangle source; 
    Rectangle destination;

    public JailTile(int id)
    {
        //load your texture
        // e.g. gameBoard = Content.Load<Texture2D>("monopoly");
        this.id = id;
        source = this.srcRectFromID();
        destination = this.dstRectFromID();
        
    }
    private Rectangle srcRectFromID()
    {
        // intialize the position of jail tile in the board without moving
        return new Rectangle(0, 7+ 33 + 9*16, 33, 33);
    }
    private Rectangle dstRectFromID()
    {
        return new Rectangle((int)(Game1.scale * source.X), (int)(Game1.scale * source.Y), (int)(Game1.scale * source.Width), (int)(Game1.scale * source.Height));

    }


    public void Draw(SpriteBatch batch)
    {

        batch.Draw(Game1.boardTexture, destination, source, Color.White);
        
    }

    public Point position(int playerId)
    {
        return destination.Center;
    }
    /**
    public void DosomethingToPlayer(IPlayer player)
    {
        throw new NotImplementedException();
    }
    **/
}


