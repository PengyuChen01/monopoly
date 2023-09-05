using Microsoft.Xna.Framework.Graphics;
using System.Text.Json.Serialization.Metadata;

interface IRoundState
{
    IRoundState Update(IMonopolyDelegate monoply); // who's turn, draw 
                                                   // update state, ex: start to roll
    void Draw(SpriteBatch batch);

}
