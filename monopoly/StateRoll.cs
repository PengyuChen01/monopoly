using Microsoft.Xna.Framework.Graphics;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text.Json.Serialization.Metadata;

class StateRoll : IRoundState
{
    private IPlayer _player;
    public StateRoll(IPlayer player)
    {
        this._player = player;
    }

    public void Draw(SpriteBatch batch)
    {
        
    }

    public IRoundState Update(IMonopolyDelegate monoply)
    {
        Random random = new Random();
        int dice =  random.Next(1,6);

        return new StateMoving(_player, dice);
    }


}
