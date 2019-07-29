namespace Underlords.Models
{
    public interface IChess
    {
        void Move(Chess target);
        void Attack(Chess target);
        void Kill(Chess target);
    }
}