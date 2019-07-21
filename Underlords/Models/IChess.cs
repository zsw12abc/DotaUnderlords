namespace Underlords.Models
{
    public interface IChess
    {
        void Move();
        void Attack(Chess target);
        void Kill(Chess target);
    }
}