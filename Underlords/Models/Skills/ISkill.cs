using Underlords.Models;

namespace Underlords.Model.Skills
{
    public interface ISkill
    {
        Skill Use(int level, Chess target);
    }
}