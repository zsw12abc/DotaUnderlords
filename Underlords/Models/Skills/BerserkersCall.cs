using Underlords.Models.ChessBoard;

namespace Underlords.Model.Skills
{
    public interface BerserkersCall : ISkill
    {
        void Taunt(Position position);
    }
}