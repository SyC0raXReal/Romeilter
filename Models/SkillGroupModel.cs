namespace Romeilter.Models;

public class SkillGroupModel
{
    public required string GroupName { get; set; }
    public required List<SkillModel> Skills { get; set; }

    public int BaseBoni => GetBaseBoni(Skills);

    public int FlashInspiration => (int)Math.Round((decimal)BaseBoni / 10, MidpointRounding.AwayFromZero);

    private static int GetBaseBoni(List<SkillModel> skills)
    {
        decimal sum = skills.Sum(q => q.Value);
        return (int)(Math.Round(sum / 100, MidpointRounding.AwayFromZero) * 10);
    }
}