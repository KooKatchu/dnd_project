using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ActionApi.Controllers
{
    [ApiController]
    [Route("api/actions")]
    public class ActionController : ControllerBase
    {
        private readonly List<Spell> spells = new List<Spell>
        {
            new Spell
            (
                1,
                "Fireball",
                3,
                "Evocation",
                "1 action",
                "150 feet",
                new List<string> { "V", "S", "M" },
                "Instantaneous",
                "A bright streak... (spell description)",
                "When you cast this spell using a spell slot of 4th level or higher...",
                new List<string> { "Sorcerer", "Wizard" },
                "Player's Handbook"
            ),
            new Spell
            (
                2,
                "Healing Word",
                1,
                "Evocation",
                "1 bonus action",
                "60 feet",
                new List<string> { "V" },
                "Instantaneous",
                "A creature of your choice... (spell description)",
                "When you cast this spell using a spell slot of 2nd level or higher...",
                new List<string> { "Cleric", "Bard" },
                "Player's Handbook"
            ),
            new Spell
            (
                3,
                "Shield",
                1,
                "Abjuration",
                "1 reaction",
                "Self",
                new List<string> { "V", "S" },
                "1 round",
                "An invisible barrier of magical force... (spell description)",
                "N/A",
                new List<string> { "Wizard", "Sorcerer", "Artificer" },
                "Player's Handbook"
            ),
            new Spell
            (
                4,
                "Cure Wounds",
                1,
                "Evocation",
                "1 action",
                "Touch",
                new List<string> { "V", "S" },
                "Instantaneous",
                "A creature you touch regains a number of hit points... (spell description)",
                "This spell has no effect on undead or constructs.",
                new List<string> { "Cleric", "Druid", "Bard", "Paladin" },
                "Player's Handbook"
            ),
            new Spell
            (
                5,
                "Mage Armor",
                1,
                "Abjuration",
                "1 action",
                "Touch",
                new List<string> { "V", "S", "M" },
                "8 hours",
                "You touch a willing creature who isn’t wearing armor... (spell description)",
                "N/A",
                new List<string> { "Wizard", "Sorcerer" },
                "Player's Handbook"
            ),
            new Spell
            (
                6,
                "Bless",
                1,
                "Enchantment",
                "1 action",
                "30 feet",
                new List<string> { "V", "S", "M" },
                "Concentration, up to 1 minute",
                "You bless up to three creatures of your choice... (spell description)",
                "N/A",
                new List<string> { "Cleric", "Paladin" },
                "Player's Handbook"
            ),
            new Spell
            (
                7,
                "Magic Missile",
                1,
                "Evocation",
                "1 action",
                "120 feet",
                new List<string> { "V", "S" },
                "Instantaneous",
                "You create three glowing darts of magical force... (spell description)",
                "When you cast this spell using a spell slot of 2nd level or higher...",
                new List<string> { "Wizard", "Sorcerer" },
                "Player's Handbook"
            ),
            new Spell
            (
                8,
                "Thorn Whip",
                0,
                "Transmutation",
                "1 action",
                "30 feet",
                new List<string> { "V", "S", "M" },
                "Instantaneous",
                "You create a long, vine-like whip covered in thorns... (spell description)",
                "N/A",
                new List<string> { "Druid" },
                "Player's Handbook"
            ),
            new Spell
            (
                9,
                "Charm Person",
                1,
                "Enchantment",
                "1 action",
                "30 feet",
                new List<string> { "V", "S" },
                "1 hour",
                "You attempt to charm a humanoid you can see within range... (spell description)",
                "N/A",
                new List<string> { "Bard", "Sorcerer", "Warlock", "Wizard" },
                "Player's Handbook"
            ),
            new Spell
            (
                10,
                "Mending",
                0,
                "Transmutation",
                "1 minute",
                "Touch",
                new List<string> { "V", "S", "M" },
                "Instantaneous",
                "This spell repairs a single break or tear in an object you touch... (spell description)",
                "N/A",
                new List<string> { "Bard", "Cleric", "Druid", "Sorcerer", "Wizard" },
                "Player's Handbook"
            ),
            new Spell
            (
                11,
                "Darkness",
                2,
                "Evocation",
                "1 action",
                "60 feet",
                new List<string> { "V", "M" },
                "Concentration, up to 10 minutes",
                "Magical darkness spreads from a point you choose within range... (spell description)",
                "N/A",
                new List<string> { "Sorcerer", "Warlock", "Wizard" },
                "Player's Handbook"
            ),
            new Spell
            (
                12,
                "Invisibility",
                2,
                "Illusion",
                "1 action",
                "Touch",
                new List<string> { "V", "S", "M" },
                "Concentration, up to 1 hour",
                "A creature you touch becomes invisible until the spell ends... (spell description)",
                "When you cast this spell using a spell slot of 3rd level or higher...",
                new List<string> { "Bard", "Sorcerer", "Warlock", "Wizard" },
                "Player's Handbook"
            ),
            new Spell
            (
                13,
                "Hold Person",
                2,
                "Enchantment",
                "1 action",
                "60 feet",
                new List<string> { "V", "S", "M" },
                "Concentration, up to 1 minute",
                "The target must succeed on a Wisdom saving throw or be paralyzed for the duration...",
                "When you cast this spell using a spell slot of 3rd level or higher...",
                new List<string> { "Cleric", "Paladin", "Bard", "Sorcerer", "Warlock", "Wizard" },
                "Player's Handbook"
            ),
            new Spell
            (
                14,
                "Fly",
                3,
                "Transmutation",
                "1 action",
                "Touch",
                new List<string> { "V", "S", "M" },
                "Concentration, up to 10 minutes",
                "You touch a willing creature. The target gains a flying speed of 60 feet...",
                "When you cast this spell using a spell slot of 4th level or higher...",
                new List<string> { "Sorcerer", "Wizard", "Warlock" },
                "Player's Handbook"
            ),
            new Spell
            (
                15,
                "Suggestion",
                2,
                "Enchantment",
                "1 action",
                "30 feet",
                new List<string> { "V", "M" },
                "Concentration, up to 8 hours",
                "You suggest a course of activity (limited to a sentence or two) and magically influence a creature...",
                "N/A",
                new List<string> { "Bard", "Sorcerer", "Warlock", "Wizard" },
                "Player's Handbook"
            ),
            new Spell
            (
                16,
                "Revivify",
                3,
                "Necromancy",
                "1 action",
                "Touch",
                new List<string> { "V", "S", "M" },
                "Instantaneous",
                "You touch a creature that has died within the last minute...",
                "N/A",
                new List<string> { "Cleric", "Paladin" },
                "Player's Handbook"
            ),
            new Spell
            (
                17,
                "Ray of Enfeeblement",
                2,
                "Necromancy",
                "1 action",
                "60 feet",
                new List<string> { "V", "S" },
                "Concentration, up to 1 minute",
                "A black beam of enervating energy springs from your finger toward a creature within range...",
                "When you cast this spell using a spell slot of 3rd level or higher...",
                new List<string> { "Warlock", "Wizard" },
                "Player's Handbook"
            ),
            new Spell
            (
                18,
                "Polymorph",
                4,
                "Transmutation",
                "1 action",
                "60 feet",
                new List<string> { "V", "S", "M" },
                "Concentration, up to 1 hour",
                "This spell transforms a creature that you can see within range into a new form...",
                "N/A",
                new List<string> { "Wizard", "Sorcerer", "Bard", "Druid", "Transmutation" },
                "Player's Handbook"
            ),
            new Spell
            (
                19,
                "Counterspell",
                3,
                "Abjuration",
                "1 reaction",
                "60 feet",
                new List<string> { "S" },
                "Instantaneous",
                "You attempt to interrupt a creature in the process of casting a spell...",
                "N/A",
                new List<string> { "Wizard", "Sorcerer" },
                "Player's Handbook"
            ),
            new Spell
            (
                20,
                "Spirit Guardians",
                3,
                "Conjuration",
                "1 action",
                "Self",
                new List<string> { "V", "S", "M" },
                "Concentration, up to 10 minutes",
                "You call forth spirits to protect you. They flit around you to a distance of 15 feet...",
                "When you cast this spell using a spell slot of 4th level or higher...",
                new List<string> { "Cleric" },
                "Player's Handbook"
            )

        };

        private readonly List<Cantrip> cantrips = new List<Cantrip>
        {
            new Cantrip
            (
                1,
                "Fire Bolt",
                0,
                "Evocation",
                "1 action",
                "120 feet",
                new List<string> { "V", "S" },
                "Instantaneous",
                "You hurl a mote of fire at a creature or object within range...",
                new List<string> { "Sorcerer", "Wizard" },
                "Player's Handbook"
            ),
            new Cantrip
            (
                2,
                "Eldritch Blast",
                0,
                "Evocation",
                "1 action",
                "120 feet",
                new List<string> { "V", "S" },
                "Instantaneous",
                "A beam of crackling energy streaks toward a creature within range...",
                new List<string> { "Warlock" },
                "Player's Handbook"
            ),
            new Cantrip
            (
                3,
                "Mage Hand",
                0,
                "Conjuration",
                "1 action",
                "30 feet",
                new List<string> { "V", "S" },
                "1 minute",
                "A spectral, floating hand appears at a point you choose within range...",
                new List<string> { "Wizard", "Sorcerer" },
                "Player's Handbook"
            ),
            new Cantrip
            (
                4,
                "Prestidigitation",
                0,
                "Transmutation",
                "1 action",
                "10 feet",
                new List<string> { "V", "S" },
                "1 hour",
                "This spell is a minor magical trick that novice spellcasters use for practice...",
                new List<string> { "Wizard", "Sorcerer", "Bard" },
                "Player's Handbook"
            ),
            new Cantrip
            (
                5,
                "Ray of Frost",
                0,
                "Evocation",
                "1 action",
                "60 feet",
                new List<string> { "V", "S" },
                "Instantaneous",
                "A frigid beam of blue-white light streaks toward a creature within range...",
                new List<string> { "Wizard", "Sorcerer" },
                "Player's Handbook"
            ),
            new Cantrip
            (
                6,
                "Mending",
                0,
                "Transmutation",
                "1 minute",
                "Touch",
                new List<string> { "V", "S", "M" },
                "Instantaneous",
                "This spell repairs a single break or tear in an object you touch...",
                new List<string> { "Bard", "Cleric", "Druid", "Sorcerer", "Wizard" },
                "Player's Handbook"
            ),
            new Cantrip
            (
                7,
                "Light",
                0,
                "Evocation",
                "1 action",
                "Touch",
                new List<string> { "V", "M" },
                "1 hour",
                "You touch one object that is no larger than 10 feet in any dimension...",
                new List<string> { "Cleric", "Wizard" },
                "Player's Handbook"
            ),
            new Cantrip
            (
                8,
                "Minor Illusion",
                0,
                "Illusion",
                "1 action",
                "30 feet",
                new List<string> { "S", "M" },
                "1 minute",
                "You create a sound or an image of an object within range that lasts for the duration...",
                new List<string> { "Bard", "Sorcerer", "Wizard" },
                "Player's Handbook"
            ),
            new Cantrip
            (
                9,
                "Thaumaturgy",
                0,
                "Transmutation",
                "1 action",
                "30 feet",
                new List<string> { "V" },
                "Up to 1 minute",
                "You manifest a minor wonder, a sign of supernatural power, within range...",
                new List<string> { "Cleric" },
                "Player's Handbook"
            ),
            new Cantrip
            (
                10,
                "Vicious Mockery",
                0,
                "Enchantment",
                "1 action",
                "60 feet",
                new List<string> { "V" },
                "Instantaneous",
                "You unleash a string of insults laced with subtle enchantments at a creature you can see within range...",
                new List<string> { "Bard" },
                "Player's Handbook"
            ),
            new Cantrip
            (
                11,
                "Chill Touch",
                0,
                "Necromancy",
                "1 action",
                "120 feet",
                new List<string> { "V", "S" },
                "1 round",
                "You create a ghostly, skeletal hand in the space of a creature within range...",
                new List<string> { "Sorcerer", "Warlock", "Wizard" },
                "Player's Handbook"
            ),
            new Cantrip
            (
                12,
                "Guidance",
                0,
                "Divination",
                "1 action",
                "Touch",
                new List<string> { "V", "S" },
                "1 minute",
                "You touch one willing creature. Once before the spell ends, the target can roll a d4 and add the number rolled to one ability check of its choice...",
                new List<string> { "Cleric", "Druid" },
                "Player's Handbook"
            ),
            new Cantrip
            (
                13,
                "Resistance",
                0,
                "Abjuration",
                "1 action",
                "Touch",
                new List<string> { "V", "S", "M" },
                "Up to 1 minute",
                "You touch one willing creature. Once before the spell ends, the target can roll a d4 and add the number rolled to one saving throw of its choice...",
                new List<string> { "Cleric", "Druid" },
                "Player's Handbook"
            ),
            new Cantrip
            (
                14,
                "Shocking Grasp",
                0,
                "Evocation",
                "1 action",
                "Touch",
                new List<string> { "V", "S" },
                "Instantaneous",
                "Lightning springs from your hand to deliver a shock to a creature you try to touch...",
                new List<string> { "Sorcerer", "Wizard" },
                "Player's Handbook"
            ),
            new Cantrip
            (
                15,
                "Sacred Flame",
                0,
                "Evocation",
                "1 action",
                "60 feet",
                new List<string> { "V", "S" },
                "Instantaneous",
                "Flame-like radiance descends on a creature that you can see within range. The target must succeed on a Dexterity saving throw or take 1d8 radiant damage...",
                new List<string> { "Cleric" },
                "Player's Handbook"
            ),
            new Cantrip
            (
                16,
                "True Strike",
                0,
                "Divination",
                "1 action",
                "30 feet",
                new List<string> { "S" },
                "Concentration, up to 1 round",
                "You extend your hand and point a finger at a target in range. Your magic grants you a brief insight into the target's defenses...",
                new List<string> { "Sorcerer", "Wizard" },
                "Player's Handbook"
            ),
            new Cantrip
            (
                17,
                "Dancing Lights",
                0,
                "Evocation",
                "1 action",
                "120 feet",
                new List<string> { "V", "S", "M" },
                "Concentration, up to 1 minute",
                "You create up to four torch-sized lights within range, making them appear as torches, lanterns, or glowing orbs that hover in the air...",
                new List<string> { "Bard", "Sorcerer", "Wizard" },
                "Player's Handbook"
            ),
            new Cantrip
            (
                18,
                "Message",
                0,
                "Transmutation",
                "1 action",
                "120 feet",
                new List<string> { "V", "S", "M" },
                "1 round",
                "You point your finger toward a creature within range and whisper a message. The target (and only the target) hears the message and can reply in a whisper that only you can hear...",
                new List<string> { "Bard", "Sorcerer", "Wizard" },
                "Player's Handbook"
            ),
            new Cantrip
            (
                19,
                "Mage Armor",
                0,
                "Abjuration",
                "1 action",
                "Touch",
                new List<string> { "V", "S", "M" },
                "8 hours",
                "You touch a willing creature who isn't wearing armor, and a protective magical force surrounds it until the spell ends...",
                new List<string> { "Wizard", "Sorcerer" },
                "Player's Handbook"
            ),
            new Cantrip
            (
                20,
                "Spare the Dying",
                0,
                "Necromancy",
                "1 action",
                "Touch",
                new List<string> { "V", "S" },
                "Instantaneous",
                "You touch a living creature that has 0 hit points. The creature becomes stable...",
                new List<string> { "Cleric" },
                "Player's Handbook"
            )

        };

        private readonly List<Weapon> weapons = new List<Weapon>
        {
        new Weapon
        (
            1,
            "Longsword",
            "Melee",
            8,
            "d8",
            0,
            "slashing",
            new List<string> { "Versatile (1d10)" },
            "Melee",
            3,
            "A versatile and well-balanced melee weapon.",
            "Player's Handbook"
        ),
        new Weapon
        (
            2,
            "Shortbow",
            "Ranged",
            6,
            "d6",
            0,
            "piercing",
            new List<string> { "Two-handed", "Ammunition (range 80/320)" },
            "80/320 feet",
            2,
            "A small and lightweight bow suitable for short-range attacks.",
            "Player's Handbook"
        ),
        new Weapon
        (
            3,
            "Warhammer",
            "Melee",
            8,
            "d8",
            0,
            "bludgeoning",
            new List<string> { "Versatile (1d10)" },
            "Melee",
            2,
            "A sturdy hammer designed for crushing blows.",
            "Player's Handbook"
        ),
        new Weapon
        (
            4,
            "Crossbow, Heavy",
            "Ranged",
            10,
            "d10",
            0,
            "piercing",
            new List<string> { "Two-handed", "Ammunition (range 100/400)", "Loading", "Heavy" },
            "100/400 feet",
            18,
            "A large and powerful crossbow that requires time to reload between shots.",
            "Player's Handbook"
        ),
        new Weapon
        (
            5,
            "Dagger",
            "Melee",
            4,
            "d4",
            0,
            "piercing",
            new List<string> { "Finesse", "Light", "Thrown (range 20/60)" },
            "Melee, 20/60 feet",
            1,
            "A small, easily concealable blade suitable for close-quarters combat.",
            "Player's Handbook"
        ),
        new Weapon
        (
            6,
            "Greataxe",
            "Melee",
            12,
            "d12",
            0,
            "slashing",
            new List<string> { "Heavy", "Two-handed" },
            "Melee",
            7,
            "A massive double-bladed axe, effective but requiring strength to wield.",
            "Player's Handbook"
        ),
        new Weapon
        (
            7,
            "Shortsword",
            "Melee",
            6,
            "d6",
            0,
            "piercing",
            new List<string> { "Finesse", "Light" },
            "Melee",
            2,
            "A lightweight and versatile blade, well-suited for finesse fighters.",
            "Player's Handbook"
        ),
        new Weapon
        (
            8,
            "Longbow",
            "Ranged",
            8,
            "d8",
            0,
            "piercing",
            new List<string> { "Ammunition (range 150/600)", "Heavy", "Two-handed" },
            "150/600 feet",
            2,
            "A powerful bow with great range, best used by those with strength and skill.",
            "Player's Handbook"
        ),
        new Weapon
        (
            9,
            "Rapier",
            "Melee",
            8,
            "d8",
            0,
            "piercing",
            new List<string> { "Finesse" },
            "Melee",
            2,
            "A slender and pointed blade, perfect for precise strikes.",
            "Player's Handbook"
        ),
        new Weapon
        (
            10,
            "Mace",
            "Melee",
            6,
            "d6",
            0,
            "bludgeoning",
            new List<string>(),
            "Melee",
            4,
            "A simple yet effective bludgeoning weapon.",
            "Player's Handbook"
        ),
        new Weapon
        (
            11,
            "Spear",
            "Melee",
            6,
            "d6",
            0,
            "piercing",
            new List<string> { "Thrown (range 20/60)", "Versatile (1d8)" },
            "Melee, 20/60 feet",
            3,
            "A versatile weapon that can be used for thrusting or throwing.",
            "Player's Handbook"
        ),
        new Weapon
        (
            12,
            "Handaxe",
            "Melee",
            6,
            "d6",
            0,
            "slashing",
            new List<string> { "Light", "Thrown (range 20/60)" },
            "Melee, 20/60 feet",
            2,
            "A small, versatile axe that can be used in hand-to-hand combat or thrown.",
            "Player's Handbook"
        ),
        new Weapon
        (
            13,
            "Flail",
            "Melee",
            8,
            "d8",
            0,
            "bludgeoning",
            new List<string> { "Two-handed" },
            "Melee",
            2,
            "A weapon with a spiked ball attached to a chain, providing a flexible and unpredictable attack.",
            "Player's Handbook"
        ),
        new Weapon
        (
            14,
            "Scimitar",
            "Melee",
            6,
            "d6",
            0,
            "slashing",
            new List<string> { "Finesse", "Light" },
            "Melee",
            2,
            "A curved sword with a sharp blade, suitable for agile combatants.",
            "Player's Handbook"
        ),
        new Weapon
        (
            15,
            "Javelin",
            "Ranged",
            6,
            "d6",
            0,
            "piercing",
            new List<string> { "Thrown (range 30/120)" },
            "30/120 feet",
            2,
            "A lightweight spear designed for throwing at enemies.",
            "Player's Handbook"
        ),
        new Weapon
        (
            16,
            "Greatsword",
            "Melee",
            12,
            "2d6",
            2,
            "slashing",
            new List<string> { "Heavy", "Two-handed" },
            "Melee",
            6,
            "A large, two-handed sword with a powerful slashing capability.",
            "Player's Handbook"
        ),
        new Weapon
        (
            17,
            "Net",
            "Ranged",
            0,
            "N/A",
            0,
            "N/A",
            new List<string> { "Thrown (range 5/15)", "Special" },
            "5/15 feet",
            3,
            "A mesh of woven ropes designed to entangle and restrain creatures.",
            "Player's Handbook"
    ),
    new Weapon
    (
        18,
        "Halberd",
        "Melee",
        10,
        "d10",
        0,
        "slashing",
        new List<string> { "Heavy", "Reach", "Two-handed" },
        "Melee",
        6,
        "A polearm with an axe blade and a spear point, providing both slashing and thrusting attacks.",
        "Player's Handbook"
    ),
    new Weapon
    (
        19,
        "Dart",
        "Ranged",
        4,
        "d4",
        0,
        "piercing",
        new List<string> { "Finesse", "Thrown (range 20/60)" },
        "20/60 feet",
        0.25,
        "A small, throwable projectile with a sharp point.",
        "Player's Handbook"
    ),
    new Weapon
    (
        20,
        "Quarterstaff",
        "Melee",
        6,
        "d6",
        0,
        "bludgeoning",
        new List<string> { "Versatile (1d8)" },
        "Melee",
        4,
        "A simple staff that can be used with one or two hands for both offense and defense.",
        "Player's Handbook"
    )
};

        private readonly List<Bonus> bonus = new List<Bonus>
        {
            new Bonus
            (
                1,
                "Cunning Action",
                "Rogue",
                "As a bonus action, you can take the Dash, Disengage, or Hide action on your turn."
            ),
            new Bonus
            (
                2,
                "Fury of Blows",
                "Monk",
                "As a bonus action, you can make two unarmed strikes after taking the Attack action."
            ),
            new Bonus
            (
                3,
                "Second Wind",
                "Fighter",
                "As a bonus action, you can regain hit points equal to 1d10 + your fighter level once per short or long rest."
            ),
            new Bonus
            (
                4,
                "Divine Smite",
                "Paladin",
                "As a bonus action, you can expend spell slots to deal extra radiant damage on a successful melee attack."
            ),
            new Bonus
            (
                5,
                "Wild Shape",
                "Druid",
                "As a bonus action, you can transform into a beast form that you have seen before."
            ),
            new Bonus
            (
                6,
                "Rage",
                "Barbarian",
                "As a bonus action, you can enter a state of rage, gaining advantages on Strength checks and saving throws, and dealing extra damage with melee weapons."
            ),
            new Bonus
            (
                7,
                "Hexblade's Curse",
                "Warlock",
                "As a bonus action, you can curse a target, gaining bonus damage against them and regaining hit points when they die."
            ),
            new Bonus
            (
                8,
                "Flurry of Blows",
                "Monk",
                "As a bonus action, you can make two unarmed strikes after taking the Attack action."
            ),
            new Bonus
            (
                9,
                "Misty Step",
                "Wizard",
                "As a bonus action, you can teleport up to 30 feet to an unoccupied space that you can see."
            ),
            new Bonus
            (
                10,
                "Sneak Attack",
                "Rogue",
                "As a bonus action, you can deal extra damage to a creature you hit with an attack if you have advantage on the attack roll."
            ),
            new Bonus
            (
                11,
                "Ki Points",
                "Monk",
                "As a bonus action, you can spend ki points to activate various abilities such as Patient Defense or Step of the Wind."
            ),
            new Bonus
            (
                12,
                "Action Surge",
                "Fighter",
                "As a bonus action, you can take an additional action on your turn, once per short or long rest."
            ),
            new Bonus
            (
                13,
                "Lay on Hands",
                "Paladin",
                "As a bonus action, you can restore a number of hit points to yourself or an ally, up to your paladin level times 5."
            ),
            new Bonus
            (
                14,
                "Shillelagh",
                "Druid",
                "As a bonus action, you can imbue a club or quarterstaff with magical power, using your spellcasting ability for attack and damage rolls."
            ),
            new Bonus
            (
                15,
                "Evasion",
                "Rogue",
                "As a bonus action, you can dodge out of the way of certain area effects, such as a red dragon's fiery breath or an ice storm spell."
            ),
            new Bonus
            (
                16,
                "Reckless Attack",
                "Barbarian",
                "As a bonus action, you can throw aside all concern for defense to attack with fierce desperation. Gain advantage on melee weapon attack rolls, but attacks against you have advantage until your next turn."
            ),
            new Bonus
            (
                17,
                "Mystic Arcanum",
                "Warlock",
                "As a bonus action, you can cast a higher-level spell that you have gained through your Pact Boon feature."
            ),
            new Bonus
            (
                18,
                "Patient Defense",
                "Monk",
                "As a bonus action, you can take the Dodge action until the start of your next turn."
            ),
            new Bonus
            (
                19,
                "Fighting Style",
                "Fighter",
                "As a bonus action, you can adopt a particular fighting style, such as Defense, Dueling, or Great Weapon Fighting, gaining special benefits related to that style."
            ),
            new Bonus
            (
                20,
                "Hex",
                "Warlock",
                "As a bonus action, you can curse a creature, dealing extra damage when you hit it with an attack."
            )
        };


        [HttpGet("spells")]
        public IActionResult GetSpells()
        {
            return Ok(spells);
        }

        [HttpGet("cantrips")]
        public IActionResult GetCantrips()
        {
            return Ok(cantrips);
        }

        [HttpGet("weapons")]
        public IActionResult GetWeapons()
        {
            return Ok(weapons);
        }

        [HttpGet("bonus")]
        public IActionResult GetBonus()
        {
            return Ok(bonus);
        }
    }

    public record Spell(
        int SpellId,
        string Name,
        int Level,
        string School,
        string CastingTime,
        string Range,
        List<string> Components,
        string Duration,
        string Description,
        string HigherLevels,
        List<string> Classes,
        string Source
    );

    public record Cantrip(
        int CantripId,
        string Name,
        int Level,
        string School,
        string CastingTime,
        string Range,
        List<string> Components,
        string Duration,
        string Description,
        List<string> Classes,
        string Source
    );

    public record Weapon(
        int WeaponpId,
        string Name,
        string Category,
        int Damage,
        string DamageDice,
        int Modifier,
        string Type,
        List<string> Properties,
        string Range,
        double Weight,
        string Description,
        string Source
    );
    public record Bonus(
        int BonusId,
        string Name,
        string Class,
        string Description
    );
}
