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

class PoliceTile : CornerTile
{

    private int id;

    int ID => id;


    Rectangle source = new Rectangle(0, 0, Width, Height);
    Rectangle desination = new Rectangle(0, 0, Width, Height);


    public PoliceTile(int id)
    {
        //load your texture
        // e.g. gameBoard = Content.Load<Texture2D>("monopoly");
        this.id = id;
        source = this.srcRectFromID();
        desination = this.dstRectFromID();

    }
    private Rectangle srcRectFromID()
    {
        return new Rectangle(distanceToCorner, 0, Width, Height);
    }
    private Rectangle dstRectFromID()
    {
        return new Rectangle((int)(Game1.scale * source.X), (int)(Game1.scale * source.Y), (int)(Game1.scale * source.Width), (int)(Game1.scale * source.Height));

    }


    public override void Draw(SpriteBatch batch)
    {

        batch.Draw(Game1.boardTexture, desination, source, Color.White);

    }

    public override Point position(int playerId)
    {
        return desination.Center;
    }

    public override void DosomethingToPlayer(IPlayer player)
    {
        throw new NotImplementedException();
    }

    
}


