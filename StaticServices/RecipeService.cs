using Romeilter.Models;

namespace Romeilter.StaticServices;
public static class RecipeService
{
    public static HashSet<AlchemyRecipeModel> AlchemyRecipes = [
        new () {
            Name = "Stärketrank",
            Description = "Stärkt den Körper für kurze Zeit",
            Effect = "(Fertigkeit) Boni auf Handeln für 1 Minute",
            FirstIngredient = PlantService.Mate,
            SecondIngredient = PlantService.Water,
            Grenade = false,
            Postive = true,
            Rarity = Rarity.Uncommon,
            Cost = 5,
            Currency = Currency.Silver,
        },
        new () {
            Name = "Schwächungswurftrank",
            Description = "Stärkt den Körper für kurze Zeit",
            Effect = "(Fertigkeit + Wasseranteil) Boni auf Handeln für 1 Minute, verdunstungsbereich (Fertigkeit + Alkoholanteil)",
            FirstIngredient = PlantService.Blutwurz,
            SecondIngredient = PlantService.Water,
            ThirdIngredient = PlantService.Alcohol,
            Grenade = true,
            Postive = false,
            Rarity = Rarity.Uncommon,
            Cost = 7,
            Currency = Currency.Silver,
        }
    ];
}