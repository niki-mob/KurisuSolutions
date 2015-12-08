#region Copyright © 2015 Kurisu Solutions
// All rights are reserved. Transmission or reproduction in part or whole,
// any form or by any means, mechanical, electronical or otherwise, is prohibited
// without the prior written consent of the copyright owner.
// 
// Document:	Data/Auradata.cs
// Date:		22/09/2015
// Author:		Robin Kurisu
#endregion

using LeagueSharp;
using System.Collections.Generic;

namespace Activator.Data
{
    public class Auradata
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

        public static List<Auradata> BuffList = new List<Auradata>();

        static Auradata()
        {
            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata()
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
            {
                Name = "missfortunescattershotslow",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.E,
                Interval = 0.5
            });

            BuffList.Add(new Auradata
            {
                Name = "missfortunepassivestack",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.R,
                Interval = 0.5
            });

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
            {
                Champion = "Braum",
                Name = "braummark",
                MenuName = "Braum Passive",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 200,
                Slot = SpellSlot.Q
            });

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
            {
                Name = "velkozresearchstack",
                Evade = false,
                DoT = true,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown,
                Interval = 0.3
            });

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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

            BuffList.Add(new Auradata
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