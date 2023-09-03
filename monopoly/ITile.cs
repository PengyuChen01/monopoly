using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Text.Json.Serialization.Metadata;

interface ITile : IDisplayable
{
    int ID { get; }
    Point position(int playerId);
    void DosomethingToPlayer(IPlayer player);
    int BelongTo { get; set; } // land belong to who
                               //   -1: can not be trade: start, jail, card
                               //   -2: open to trade
                               //   0-3 : owned by someone (players) 
    
}


