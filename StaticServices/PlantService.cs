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
        Description = "Hochprozentiger Alkohol",
        Effect = "Lässt die Planzlichen Effekte verdunsten wodurch diese durch Atmung aufgenommen werden können.",
        Occurance = "weltweit",
        Positive = true,
        Rarity = Rarity.Common,
    };

    public static AlchemyPlantModel Oil = new()
    {
        Name = "Öl",
        Description = "pflanzliches Öl",
        Effect = "Verlängert den effekt eines Trankes, kann bei hohem Anteil im Rezept den Effekt auch abschwächen.",
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
        Effect = "Man fühlt sich geschwächt und wird von einer starken Übelkeit übernommen. Bei Hautkontakt kommt es zu Rötungen und Juckreitz. -5 Malus auf Handeln, Konzentration für 1 Minute",
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

    public static AlchemyPlantModel Athelas = new()
    {
        Name = "Athelas",
        Description = "Kleines kraut, was mit kleinen weiß-gelblichen Blüten blüht",
        Effect = "Heilt schwache wunden, + 1W10 Lebenspunkte",
        Occurance = "weltweit, wächst oft an schattigen feuchten plätzen zusammen mit Moos",
        Positive = true,
        Rarity = Rarity.Common,
    };

    public static AlchemyPlantModel Hayati = new()
    {
        Name = "Hayati",
        Description = "Eine gelbe Apfelähliche Frucht die an Hayati-Bäumen wächst. Wird traditionell von den Ahianern auf Reisen mitgenommen.",
        Effect = "Hilft dem Körper bei der regenation und verkürtzt die benötigte Zeit zum Rasten um 1h",
        Occurance = "Hayati Bäume wachsen nur im Dschungel von Ahian",
        Positive = true,
        Rarity = Rarity.Uncommon,
    };

    public static AlchemyPlantModel Rauchkraut = new()
    {
        Name = "Rauchkraut",
        Description = "Ein kleines gräuliches Kraut was man zwischen den Felsen im Gebirge findet",
        Effect = "Produziert beim verbrennen extrem starken Rauch. -15 Handeln Malus auf Sichttätigkeiten wenn man sich in dem Rauch befindet",
        Occurance = "In Gebirgen über der Baumgrenze",
        Positive = true,
        Rarity = Rarity.Uncommon,
    };

    public static AlchemyPlantModel Blutkraut = new()
    {
        Name = "Blutkraut",
        Description = "Ein kleines unbekanntes rotes Kraut, mit dicken venenartigen Zweigen. Seit dem Erwachen der Magie schweben dessen Samen magisch durch die Luft.",
        Effect = "Verleichtert den Körper damit man viel höher springen kann und langsamer zu boden gleited. Erhöht sprungdistanz auf 20m und verhindert Fallschaden für 1 Minute",
        Occurance = "Tief im Gebirge von Iqua, wird selten von den Riesen angebaut.",
        Positive = true,
        Rarity = Rarity.Rare,
    };

    public static AlchemyPlantModel Schlafbeeren = new()
    {
        Name = "Schlafbeeren",
        Description = "Kleine schwarze Beeren die im Dschungel von Ahian wachsen. Wird für medizinische Eingriffe der Heiler der Ahianer genutzt.",
        Effect = "Der betroffene verfällt für 10 Minuten in einen tiefen schlaf, von dem man nur schwer aufgeweckt werden kann.",
        Occurance = "Im Dschungel von Ahian.",
        Positive = false,
        Rarity = Rarity.Uncommon,
    };

    public static AlchemyPlantModel Eisenhut = new()
    {
        Name = "Eisenhut",
        Description = "Eine blau gräuliche Blume die einem Ritterhelm ähnelt und einen giftigen Saft hat. Schmeckt leicht nach Eisen.",
        Effect = "Fügt bei Verzehr 3 W10 an den Lebenspunkten zu",
        Occurance = "Wächst in Wäldern weltweit, oft in der Nähe von Eichenbäumen",
        Positive = false,
        Rarity = Rarity.Common,
    };

    public static HashSet<AlchemyPlantModel> AlchemyIngredients = [
        Water,
        Alcohol,
        Oil,
        Schimmerwurz,
        Mate,
        Blutwurz,
        Tzabra,
        Athelas,
        Hayati,
        Rauchkraut,
        Schlafbeeren,
        Eisenhut,
    ];
}