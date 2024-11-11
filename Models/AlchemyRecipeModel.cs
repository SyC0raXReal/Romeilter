namespace Romeilter.Models;

public class AlchemyRecipeModel
{
    public required AlchemyPlantModel FirstIngredient { get; set; }
    public required AlchemyPlantModel SecondIngredient { get; set; }
    public AlchemyPlantModel? ThirdIngredient { get; set; }
    public required string Effect { get; set; }
    public bool Postive { get; set; }
    public bool Grenade { get; set; }
    public decimal Cost { get; set; }
    public Currency Currency { get; set; }
}