using Underlords.Models;

namespace Underlords.Model.Skills
{
    public interface ISkill
    {
        void Cast(int level, Chess target);
    }
}