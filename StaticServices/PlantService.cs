using Romeilter.Models;

namespace Romeilter.StaticServices;
public static class PlantService
{
    public static HashSet<AlchemyPlantModel> AlchemyIngredients = [
        new (){
            Name = "Schimmerwurz",
            Description = "Eine kleine leuchtendes Gewächs mit dunkelblauen Blättern und einer großen schimmernden Wurzelknolle",
            Effect = "Lässt Objekte und Lebewesen für 1 h leuchten",
            Occurance = "Kann weltweit in feuchten und dunklen Orten gefunden werden",
            Positive = true,
            Rarity = Rarity.Common,
        },
    ];
}