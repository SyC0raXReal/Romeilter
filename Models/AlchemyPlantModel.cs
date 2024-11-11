namespace Romeilter.Models;

public class AlchemyPlantModel
{
    public required string Name { get; set; }
    public Rarity Rarity { get; set; }
    public required string Occurance { get; set; }
    public required string Effect { get; set; }
    public bool Positive { get; set; }
}