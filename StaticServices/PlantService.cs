using Romeilter.Models;

namespace Romeilter.StaticServices;
public static class PlantService
{
    public static AlchemyPlantModel Water = new()
    {
        Name = "Wasser",
        Description = "Klares reines Brunnenwasser",
        Effect = "Verstärkt die Pflanzlichen Effekte bei Trankherstellung",
        Occurance = "weltweit",
        Positive = true,
        Rarity = Rarity.Common,
    };

    public static AlchemyPlantModel Alcohol = new()
    {
        Name = "Alkohol",
        Description = "Hochprozentiger",
        Effect = "Lässt die Planzlichen Effekte verdunsten wodurch diese durch Atmung aufgenommen werden können.",
        Occurance = "weltweit",
        Positive = true,
        Rarity = Rarity.Common,
    };

    public static AlchemyPlantModel Schimmerwurz = new()
    {
        Name = "Schimmerwurz",
        Description = "Eine kleine leuchtendes Gewächs mit dunkelblauen Blättern und einer großen schimmernden Wurzelknolle",
        Effect = "Lässt Objekte und Lebewesen für 1 h leuchten",
        Occurance = "Kann weltweit in feuchten und dunklen Orten gefunden werden",
        Positive = true,
        Rarity = Rarity.Common,
    };

    public static AlchemyPlantModel Mate = new()
    {
        Name = "Mate",
        Description = "Ein kleines unscheinbares gewächs, mit dunkelgrünen kleinen herzgeförmten Blättern",
        Effect = "Man fühlt sich gestärkt und hat für 1 Minute +5 Boni auf Handeln",
        Occurance = "In Cherstans Trockensteppen",
        Positive = true,
        Rarity = Rarity.Uncommon,
    };

    public static AlchemyPlantModel Blutwurz = new()
    {
        Name = "Blutwurz",
        Description = "Die Blutrote Wurzel des gelben Enzian, hat einen sehr bitteren geschmack.",
        Effect = "Man fühlt sich geschwächt und wird von einer starken Übelkeit übernommen. Bei Hautkontakt kommt es zu Rötungen und Juckreitz. -5 Malus auf Handeln, Konzentration",
        Occurance = "In den Sümpfen im Norden Cherstans / Südosten von Ahian",
        Positive = false,
        Rarity = Rarity.Uncommon,
    };

    public static AlchemyPlantModel Tzabra = new()
    {
        Name = "Tzabra",
        Description = "Auffallend rote längliche Kaktusfurcht, schmeckt sehr süßlich.",
        Effect = "Löst bei verzehr kurzzeitig starke Glückgefühle aus. Bei übermäßigen verzehr betäubt es die Nerven und verlangsamt den Geist.",
        Occurance = "In Cherstans Trockensteppen",
        Positive = false,
        Rarity = Rarity.Common,
    };

    public static HashSet<AlchemyPlantModel> AlchemyIngredients = [
        Water,
        Alcohol,
        Schimmerwurz,
        Mate,
        Blutwurz,
        Tzabra,
    ];
}