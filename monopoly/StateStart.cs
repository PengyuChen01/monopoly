using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using monopoly;
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
        batch.DrawString(Game1.font, "Player " + player.PlayerID 
          + "\nplease press enter to roll dice!", new Vector2(Constant.strRollDiceDesX, Constant.strRollDiceDesY), Color.Black); // display ask player to roll in the right
        //batch.DrawString(Game1.font, "Player " + "0:", new Vector2(Constant.strRollDiceDesX,Constant.strRollDiceDesY),Color.Black);
    }
}
