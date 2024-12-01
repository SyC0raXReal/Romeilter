using System.Diagnostics.CodeAnalysis;

namespace Romeilter.Models;

[method: SetsRequiredMembers]
public class SkillModel(string name, int value, int bonus = 0)
{
    public required string Name { get; set; } = name;
    public int Value { get; set; } = value;
    public int Bonus { get; set; } = bonus;
}