using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using monopoly;
using System.Text.Json.Serialization.Metadata;

class StateDecision : IRoundState
{
    private IPlayer player;
    bool isKeyDown = false;

    public StateDecision(IPlayer player)
    {
        this.player = player;

    }
    public void Draw(SpriteBatch batch)
    {
        batch.DrawString(Game1.font, "Player " + player.PlayerID + "\n" + player.toString(), new Vector2(Constant.strRollDiceDesX, Constant.strRollDiceDesY + 100), Color.Black);
        
    }

    public IRoundState Update(IMonopolyDelegate monopoly)
    {
       
        var kstate = Keyboard.GetState();

        if (kstate.IsKeyDown(Keys.Enter))
        {
            isKeyDown = true;
        }
        else if (isKeyDown)
        {
            monopoly.nextTurn();
            return new StateStart(player);
        }
        if (kstate.IsKeyDown(Keys.B))
        {
            // 1. able to buy tile?
            // 2. buy tile
            // 3. string output what key is buy and what key is not buy
            
        }
        return this; // don't change state without pressing enter

    }
}
