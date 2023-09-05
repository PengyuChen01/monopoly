﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using monopoly;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text.Json.Serialization.Metadata;
using static System.Formats.Asn1.AsnWriter;

class RealEstateTile : NonCornerTile
{

    private int id;
   
    int ID => id;

    public override int BelongTo { get => belongTo; set => belongTo = value; }
    private int belongTo = -1;
    Rectangle source = new Rectangle(0, 0, 108, 216); // png starting point
    Rectangle destination = new Rectangle(0, 0, Width, Height); // computer starting point

    Texture2D[] textures =
    {
        Game1.battleshipTexture,
        Game1.thimbleTexture,
        Game1.hatTexture,
        Game1.racecarTexture

    };
    public RealEstateTile(int id)
    {
        //load your texture
        // e.g. gameBoard = Content.Load<Texture2D>("monopoly");
        this.id = id;
        source = this.srcRectFromID();
        destination = this.dstRectFromID();
       
    }
    private Rectangle srcRectFromID()
    {
        // modify the size of the tile except the corner
        var map = new Dictionary<int, Rectangle>();
        if(this.id <= 10)
        {

             int x = Height + (9 - this.id) * Width;
             int y = 9 * Width + Height;
        
         
            return new Rectangle(x, y, Width, Height);
        }
        else if(this.id <= 20)
        {
             int x = 0;
            int y =  (19-this.id)* Width + Height;
            /**  int x = 1404;
               int y = 1404;
             **/
            return new Rectangle(x, y, Height, Width);
        }
        else if (this.id <= 30)
        {
            int x = Height + (this.id - 21) * Width;
            int y = 0;
            return new Rectangle(x, y, Width, Height);
  
           
        }
        else
        {
            int x = Height + Width * 9;
            int y =  (this.id-31) * Width + Height;
            return new Rectangle(x, y, Height, Width);
        }
    }
    private Rectangle dstRectFromID()
    {
        // draw in computer 
        return new Rectangle((int)(Game1.scale * source.X), (int)(Game1.scale*source .Y), (int)(Game1.scale * source.Width), (int)(Game1.scale * source.Height));
    }


    public override void Draw(SpriteBatch batch)
    {
            batch.Draw(Game1.boardTexture, destination, source, Color.White);
        if (belongTo >= 0)
        {
            batch.Draw(textures[belongTo], destination, null, Color.White * 0.25f);
        }
    }

    public override Point position(int playerId)
    {
        // tile's center
        return new Point(destination.Center.X, destination.Center.Y);
    }

    public override void DosomethingToPlayer(IPlayer player)
    {
        
    }
}


