
using Microsoft.Xna.Framework;

interface IMonopolyDelegate
{   
    
    void nextTurn();

    Point getPlayerPositionOnTile(int tileId, int playerId);
    void DoSomethingToPlayerOnTile(IPlayer player); // pay rent, draw card, access penalty or rewards.
}
