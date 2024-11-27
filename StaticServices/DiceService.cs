using System.Security.Cryptography;
using Romeilter.Models;

namespace Romeilter.StaticServices;

public static class DiceService
{
    public static int Roll(DiceType type, int modifier = 0, int factor = 1)
    {
        var sum = 0;
        for (int i = 1; i <= factor; i++)
        {
            sum += GetRoller(type);
        }
        return sum + modifier;
    }

    public static (int, SkillCheckResult) SkillCheck(int skill)
    {
        var roll = Roll(DiceType.D100);
        var succ = roll <= skill;
        var fail = roll > skill;
        var critSucc = roll <= skill * 0.1;
        var critFail = roll >= 100 - ((100 - skill) * 0.1);
        if (critFail)
        {
            return (roll, SkillCheckResult.CritFail);
        }
        else if (fail)
        {
            return (roll, SkillCheckResult.Fail);
        }
        else if (critSucc)
        {
            return (roll, SkillCheckResult.CritSucc);
        }
        else if (succ)
        {
            return (roll, SkillCheckResult.Succ);
        }
        else
        {
            throw new NotImplementedException("skill check failed");
        }
    }

    public static string GetDiceTypeName(DiceType type)
    {
        return type switch
        {
            DiceType.D10 => "D10",
            DiceType.D100 => "D100",
            _ => throw new NotImplementedException("no device type found"),
        };
    }

    private static int GetRoller(DiceType type)
    {
        return type switch
        {
            DiceType.D10 => RandomNumberGenerator.GetInt32(1, 11),
            DiceType.D100 => RandomNumberGenerator.GetInt32(1, 101),
            _ => throw new NotImplementedException("no device type found"),
        };
    }
}