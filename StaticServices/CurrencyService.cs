using System.Globalization;
using Romeilter.Models;

namespace Romeilter.StaticServices;
public static class CurrencyService
{
    private static readonly CultureInfo CultureInfo = CultureInfo.GetCultureInfo("de");

    public static string Display(this Currency currency, decimal value)
    {
        return currency switch
        {
            Currency.Bronce => $"{ToString(value)} Bronzekreutzer",
            Currency.Silver => $"{ToString(value)} Silbertaler",
            Currency.Gold => $"{ToString(value)} Goldmünzen",
            _ => $"{value}",
        };
    }

    public static string ToString(decimal value)
    {
        return string.Format(CultureInfo, "{0:N2}", value);
    }
}