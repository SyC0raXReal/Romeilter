using Romeilter.Models;

namespace Romeilter.StaticServices;
public static class NpcService
{

    public static string GroupName(NpcGroup group)
    {
        return group switch
        {
            NpcGroup.Bandit => "Bandit",
            NpcGroup.Guard => "Wache",
            NpcGroup.Animal => "Tier",
            NpcGroup.Monstrosity => "Monstrosität",
            NpcGroup.Demon => "Dämon",
            _ => string.Empty,
        };
    }

    public static string ChallengeName(ChallengeRating c)
    {
        return c switch
        {
            ChallengeRating.Easy => "Einfach",
            ChallengeRating.Challenging => "Herausfordernd",
            ChallengeRating.Dangerous => "Gefährlich",
            ChallengeRating.Deadly => "Tödlich",
            _ => string.Empty,
        };
    }

    public static string ChallengeCss(ChallengeRating c)
    {
        return c switch
        {
            ChallengeRating.Easy => "mud-success text-dark p-2",
            ChallengeRating.Challenging => "mud-info text-dark p-2",
            ChallengeRating.Dangerous => "mud-warning text-dark p-2",
            ChallengeRating.Deadly => "mud-error text-white p-2",
            _ => string.Empty,
        };
    }

    public static NpcModel SimpleBandit = new()
    {
        Name = "Einfacher Bandit",
        PersonalityTypes = "kriminell, egoistisch, gierig, gewaltbereit",
        Group = NpcGroup.Bandit,
        ChallengeRating = ChallengeRating.Easy,
        LifePoints = 100,
        Act = new("Handeln", new("Schwertkampf", 45), new("Faustkampf", 40), new("Rennen", 35)),
        Knowledge = new("Wissen", []),
        Social = new("Sozial", new("Lügen", 35), new("Einschüchtern", 40)),
        Weapons = [
                new ("Schwert", 5, DiceType.D10)
            ]
    };

    public static NpcModel BanditTrapper = new()
    {
        Name = "Banditenjäger",
        PersonalityTypes = "kriminell, egoistisch, gierig, gewaltbereit",
        Group = NpcGroup.Bandit,
        ChallengeRating = ChallengeRating.Easy,
        LifePoints = 100,
        Act = new("Handeln", new("Bogenschießen", 45), new("Faustkampf", 25), new("Rennen", 20), new("Schleichen", 25), new("Verstecken", 15)),
        Knowledge = new("Wissen", [new("Fallenstellen", 60), new("Jagen", 40), new("Überleben", 30)]),
        Social = new("Sozial", new("Lügen", 30), new("Einschüchtern", 25)),
        Weapons = [
            new ("Langbogen", 5, DiceType.D10)
        ],
        Remarks = "30 Pfeile"
    };
    public static List<NpcModel> BanditList = [
        SimpleBandit,
        BanditTrapper,
    ];

    public static List<NpcModel> AllNpcs = BanditList;
}