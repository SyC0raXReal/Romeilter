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

    #region Bandits

    public static NpcModel SimpleBandit = new()
    {
        Name = "Einfacher Bandit",
        PersonalityTypes = "kriminell, egoistisch, gierig, gewaltbereit",
        Group = NpcGroup.Bandit,
        ChallengeRating = ChallengeRating.Easy,
        LifePoints = 100,
        Act = new("Handeln", new("Schwertkampf", 45), new("Faustkampf", 40), new("Rennen", 35), new("Parieren", 0)),
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
        Act = new("Handeln", new("Bogenschießen", 45), new("Faustkampf", 25), new("Rennen", 20), new("Schleichen", 25), new("Verstecken", 15), new("Parieren", 0)),
        Knowledge = new("Wissen", [new("Fallenstellen", 60), new("Jagen", 40), new("Überleben", 30)]),
        Social = new("Sozial", new("Lügen", 30), new("Einschüchtern", 25)),
        Weapons = [
            new ("Langbogen", 5, DiceType.D10)
        ],
        Remarks = "30 Pfeile"
    };

    public static NpcModel HeavyBandit = new()
    {
        Name = "Schwerer Bandit",
        PersonalityTypes = "kriminell, egoistisch, gierig, gewaltbereit",
        Group = NpcGroup.Bandit,
        ChallengeRating = ChallengeRating.Challenging,
        LifePoints = 100,
        Act = new("Handeln", new("Zweihandkampf", 65), new("Faustkampf", 45), new("Parieren", 35, 20)),
        Knowledge = new("Wissen", []),
        Social = new("Sozial", new("Lügen", 30), new("Einschüchtern", 55)),
        ArmorValue = 20,
        Weapons = [
        new ("Großaxt", 6, DiceType.D10, -10)
    ],
        Remarks = "Mittlere Rüstung mit Wert 20"
    };

    public static NpcModel BanditMage = new()
    {
        Name = "Magierbandit",
        PersonalityTypes = "kriminell, egoistisch, gierig, gewaltbereit",
        Group = NpcGroup.Bandit,
        ChallengeRating = ChallengeRating.Challenging,
        LifePoints = 100,
        Act = new("Handeln", [new("Ausweichen", 40), new("Treten", 35)]),
        Knowledge = new("Wissen", new("Feuerwissen", 25), new("Feuer Formen klein", 50), new("Kampftaktik", 25)),
        Social = new("Sozial", new("Lügen", 30), new("Feilschen", 45)),
        Remarks = "Laterne als Feurerstarter"
    };

    public static NpcModel BanditLeader = new()
    {
        Name = "Banditenanführer",
        PersonalityTypes = "kriminell, egoistisch, gierig, gewaltbereit",
        Group = NpcGroup.Bandit,
        ChallengeRating = ChallengeRating.Dangerous,
        LifePoints = 100,
        Act = new("Handeln", [new("Ausweichen", 40), new("Schwertkampf", 75), new("Schildparade", 40, 35)]),
        Knowledge = new("Wissen", new("Kampftaktik", 60), new("Fallen stellen", 50), new("Kampftaktik", 25), new("Feuerwissen", 25), new("Feuer Formen klein", 25)),
        Social = new("Sozial", new("Lügen", 30), new("Einschüchtern", 60), new("Anführen (Moral boost, HR)", 55), new("Menschenkenntnis (Intention lesen)", 55)),
        ArmorValue = 35,
        Weapons = [
            new ("Schild", 2, DiceType.D10),
            new ("Schwert", 5, DiceType.D10),
        ],
        Remarks = "Leichte Rüstung + 15, Schild + 20"
    };
    public static readonly List<NpcModel> BanditList = [
        SimpleBandit,
        BanditTrapper,
        HeavyBandit,
        BanditMage,
        BanditLeader,
    ];

    #endregion Bandits

    #region Animals

    public static NpcModel Wolf = new()
    {
        Name = "Wolf",
        PersonalityTypes = "wild, hungrig-aggressiv",
        Group = NpcGroup.Animal,
        ChallengeRating = ChallengeRating.Easy,
        LifePoints = 60,
        Act = new("Handeln", new("Beißen", 65), new("Anfallen", 45), new("Rennen", 65), new("Ausweichen", 0)),
        Knowledge = new("Wissen", []),
        Social = new("Sozial", []),
        Weapons = [
            new ("Zähne", 3, DiceType.D10)
        ]
    };

    public static readonly List<NpcModel> AnimalList = [
        Wolf,
    ];

    #endregion Animals

    public static readonly List<NpcModel> AllNpcs = [.. BanditList, .. AnimalList];
}