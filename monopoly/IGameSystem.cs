using Microsoft.Xna.Framework.Graphics;
using System.Text.Json.Serialization.Metadata;

interface IGameSystem
{
    void setUp();
    void update();

    void draw(SpriteBatch batch);
}
