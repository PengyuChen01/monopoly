
using Microsoft.Xna.Framework;

interface IMonopolyDelegate
{
    void nextTurn();

    Point getPlayerPositionOnTile(int tileId, int playerId);
}
