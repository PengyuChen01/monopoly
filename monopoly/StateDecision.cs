using Microsoft.Xna.Framework.Graphics;
using System.Text.Json.Serialization.Metadata;

class StateDecision : IRoundState
{
    public void Draw(SpriteBatch batch)
    {
        throw new System.NotImplementedException();
    }

    public IRoundState Update(IMonopolyDelegate monoply)
    {
        return this;
    }
}
