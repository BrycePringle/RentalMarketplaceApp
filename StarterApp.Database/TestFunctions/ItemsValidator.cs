using StarterApp.Database.Models;

namespace StarterApp.Database.Helpers;

public static class ItemsValidator
{
    public static double GetEffectiveRadius(double radius)
    {
        return radius > 0 ? radius : 10;
    }
}