#region Copyright © 2015 Kurisu Solutions
// All rights are reserved. Transmission or reproduction in part or whole,
// any form or by any means, mechanical, electronical or otherwise, is prohibited
// without the prior written consent of the copyright owner.
// 
// Document:	Data/BuffData.cs
// Date:		22/09/2015
// Author:		Robin Kurisu
#endregion

using LeagueSharp;
using System.Collections.Generic;

namespace Activator.Data
{
    public class BuffData
    {
        public string Name { get; set; }
        public string MenuName { get; set; }
        public string Champion { get; set; }
        public bool Evade { get; set; }
        public bool DoT { get; set; }
        public int EvadeTimer { get; set; }
        public int IncomeDamage { get; set; }
        public bool Cleanse { get; set; }
        public double Interval { get; set; }
        public int CleanseTimer { get; set; }
        public int TickLimiter { get; set; }
        public SpellSlot Slot { get; set; }
        public bool QssIgnore { get; set; }

        public bool Included { get; set; }
        public Obj_AI_Hero Sender { get; set; }

        public static List<BuffData> BuffList = new List<BuffData>();

        static BuffData()
        {
            BuffList.Add(new BuffData
            {
                Name = "suppression",
                MenuName = "Suppresion",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.R,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Name = "summonerdot",
                MenuName = "Summoner Ignite",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.Unknown,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Champion = "Vi",
                Name = "virknockup",
                MenuName = "Vi R Knockup",
                Evade = true,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.Unknown,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Name = "itemsmitechallenge",
                MenuName = "Challenging Smite",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 100,
                Slot = SpellSlot.Unknown,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Champion = "Gangplank",
                MenuName = "Gangplank Passive Burn",
                Name = "gangplankpassiveattackdot",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.Unknown,
                Interval = .8
            });

            BuffList.Add(new BuffData
            {
                Champion = "Teemo",
                Name = "bantamtraptarget",
                MenuName = "Teemo Shroom",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.Unknown,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Champion = "Teemo",
                Name = "toxicshotparticle",
                MenuName = "Teemo Toxic Shot",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.E,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Champion = "Talon",
                Name = "talonbleeddebuf",
                MenuName = "Talon Bleed",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.Q,
                Interval = .8
            });

            BuffList.Add(new BuffData()
            {
                Champion = "Malzahar",
                Name = "alzaharnethergrasp",
                MenuName = "Malzahar Nether Grasp",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.R,
                Interval = .8
            });

            BuffList.Add(new BuffData
            {
                Champion = "Malzahar",
                Name = "alzaharmaleficvisions",
                MenuName = "Malzahar Aids",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.E,
                Interval = .8
            });

            BuffList.Add(new BuffData
            {
                Champion = "FiddleSticks",
                Name = "drainchannel",
                MenuName = "Fiddle Drain",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.W,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Champion = "Galio",
                Name = "galioidolofdurand",
                MenuName = "Galio Idol of Durand",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.R,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Champion = "Nasus",
                Name = "nasusw",
                MenuName = "Nasus Wither",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.W,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Champion = "Hecarim",
                Name = "hecarimdefilelifeleech",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.W,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Champion = "Swain",
                Name = "swaintorment",
                MenuName = "Swain Torment",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.E,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Champion = "Brand",
                Name = "brandablaze",
                MenuName = "Brand Blaze",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.Unknown,
                Interval = 0.5
            });

            BuffList.Add(new BuffData
            {
                Champion = "Fizz",
                Name = "fizzseastonetrident",
                MenuName = "Fizz Burn Passive",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.Unknown,
                Interval = .8
            });

            BuffList.Add(new BuffData
            {
                Champion = "Tristana",
                Name = "tristanaechargesound",
                MenuName = "Tristana Explosive Charge",
                Evade = false,
                DoT = true, // not really a dot but can be cleansed
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.E,
                Interval = .8
            });

            BuffList.Add(new BuffData
            {
                Champion = "Darius",
                Name = "dariushemo",
                MenuName = "Darius Hemorrhage",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.W,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Champion = "Nidalee",
                Name = "bushwackdamage",
                MenuName = "Nidalee Bushwhack",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.W,
                Interval = .8
            });

            BuffList.Add(new BuffData
            {
                Champion = "Nidalee",
                Name = "nidaleepassivehunted",
                MenuName = "Nidalee Passive Mark",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.Unknown,
                Interval = .8
            });

            BuffList.Add(new BuffData
            {
                Name = "shyvanaimmolationaura",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.W,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Name = "missfortunescattershotslow",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.E,
                Interval = 0.8
            });

            BuffList.Add(new BuffData
            {
                Name = "missfortunepassivestack",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.R,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Name = "shyvanaimmolatedragon",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.W,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Champion = "Zilean",
                Name = "zileanqenemybomb",
                MenuName = "Zilean Bomb",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.Q,
                Interval = 3.8
            });

            BuffList.Add(new BuffData
            {
                Champion = "Wukong",
                Name = "monkeykingspintowin",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.R,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Champion = "Cassiopeia",
                Name = "cassiopeiapetrifyinggazestun",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 100,
                Slot = SpellSlot.R,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Champion = "Lissandra",
                Name = "lissandrarenemy2",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 100,
                Slot = SpellSlot.R,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Champion = "Sejuani",
                Name = "sejuaniglacialprison",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 100,
                Slot = SpellSlot.R,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Champion = "Zac",
                Name = "zacr",
                Evade = true,
                DoT = true,
                EvadeTimer = 150,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.R,
                Interval = 1.5

            });

            BuffList.Add(new BuffData
            {
                Champion = "Mordekaiser",
                Name = "mordekaiserchildrenofthegrave",
                MenuName = "Morde Children of the Grave",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.Unknown,
                Interval = 1.5
            });

            BuffList.Add(new BuffData
            {
                Name = "burningagony",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.Unknown,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Name = "garene",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.E,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Name = "auraofdespair",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.W,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Name = "hecarimw",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.W,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Champion = "Bruam",
                Name = "bruammark",
                MenuName = "Bruam Passive",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 200,
                Slot = SpellSlot.Q
            });

            BuffList.Add(new BuffData
            {
                Champion = "Zed",
                Name = "zedulttargetmark",
                MenuName = "Zed Mark",
                Evade = true,
                DoT = false,
                EvadeTimer = 2800,
                Cleanse = true,
                CleanseTimer = 1500,
                Slot = SpellSlot.R,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Champion = "Karthus",
                Name = "fallenonetarget",
                Evade = true,
                DoT = false,
                EvadeTimer = 2600,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.R
            });

            BuffList.Add(new BuffData
            {
                Champion = "Karthus",
                Name = "karthusfallenonetarget",
                Evade = true,
                DoT = false,
                EvadeTimer = 2600,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.R
            });

            BuffList.Add(new BuffData
            {
                Champion = "Fizz",
                Name = "fizzmarinerdoombomb",
                MenuName = "Fizz Shark Bait",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.R
            });

            BuffList.Add(new BuffData
            {
                Champion = "Morgana",
                Name = "soulshackles",
                MenuName = "Morgana Soul Shackles",
                Evade = true,
                DoT = false,
                EvadeTimer = 2600,
                Cleanse = true,
                CleanseTimer = 1100,
                Slot = SpellSlot.R,
                Interval = 3.9
            });

            BuffList.Add(new BuffData
            {
                Champion = "Varus",
                Name = "varusrsecondary",
                MenuName = "Varus Chains of Corruption",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.R
            });

            BuffList.Add(new BuffData
            {
                Champion = "Caitlyn",
                Name = "caitlynaceinthehole",
                Evade = true,
                DoT = false,
                EvadeTimer = 900,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.R
            });

            BuffList.Add(new BuffData
            {
                Champion = "Vladimir",
                Name = "vladimirhemoplague",
                MenuName = "Vladimir Hemoplague",
                Evade = true,
                DoT = false,
                EvadeTimer = 4500,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.R
            });

            BuffList.Add(new BuffData
            {
                Champion = "Urgot",
                Name = "urgotswap2",
                MenuName = "Urgot Swap",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.R
            });

            BuffList.Add(new BuffData
            {
                Champion = "Skarner",
                Name = "skarnerimpale",
                MenuName = "Skarner Impale",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 500,
                Slot = SpellSlot.R
            });

            BuffList.Add(new BuffData
            {
                Champion = "Poppy",
                Name = "poppyulttargetmark",
                MenuName = "Poppy Diplomatic Immunity",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.R
            });

            BuffList.Add(new BuffData
            {
                Champion = "LeeSin",
                Name = "blindmonkqonechaos",
                MenuName = "Lee Sonic Wave",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.Q
            });

            BuffList.Add(new BuffData
            {
                Champion = "Leblanc",
                Name = "leblancsoulshackle",
                MenuName = "Leblanc Shackle",
                Evade = false,
                DoT = false,
                EvadeTimer = 2000,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.E
            });

            BuffList.Add(new BuffData
            {
                Champion = "Leblanc",
                Name = "leblancsoulshacklem",
                MenuName = "Leblanc Shackle (R)",
                Evade = true,
                DoT = false,
                EvadeTimer = 2000,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.E
            });

            BuffList.Add(new BuffData
            {
                Name = "vir",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new BuffData
            {
                Name = "virknockup",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new BuffData
            {
                Name = "yasuorknockupcombo",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new BuffData
            {
                Name = "yasuorknockupcombotar",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new BuffData
            {
                Name = "zyrabramblezoneknockup",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new BuffData
            {
                Name = "velkozresearchstack",
                Evade = false,
                DoT = true,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown,
                Interval = 1.2
            });

            BuffList.Add(new BuffData
            {
                Name = "frozenheartaura",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new BuffData
            {
                Name = "dariusaxebrabcone",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new BuffData
            {
                Name = "frozenheartauracosmetic",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new BuffData
            {
                Name = "itemsunfirecapeaura",
                Evade = false,
                DoT = true,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Name = "fizzmoveback",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new BuffData
            {
                Name = "blessingofthelizardelderslow",
                Evade = false,
                DoT = true,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown,
                Interval = 1.0
            });

            BuffList.Add(new BuffData
            {
                Name = "dragonburning",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new BuffData
            {
                Name = "rocketgrab2",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new BuffData
            {
                Name = "frostarrow",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new BuffData
            {
                Name = "Pulverize",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Q
            });

            BuffList.Add(new BuffData
            {
                Name = "monkeykingspinknockup",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new BuffData
            {
                Name = "headbutttarget",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.W
            });

            BuffList.Add(new BuffData
            {
                Name = "hecarimrampstuncheck",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new BuffData
            {
                Name = "hecarimrampattackknockback",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });
        }
    }
}