namespace Romeilter.Models;

public class NpcModel
{
    public required string Name { get; set; }
    public required string PersonalityTypes { get; set; }
    public int LifePoints { get; set; }
    public NpcGroup Group { get; set; }
    public required ChallengeRating ChallengeRating { get; set; }
    public string? Remarks { get; set; }
    public int ArmorValue { get; set; } = 0;
    public List<WeaponModel>? Weapons { get; set; }
    public required SkillGroupModel Act { get; set; }
    public required SkillGroupModel Knowledge { get; set; }
    public required SkillGroupModel Social { get; set; }
}