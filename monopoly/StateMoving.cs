using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using monopoly;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text.Json.Serialization.Metadata;

class StateMoving : IRoundState
{   
    private IPlayer player;
    
    public StateMoving(IPlayer player,int dice)
    {
        this.player = player;
        this.player.Tile = (this.player.Tile + dice) % Constant.totalNumOfTile; // After rolling the dice, the player lands on tile{tile Number}

    }

    public void Draw(SpriteBatch batch)
    {
        
        /*
        if (this.id > 20 && this.id < 30)
        {
            batch.Draw(Game1.boardTexture, desination, source, Color.White, 3.1415926f, new Vector2(desination.Width / 2, desination.Height / 2), 0, 0);
            batch.DrawString(Game1.font, "" + id, new Vector2(desination.Location.X, desination.Location.Y), Color.Gray);
        }
        else
        {
            batch.Draw(Game1.boardTexture, desination, source, Color.White);
            batch.DrawString(Game1.font, "" + id, new Vector2(desination.Location.X, desination.Location.Y), Color.Gray);
        }
        */
    }

    IRoundState IRoundState.Update(IMonopolyDelegate monoply)
    {

        monoply.nextTurn(); 
        return new StateStart(player);
    }
}
