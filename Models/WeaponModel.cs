using System.Diagnostics.CodeAnalysis;

namespace Romeilter.Models;

[method: SetsRequiredMembers]
public class WeaponModel(string name, int diceCount, DiceType type, int? modifier = null, string? remarks = null)
{
    public required string Name { get; set; } = name;
    public int DiceCount { get; set; } = diceCount;
    public DiceType DiceType { get; set; } = type;
    public int? Modifier { get; set; } = modifier;
    public string? Remarks { get; set; } = remarks;
}