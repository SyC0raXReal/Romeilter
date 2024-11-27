using System.Diagnostics.CodeAnalysis;

namespace Romeilter.Models;

[method: SetsRequiredMembers]
public class SkillModel(string name, int value)
{
    public required string Name { get; set; } = name;
    public int Value { get; set; } = value;
}