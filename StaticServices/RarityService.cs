using Romeilter.Models;

namespace Romeilter.StaticServices;
public static class RarityService
{
    public static string CssClass(this Rarity rarity)
    {
        return rarity switch
        {
            Rarity.Common => "mud-common",
            Rarity.Uncommon => "mud-success text-dark",
            Rarity.Rare => "mud-info text-dark",
            Rarity.Mythic => "mud-warning text-dark",
            Rarity.Legendary => "mud-error text-dark",
            _ => "mud-common",
        };
    }
}