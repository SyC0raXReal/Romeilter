using Romeilter.Models;

namespace Romeilter.StaticServices;
public static class RarityService
{
    public static string CssClass(this Rarity rarity)
    {
        return rarity switch
        {
            Rarity.Common => "mud-common p-2",
            Rarity.Uncommon => "mud-success text-dark p-2",
            Rarity.Rare => "mud-info text-dark p-2",
            Rarity.Mythic => "mud-warning text-dark p-2",
            Rarity.Legendary => "mud-error text-white p-2",
            _ => "mud-common",
        };
    }

    public static string Name(this Rarity rarity)
    {
        return rarity switch
        {
            Rarity.Common => "Gewöhnlich",
            Rarity.Uncommon => "Ungewöhnlich",
            Rarity.Rare => "Selten",
            Rarity.Mythic => "Mythis",
            Rarity.Legendary => "Legendär",
            _ => "Gewöhnlich",
        };
    }
}