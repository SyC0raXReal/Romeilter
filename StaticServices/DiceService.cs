using System.Security.Cryptography;

namespace Romeilter.StaticServices;

public static class DiceService
{
    public static int Roll10(int modifier = 0, int factor = 1)
    {
        var sum = 0;
        for (int i = 1; i <= factor; i++)
        {
            sum += RandomNumberGenerator.GetInt32(1, 11);
        }
        return sum + modifier;
    }
}