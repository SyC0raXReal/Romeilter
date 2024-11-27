using System.Diagnostics.CodeAnalysis;

namespace Romeilter.Models;

[method: SetsRequiredMembers]
public class SkillGroupModel(string name, params SkillModel[] skills)
{
    public required string GroupName { get; set; } = name;
    public required List<SkillModel> Skills { get; set; } = [.. skills];

    public int BaseBoni => GetBaseBoni(Skills);

    public int FlashInspiration => (int)Math.Round((decimal)BaseBoni / 10, MidpointRounding.AwayFromZero);

    private static int GetBaseBoni(List<SkillModel> skills)
    {
        decimal sum = skills.Sum(q => q.Value);
        return (int)Math.Round(sum / 10, MidpointRounding.AwayFromZero);
    }
}