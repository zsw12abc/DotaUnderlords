namespace Underlords.Models.ChessBoard
{
    public class Position : IPosition
    {
        public int x;
        public int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetDistance(Position position2)
        {
            var xDistance = position2.x - x;
            var yDistance = position2.y - y;
            return xDistance > yDistance ? xDistance : yDistance;
        }
    }
}