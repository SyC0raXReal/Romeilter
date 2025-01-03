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
            NpcGroup.Undead => "Untot",
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
        Act = new("Handeln", new("Zweihandkampf", 65, -10), new("Faustkampf", 45), new("Parieren", 35, 20)),
        Knowledge = new("Wissen", []),
        Social = new("Sozial", new("Lügen", 30), new("Einschüchtern", 55)),
        ArmorValue = 20,
        Weapons = [
        new ("Großaxt", 6, DiceType.D10)
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
        Remarks = "Laterne als Feurerstarter",
        Weapons = [
            new("Magie klein", 5, DiceType.D10)
        ],
    };

    public static NpcModel BanditLeader = new()
    {
        Name = "Banditenanführer",
        PersonalityTypes = "kriminell, egoistisch, gierig, gewaltbereit",
        Group = NpcGroup.Bandit,
        ChallengeRating = ChallengeRating.Dangerous,
        LifePoints = 100,
        Act = new("Handeln", [new("Ausweichen", 40), new("Schwertkampf", 75), new("Schildparade", 40, 35), new("Werfen", 35)]),
        Knowledge = new("Wissen", new("Kampftaktik", 60), new("Fallen stellen", 50), new("Feuerwissen", 25), new("Feuer Formen klein", 25)),
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

    #region Guards

    public static NpcModel Guard = new()
    {
        Name = "Wache",
        PersonalityTypes = "rechtschaffend, hilfsbereit, wachsam",
        Group = NpcGroup.Bandit,
        ChallengeRating = ChallengeRating.Easy,
        LifePoints = 100,
        Act = new("Handeln", new("Schwertkampf", 45), new("Faustkampf", 25), new("Rennen", 10), new("Parieren", 15, 15)),
        Knowledge = new("Wissen", [new("Rechtswissen", 30), new("Wahrnehmung", 15)]),
        Social = new("Sozial", new("Lügen erkennen", 35), new("Überreden", 15)),
        ArmorValue = 15,
        Weapons = [
            new ("Schwert", 5, DiceType.D10)
        ],
        Remarks = "leichter Waffenrock mit dem Wert 15"
    };

    public static NpcModel GuardTracker = new()
    {
        Name = "Wache - Fährtenleser",
        PersonalityTypes = "rechtschaffend, hilfsbereit, wachsam",
        Group = NpcGroup.Bandit,
        ChallengeRating = ChallengeRating.Easy,
        LifePoints = 100,
        Act = new("Handeln", new("Bogenschießen", 45), new("Faustkampf", 25), new("Rennen", 20), new("Schleichen", 25), new("Parieren", 0)),
        Knowledge = new("Wissen", [new("Fallen erkennen", 60), new("Jagen", 40), new("Überleben", 30), new("Spuren lesen", 45), new("Wahrnehmung", 25)]),
        Social = new("Sozial", new("Lügen erkennen", 30), new("Überreden", 25)),
        Weapons = [
            new ("Langbogen", 5, DiceType.D10)
        ],
        Remarks = "30 Pfeile"
    };

    public static NpcModel HeavyGuard = new()
    {
        Name = "Schwere Wache",
        PersonalityTypes = "rechtschaffend, hilfsbereit, wachsam",
        Group = NpcGroup.Bandit,
        ChallengeRating = ChallengeRating.Challenging,
        LifePoints = 100,
        Act = new("Handeln", new("Schwertkampf", 65), new("Faustkampf", 45), new("Parieren", 35, 35)),
        Knowledge = new("Wissen", [new("Rechtswissen", 30), new("Wahrnehmung", 15)]),
        Social = new("Sozial", new("Lügen erkennen", 35), new("Überreden", 30)),
        ArmorValue = 35,
        Weapons = [
                    new ("Schwert", 5, DiceType.D10),
                    new ("Schild", 2, DiceType.D100),
    ],
        Remarks = "Mittlere Rüstung mit Wert 20, Schild mit Wert 15"
    };

    public static NpcModel GuardMage = new()
    {
        Name = "Magierwache",
        PersonalityTypes = "rechtschaffend, hilfsbereit, wachsam",
        Group = NpcGroup.Bandit,
        ChallengeRating = ChallengeRating.Challenging,
        LifePoints = 100,
        Act = new("Handeln", [new("Ausweichen", 40), new("Treten", 35)]),
        Knowledge = new("Wissen", new("Gesteinswissen", 25), new("Gestein Formen klein", 50), new("Wahrnehmung", 15)),
        Social = new("Sozial", new("Lügen erkennen", 30), new("Diplomatie", 45)),
        ArmorValue = 15,
        Remarks = "leichet Waffenrock mit Wert 15",
        Weapons = [
            new("Magie klein", 5, DiceType.D10)
        ],
    };

    public static NpcModel GuardLeader = new()
    {
        Name = "Wachkommandant",
        PersonalityTypes = "rechtschaffend, hilfsbereit, wachsam",
        Group = NpcGroup.Bandit,
        ChallengeRating = ChallengeRating.Dangerous,
        LifePoints = 100,
        Act = new("Handeln", [new("Ausweichen", 40), new("Schwertkampf", 75), new("Schildparade", 40, 35)]),
        Knowledge = new("Wissen", new("Kampftaktik", 60), new("Fallen lesen", 50), new("Kampftaktik", 25), new("Gesteinswissen", 25), new("Gestein Formen klein", 25)),
        Social = new("Sozial", new("Lügen erkennen", 30), new("Überreden", 60), new("Anführen (Moral boost, HR)", 55), new("Menschenkenntnis (Intention lesen)", 55)),
        ArmorValue = 35,
        Weapons = [
            new ("Schild", 2, DiceType.D10),
            new ("Schwert", 5, DiceType.D10),
        ],
        Remarks = "Leichte Rüstung + 15, Schild + 20"
    };

    public static readonly List<NpcModel> GuardList = [
        Guard,
        GuardTracker,
        HeavyGuard,
        GuardMage,
        GuardLeader,
    ];

    #endregion Guards

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

    public static NpcModel AplhaWolf = new()
    {
        Name = "Alpha Wolf",
        PersonalityTypes = "wild, hungrig-aggressiv",
        Group = NpcGroup.Animal,
        ChallengeRating = ChallengeRating.Challenging,
        LifePoints = 80,
        Act = new("Handeln", new("Beißen", 75), new("Anfallen", 55), new("Rennen", 75), new("Ausweichen", 10)),
        Knowledge = new("Wissen", []),
        Social = new("Sozial", []),
        Weapons = [
        new ("Zähne", 3, DiceType.D10)
    ]
    };


    public static NpcModel Bear = new()
    {
        Name = "Bär",
        PersonalityTypes = "wild, hungrig-aggressiv",
        Group = NpcGroup.Animal,
        ChallengeRating = ChallengeRating.Challenging,
        LifePoints = 120,
        Act = new("Handeln", new("Beißen", 55), new("Prankenhieb", 75), new("Rennen", 25), new("Klettern", 55), new("Ausweichen", 0)),
        Knowledge = new("Wissen", []),
        Social = new("Sozial", []),
        Weapons = [
        new ("Zähne", 3, DiceType.D10)
    ]
    };

    public static NpcModel GiantRat = new()
    {
        Name = "Riesenratte",
        PersonalityTypes = "wild, hungrig-aggressiv",
        Group = NpcGroup.Animal,
        ChallengeRating = ChallengeRating.Easy,
        LifePoints = 50,
        Act = new("Handeln", new("Beißen", 65), new("Rennen", 65), new("Ausweichen", 0)),
        Knowledge = new("Wissen", []),
        Social = new("Sozial", []),
        Weapons = [
            new ("Zähne, giftig + 10", 3, DiceType.D10, 10)
        ]
    };

    public static NpcModel GiantLizard = new()
    {
        Name = "Riesenechse",
        PersonalityTypes = "wild, hungrig-aggressiv",
        Group = NpcGroup.Animal,
        ChallengeRating = ChallengeRating.Challenging,
        LifePoints = 80,
        Act = new("Handeln", new("Beißen", 75), new("Feuerspucken", 45), new("Rennen", 75), new("Ausweichen", 10)),
        Knowledge = new("Wissen", []),
        Social = new("Sozial", []),
        Weapons = [
        new ("Zähne", 3, DiceType.D10),
        new ("Feuerspucken", 4, DiceType.D10)
    ]
    };

    public static readonly List<NpcModel> AnimalList = [
        Wolf,
        AplhaWolf,
        Bear,
        GiantRat,
        GiantLizard
    ];

    #endregion Animals

    #region Monstrosity
    public static NpcModel AcidElemental = new()
    {
        Name = "Säureelementar",
        PersonalityTypes = "wild, hungrig-aggressiv",
        Group = NpcGroup.Monstrosity,
        ChallengeRating = ChallengeRating.Dangerous,
        LifePoints = 150,
        Act = new("Handeln", new("Säurestreich", 75), new("Säurewurf", 55), new("Säuresprung", 35), new("Schnell fließen (rennen)", 75)),
        Knowledge = new("Wissen", []),
        Social = new("Sozial", []),
        Weapons = [
        new ("Säurekrallen", 5, DiceType.D10),
        new ("Säurewurf", 4, DiceType.D10),
        new ("Säuresprung", 3, DiceType.D10, null, "Das Elementar springt und verspritzt in 2m umkreis Säure"),
        ],
        Remarks = "Ein großes Wesen komplett aus Säure. Es hat lange scharfe klauen und kein wirklich erkennbares Gesicht."
    };

    public static readonly List<NpcModel> MonstrosityList = [
        AcidElemental
    ];

    #endregion Monstrosity

    #region Undead

    public static NpcModel Skeleton = new()
    {
        Name = "Skelett",
        PersonalityTypes = "feindlich gegenüber lebenden Humanoiden",
        Group = NpcGroup.Undead,
        ChallengeRating = ChallengeRating.Easy,
        LifePoints = 80,
        Act = new("Handeln", new("Schwertkampf", 45), new("Faustkampf", 40), new("Rennen", 35), new("Parieren", 0)),
        Knowledge = new("Wissen", []),
        Social = new("Sozial", []),
        Weapons = [
            new ("Schwert", 5, DiceType.D10)
        ]
    };

    public static NpcModel SkeletonArcher = new()
    {
        Name = "Skelettbogenschütze",
        PersonalityTypes = "feindlich gegenüber lebenden Humanoiden",
        Group = NpcGroup.Undead,
        ChallengeRating = ChallengeRating.Easy,
        LifePoints = 80,
        Act = new("Handeln", new("Bogenschießen", 45), new("Faustkampf", 25), new("Rennen", 20), new("Schleichen", 25), new("Verstecken", 15), new("Parieren", 0)),
        Knowledge = new("Wissen", [new("Fallenstellen", 60), new("Jagen", 40)]),
        Social = new("Sozial", []),
        Weapons = [
            new ("Langbogen", 5, DiceType.D10)
        ],
        Remarks = "30 Pfeile"
    };

    public static NpcModel SkeletonWarrior = new()
    {
        Name = "Skelettkrieger",
        PersonalityTypes = "feindlich gegenüber lebenden Humanoiden",
        Group = NpcGroup.Undead,
        ChallengeRating = ChallengeRating.Challenging,
        LifePoints = 100,
        Act = new("Handeln", new("Zweihandkampf", 65, -10), new("Faustkampf", 45), new("Parieren", 35, 20)),
        Knowledge = new("Wissen", []),
        Social = new("Sozial", []),
        ArmorValue = 20,
        Weapons = [
        new ("Großaxt", 6, DiceType.D10)
    ],
        Remarks = "Mittlere Rüstung mit Wert 20"
    };

    public static NpcModel SkeletonMage = new()
    {
        Name = "Skelettmagier",
        PersonalityTypes = "feindlich gegenüber lebenden Humanoiden",
        Group = NpcGroup.Undead,
        ChallengeRating = ChallengeRating.Challenging,
        LifePoints = 100,
        Act = new("Handeln", [new("Ausweichen", 40), new("Treten", 35)]),
        Knowledge = new("Wissen", new("Knochenwissen", 25), new("Knochen Formen klein", 50), new("Kampftaktik", 25)),
        Social = new("Sozial", []),
        Weapons = [
            new("Magie klein", 5, DiceType.D10)
        ],
    };

    public static readonly List<NpcModel> UndeadList = [
        Skeleton,
        SkeletonArcher,
        SkeletonWarrior,
        SkeletonMage,
    ];

    #endregion Undead

    public static readonly List<NpcModel> AllNpcs = [.. BanditList, .. AnimalList, .. GuardList, .. MonstrosityList, .. UndeadList];
}