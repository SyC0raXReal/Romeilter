namespace Romeilter.Models;

public class AbilityExampleModel
{
    public required string AbilityGroup { get; set; }
    public required string AbilityName { get; set; }
    public string? Effect { get; set; }
    public string? Requirement { get; set; }
}