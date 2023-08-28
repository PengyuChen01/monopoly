using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

class MonopolyGamesSystem : IGameSystem, IMonopolyDelegate
{

    
    int turns = 0;
    ITile[] tiles = new ITile[40]; // position
    List<IRoundState> players = new List<IRoundState>();
    List<IDisplayable> sprites = new List<IDisplayable>();
    
    public void addTile(int id, ITile tile)
    {
        sprites.Add(tile);
        tiles[id] = tile;
        
    }
    public void setUp()
    {
        for (int i = 21; i < 30; i++)
        {
            addTile(i, new RealEstateTile(i));
        }
        for(int j = 1; j < 10; j++)
        {
            addTile(j, new RealEstateTile((int)j));
        }
        for (int j = 11; j < 20; j++)
        {
            addTile(j,new RealEstateTile((int)j));
        }
        for (int j = 31; j < 40; j++)
        {
            addTile(j,new RealEstateTile((int)j));
        }
        addTile(10,new JailTile(0));
        addTile(0,new StartTile(0));
        addTile(30,new PoliceTile(0));
        addTile(20,new ParkingTile(0));
        IPlayer player = new Player(0);
        IPlayer player2 = new Player(1);
       
        players.Add(new StateStart(player));
        sprites.Add(player); 

    }



    public void update()
    {
        players[turns] = players[turns].Update(this);
    }


    public void draw(SpriteBatch batch)
    {
        foreach (IDisplayable sprite in sprites)
        {
           sprite.Draw(batch);
        }
    }

    void IMonopolyDelegate.nextTurn()
    {
        turns = (turns + 1) % turns;
    }

    public Point getPlayerPositionOnTile(int tileId, int playerId)
    {
        return tiles[tileId].position(playerId);
    }
}
