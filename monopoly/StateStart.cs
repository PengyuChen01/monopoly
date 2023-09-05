using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Text.Json.Serialization.Metadata;

class StateStart : IRoundState
{
    IPlayer player;
    public StateStart(IPlayer player)
    {
        this.player = player;
    }

    bool isKeyDown = false;
     
    public IRoundState Update(IMonopolyDelegate monopoly)
    {
        var kstate = Keyboard.GetState();
        player.Position = monopoly.getPlayerPositionOnTile(player.Tile, player.PlayerID);
        if (kstate.IsKeyDown(Keys.Enter))
        {
            isKeyDown = true;
        }
        else if (isKeyDown) return new StateRoll(player);
        return this;
    }

    public void Draw(SpriteBatch batch)
    {
       
    }
}
