namespace Romeilter.Models;

public class AlchemyRecipeModel : IRarity, ICurrency
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required AlchemyPlantModel FirstIngredient { get; set; }
    public AlchemyPlantModel? SecondIngredient { get; set; }
    public AlchemyPlantModel? ThirdIngredient { get; set; }
    public required string Effect { get; set; }
    public bool Positive { get; set; }
    public bool Grenade { get; set; }
    public decimal Cost { get; set; }
    public Currency Currency { get; set; }
    public Rarity Rarity { get; set; }
}