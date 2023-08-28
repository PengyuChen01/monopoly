using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Text.Json.Serialization.Metadata;

interface ITile : IDisplayable
{
    int ID { get; }
    Point position(int playerId);
}


