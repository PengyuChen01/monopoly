using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text.Json.Serialization.Metadata;

class StateMoving : IRoundState
{   
    private IPlayer player;
    public StateMoving(IPlayer player,int dice)
    {
        this.player = player;
        this.player.Tile = (this.player.Tile + dice) % 40;
        
    }
    IRoundState IRoundState.Update(IMonopolyDelegate monoply)
    {

        monoply.nextTurn(); 
        return new StateStart(player);
    }
}
