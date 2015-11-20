#region Copyright © 2015 Kurisu Solutions
// All rights are reserved. Transmission or reproduction in part or whole,
// any form or by any means, mechanical, electronical or otherwise, is prohibited
// without the prior written consent of the copyright owner.
// 
// Document:	Data/Spelldata.cs
// Date:		22/09/2015
// Author:		Robin Kurisu
#endregion

using System.Linq;
using LeagueSharp;
using Activator.Base;
using LeagueSharp.Common;
using System.Collections.Generic;

namespace Activator.Data
{
    public class Skilldata
    {
        public string SDataName { get; set; }
        public string ChampionName { get; set; }
        public SpellSlot Slot { get; set; }
        public float CastRange { get; set; }
        public bool Global { get; set; }
        public float Delay { get; set; }
        public string MissileName { get; set; }
        public string[] ExtraMissileNames { get; set; }
        public int MissileSpeed { get; set; }
        public string[] FromObject { get; set; }
        public HitType[] HitType { get; set; }

        static Skilldata()
        {
            Spells.Add(new Skilldata
            {
                SDataName = "aatroxq",
                ChampionName = "aatrox",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "",
                MissileSpeed = 2000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "aatroxw",
                ChampionName = "aatrox",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "aatroxw2",
                ChampionName = "aatrox",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "aatroxe",
                ChampionName = "aatrox",
                Slot = SpellSlot.E,
                CastRange = 1025f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "aatroxeconemissile",
                MissileSpeed = 1250
            });

            Spells.Add(new Skilldata
            {
                SDataName = "aatroxr",
                ChampionName = "aatrox",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ahriorbofdeception",
                ChampionName = "ahri",
                Slot = SpellSlot.Q,
                CastRange = 880f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "ahriorbmissile",
                ExtraMissileNames = new [] { "ahriorbreturn" },
                MissileSpeed = 1450
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ahrifoxfire",
                ChampionName = "ahri",
                Slot = SpellSlot.W,
                CastRange = 550f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1800
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ahriseduce",
                ChampionName = "ahri",
                Slot = SpellSlot.E,
                CastRange = 975f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "ahriseducemissile",
                MissileSpeed = 1550
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ahritumble",
                ChampionName = "ahri",
                Slot = SpellSlot.R,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "akalimota",
                ChampionName = "akali",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 650f,
                HitType = new HitType[] { },
                MissileSpeed = 1000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "akalismokebomb",
                ChampionName = "akali",
                Slot = SpellSlot.W,
                CastRange = 1000f, // Range: 700 + additional for stealth detection
                Delay = 250f,
                HitType = new[] { Base.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "akalishadowswipe",
                ChampionName = "akali",
                Slot = SpellSlot.E,
                CastRange = 325f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "akalishadowdance",
                ChampionName = "akali",
                Slot = SpellSlot.R,
                CastRange = 710f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "pulverize",
                ChampionName = "alistar",
                Slot = SpellSlot.Q,
                CastRange = 365f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "headbutt",
                ChampionName = "alistar",
                Slot = SpellSlot.W,
                CastRange = 650f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "triumphantroar",
                ChampionName = "alistar",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "feroucioushowl",
                ChampionName = "alistar",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 828
            });

            Spells.Add(new Skilldata
            {
                SDataName = "bandagetoss",
                ChampionName = "amumu",
                Slot = SpellSlot.Q,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "sadmummybandagetoss",
                MissileSpeed = 2000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "auraofdespair",
                ChampionName = "amumu",
                Slot = SpellSlot.W,
                CastRange = 300f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "tantrum",
                ChampionName = "amumu",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 150f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "curseofthesadmummy",
                ChampionName = "amumu",
                Slot = SpellSlot.R,
                CastRange = 560f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileName = "",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "flashfrost",
                ChampionName = "anivia",
                Slot = SpellSlot.Q,
                CastRange = 1150f, // 1075 + Shatter Radius
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "flashfrostspell",
                MissileSpeed = 850
            });

            Spells.Add(new Skilldata
            {
                SDataName = "crystalize",
                ChampionName = "anivia",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "frostbite",
                ChampionName = "anivia",
                Slot = SpellSlot.E,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = 1450
            });

            Spells.Add(new Skilldata
            {
                SDataName = "glacialstorm",
                ChampionName = "anivia",
                Slot = SpellSlot.R,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "disintegrate",
                ChampionName = "annie",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new [] { Base.HitType.Danger },
                MissileSpeed = 1400
            });

            Spells.Add(new Skilldata
            {
                SDataName = "incinerate",
                ChampionName = "annie",
                Slot = SpellSlot.W,
                CastRange = 625f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "moltenshield",
                ChampionName = "annie",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "infernalguardian",
                ChampionName = "annie",
                Slot = SpellSlot.R,
                CastRange = 900f, // 600 + Cast Radius
                Delay = 0f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "frostshot",
                ChampionName = "ashe",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "frostarrow",
                ChampionName = "ashe",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 0f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "volley",
                ChampionName = "ashe",
                Slot = SpellSlot.W,
                CastRange = 1200f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "volleyattack",
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ashespiritofthehawk",
                ChampionName = "ashe",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new Skilldata
            {
                SDataName = "enchantedcrystalarrow",
                ChampionName = "ashe",
                Slot = SpellSlot.R,
                CastRange = 20000f,
                Global = true,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileName = "enchantedcrystalarrow",
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "azirq",
                ChampionName = "azir",
                Slot = SpellSlot.Q,
                CastRange = 875f,
                Delay = 250f,
                HitType = new[] {Base.HitType.CrowdControl },
                MissileName = "azirsoldiermissile",
                FromObject = new []{ "AzirSoldier" },
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "azirr",
                ChampionName = "azir",
                Slot = SpellSlot.R,
                CastRange = 475f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "bardq",
                ChampionName = "bard",
                Slot = SpellSlot.Q,
                CastRange = 950f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "bardqmissile",
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "bardw",
                ChampionName = "bard",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1450
            });

            Spells.Add(new Skilldata
            {
                SDataName = "barde",
                ChampionName = "bard",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 350f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "bardr",
                ChampionName = "bard",
                Slot = SpellSlot.R,
                CastRange = 3400f,
                Delay = 450f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "bardr",
                MissileSpeed = 2100
            });

            Spells.Add(new Skilldata
            {
                SDataName = "rocketgrabmissile",
                ChampionName = "blitzcrank",
                Slot = SpellSlot.Q,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileSpeed = 1800
            });

            Spells.Add(new Skilldata
            {
                SDataName = "overdrive",
                ChampionName = "blitzcrank",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "powerfist",
                ChampionName = "blitzcrank",
                Slot = SpellSlot.E,
                CastRange = 100f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "staticfield",
                ChampionName = "blitzcrank",
                Slot = SpellSlot.R,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "brandblaze",
                ChampionName = "brand",
                Slot = SpellSlot.Q,
                CastRange = 1150f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "brandblazemissile",
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "brandfissure",
                ChampionName = "brand",
                Slot = SpellSlot.W,
                CastRange = 240f,
                Delay = 550f,
                HitType = new[] { Base.HitType.Danger },
                MissileName = "",
                MissileSpeed = 20
            });

            Spells.Add(new Skilldata
            {
                SDataName = "brandconflagration",
                ChampionName = "brand",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "brandwildfire",
                ChampionName = "brand",
                Slot = SpellSlot.R,
                CastRange = 750f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileSpeed = 1000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "braumq",
                ChampionName = "braum",
                Slot = SpellSlot.Q,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "braumqmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "braumqmissle",
                ChampionName = "braum",
                Slot = SpellSlot.Q,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "braumw",
                ChampionName = "braum",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "braume",
                ChampionName = "braum",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "braumrwrapper",
                ChampionName = "braum",
                Slot = SpellSlot.R,
                CastRange = 1250f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileName = "braumrmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "caitlynpiltoverpeacemaker",
                ChampionName = "caitlyn",
                Slot = SpellSlot.Q,
                CastRange = 2000f,
                Delay = 625f,
                HitType = new HitType[] { },
                MissileName = "caitlynpiltoverpeacemaker",
                MissileSpeed = 2200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "caitlynyordletrap",
                ChampionName = "caitlyn",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 550f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new Skilldata
            {
                SDataName = "caitlynentrapment",
                ChampionName = "caitlyn",
                Slot = SpellSlot.E,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "caitlynentrapmentmissile",
                MissileSpeed = 2000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "cassiopeianoxiousblast",
                ChampionName = "cassiopeia",
                Slot = SpellSlot.Q,
                CastRange = 925f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "cassiopeianoxiousblast",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "cassiopeiamiasma",
                ChampionName = "cassiopeia",
                Slot = SpellSlot.W,
                CastRange = 925f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 2500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "cassiopeiatwinfang",
                ChampionName = "cassiopeia",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1900
            });

            Spells.Add(new Skilldata
            {
                SDataName = "cassiopeiapetrifyinggaze",
                ChampionName = "cassiopeia",
                Slot = SpellSlot.R,
                CastRange = 875f,
                Delay = 350f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileName = "cassiopeiapetrifyinggaze",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "rupture",
                ChampionName = "chogath",
                Slot = SpellSlot.Q,
                CastRange = 950f,
                Delay = 1000f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "rupture",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "feralscream",
                ChampionName = "chogath",
                Slot = SpellSlot.W,
                CastRange = 675f,
                Delay = 175f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "vorpalspikes",
                ChampionName = "chogath",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 347
            });

            Spells.Add(new Skilldata
            {
                SDataName = "feast",
                ChampionName = "chogath",
                Slot = SpellSlot.R,
                CastRange = 500f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "phosphorusbomb",
                ChampionName = "corki",
                Slot = SpellSlot.Q,
                CastRange = 875f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "phosphorusbombmissile",
                MissileSpeed = 1125
            });

            Spells.Add(new Skilldata
            {
                SDataName = "carpetbomb",
                ChampionName = "corki",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 700
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ggun",
                ChampionName = "corki",
                Slot = SpellSlot.E,
                CastRange = 750f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "missilebarrage",
                ChampionName = "corki",
                Slot = SpellSlot.R,
                CastRange = 1225f,
                Delay = 150f,
                HitType = new HitType[] { },
                MissileName = "missilebarragemissile",
                ExtraMissileNames = new []{ "missilebarragemissile2"},
                MissileSpeed = 2000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "dariuscleave",
                ChampionName = "darius",
                Slot = SpellSlot.Q,
                CastRange = 425f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "dariusnoxiantacticsonh",
                ChampionName = "darius",
                Slot = SpellSlot.W,
                CastRange = 205f,
                Delay = 150f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "dariusaxegrabcone",
                ChampionName = "darius",
                Slot = SpellSlot.E,
                CastRange = 555f,
                Delay = 150f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileName = "dariusaxegrabcone",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "dariusexecute",
                ChampionName = "darius",
                Slot = SpellSlot.R,
                CastRange = 465f,
                Delay = 450f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "dianaarc",
                ChampionName = "diana",
                Slot = SpellSlot.Q,
                CastRange = 830f,
                Delay = 300f,
                HitType = new HitType[] { },
                MissileName = "dianaarc",
                MissileSpeed = 1400
            });

            Spells.Add(new Skilldata
            {
                SDataName = "dianaorbs",
                ChampionName = "diana",
                Slot = SpellSlot.W,
                CastRange = 200f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "dianavortex",
                ChampionName = "diana",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger  },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "dianateleport",
                ChampionName = "diana",
                Slot = SpellSlot.R,
                CastRange = 825f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = 2200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "dravenspinning",
                ChampionName = "draven",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "dravenfury",
                ChampionName = "draven",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "dravendoubleshot",
                ChampionName = "draven",
                Slot = SpellSlot.E,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "dravendoubleshotmissile",
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "dravenrcast",
                ChampionName = "draven",
                Slot = SpellSlot.R,
                CastRange = 20000f,
                Global = true,
                Delay = 500f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileName = "dravenr",
                MissileSpeed = 2000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "infectedcleavermissilecast",
                ChampionName = "drmundo",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "infectedcleavermissile",
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "burningagony",
                ChampionName = "drmundo",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "masochism",
                ChampionName = "drmundo",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "sadism",
                ChampionName = "drmundo",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ekkoq",
                ChampionName = "ekko",
                Slot = SpellSlot.Q,
                CastRange = 1075f,
                Delay = 66f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "ekkoqmis",
                ExtraMissileNames = new []{ "ekkoqreturn" },
                MissileSpeed = 1400
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ekkoeattack",
                ChampionName = "ekko",
                Slot = SpellSlot.E,
                CastRange = 300f,
                Delay = 0f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

             Spells.Add(new Skilldata
             {
                 SDataName = "ekkor",
                 ChampionName = "ekko",
                 Slot = SpellSlot.R,
                 CastRange = 425f,
                 Delay = 250f,
                 HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                 FromObject = new [] { "Ekko_Base_R_TrailEnd" },
                 MissileSpeed = int.MaxValue
             });

            Spells.Add(new Skilldata
            {
                SDataName = "elisehumanq",
                ChampionName = "elise",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 550f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "elisespiderqcast",
                ChampionName = "elise",
                Slot = SpellSlot.Q,
                CastRange = 475f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "elisehumanw",
                ChampionName = "elise",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = 5000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "elisespiderw",
                ChampionName = "elise",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "elisehumane",
                ChampionName = "elise",
                Slot = SpellSlot.E,
                CastRange = 1075f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileName = "elisehumane",
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "elisespidereinitial",
                ChampionName = "elise",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "elisespideredescent",
                ChampionName = "elise",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "eliser",
                ChampionName = "elise",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "elisespiderr",
                ChampionName = "elise",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "evelynnq",
                ChampionName = "evelynn",
                Slot = SpellSlot.Q,
                CastRange = 500f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "evelynnw",
                ChampionName = "evelynn",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "evelynne",
                ChampionName = "evelynn",
                Slot = SpellSlot.E,
                CastRange = 225f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "evelynnr",
                ChampionName = "evelynn",
                Slot = SpellSlot.R,
                CastRange = 900f, // 650f + Radius
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileName = "evelynnr",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ezrealmysticshot",
                ChampionName = "ezreal",
                Slot = SpellSlot.Q,
                CastRange = 1150f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger  },
                MissileName = "ezrealmysticshotmissile",
                ExtraMissileNames = new[] { "ezrealmysticshotpulsemissile" },
                MissileSpeed = 2000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ezrealessenceflux",
                ChampionName = "ezreal",
                Slot = SpellSlot.W,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "ezrealessencefluxmissile",
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ezrealessencemissle",
                ChampionName = "ezreal",
                Slot = SpellSlot.W,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ezrealarcaneshift",
                ChampionName = "ezreal",
                Slot = SpellSlot.E,
                CastRange = 750f, // 475f + Bolt Range
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ezrealtrueshotbarrage",
                ChampionName = "ezreal",
                Slot = SpellSlot.R,
                CastRange = 20000f,
                Global = true,
                Delay = 1000f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileName = "ezrealtrueshotbarrage",
                MissileSpeed = 2000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "terrify",
                ChampionName = "fiddlesticks",
                Slot = SpellSlot.Q,
                CastRange = 575f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "drain",
                ChampionName = "fiddlesticks",
                Slot = SpellSlot.W,
                CastRange = 575f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "fiddlesticksdarkwind",
                ChampionName = "fiddlesticks",
                Slot = SpellSlot.E,
                CastRange = 750f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1100
            });

            Spells.Add(new Skilldata
            {
                SDataName = "crowstorm",
                ChampionName = "fiddlesticks",
                Slot = SpellSlot.R,
                CastRange = 800f,
                Delay = 250f,
                HitType = new[] { Base.HitType.ForceExhaust },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "fioraq",
                ChampionName = "fiora",
                Slot = SpellSlot.Q,
                CastRange = 400f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "fioraw",
                ChampionName = "fiora",
                Slot = SpellSlot.W,
                CastRange = 750f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "fiorae",
                ChampionName = "fiora",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "fiorar",
                ChampionName = "fiora",
                Slot = SpellSlot.R,
                CastRange = 500f,
                Delay = 150f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "fizzpiercingstrike",
                ChampionName = "fizz",
                Slot = SpellSlot.Q,
                CastRange = 550f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1900
            });

            Spells.Add(new Skilldata
            {
                SDataName = "fizzseastonepassive",
                ChampionName = "fizz",
                Slot = SpellSlot.W,
                CastRange = 175f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "fizzjump",
                ChampionName = "fizz",
                Slot = SpellSlot.E,
                CastRange = 450f,
                Delay = 700f,
                HitType = new[] { Base.HitType.CrowdControl  },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "fizzjumpbuffer",
                ChampionName = "fizz",
                Slot = SpellSlot.E,
                CastRange = 330f,
                Delay = 0f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "fizzjumptwo",
                ChampionName = "fizz",
                Slot = SpellSlot.E,
                CastRange = 270f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue 
            });

            Spells.Add(new Skilldata
            {
                SDataName = "fizzmarinerdoom",
                ChampionName = "fizz",
                Slot = SpellSlot.R,
                CastRange = 1275f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "fizzmarinerdoommissile",
                MissileSpeed = 1350
            });

            Spells.Add(new Skilldata
            {
                SDataName = "galioresolutesmite",
                ChampionName = "galio",
                Slot = SpellSlot.Q,
                CastRange = 1040f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "galioresolutesmite",
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "galiobulwark",
                ChampionName = "galio",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "galiorighteousgust",
                ChampionName = "galio",
                Slot = SpellSlot.E,
                CastRange = 1280f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "galiorighteousgust",
                MissileSpeed = 1300
            });

            Spells.Add(new Skilldata
            {
                SDataName = "galioidolofdurand",
                ChampionName = "galio",
                Slot = SpellSlot.R,
                CastRange = 600f,
                Delay = 0f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileName = "",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "gangplankqwrapper",
                ChampionName = "gangplank",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "gangplankqproceed",
                ChampionName = "gangplank",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "gangplankw",
                ChampionName = "gangplank",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "gangplanke",
                ChampionName = "gangplank",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "gangplankr",
                ChampionName = "gangplank",
                Slot = SpellSlot.R,
                CastRange = 20000f,
                Global = true,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "garenq",
                ChampionName = "garen",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 300f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "garenqattack",
                ChampionName = "garen",
                Slot = SpellSlot.Q,
                CastRange = 350f,
                Delay = 0f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });


            Spells.Add(new Skilldata
            {
                SDataName = "gnarq",
                ChampionName = "gnar",
                Slot = SpellSlot.Q,
                CastRange = 1185f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 2400,
                MissileName = "gnarqmissile",
                ExtraMissileNames = new[] { "gnarqmissilereturn" }
            });


            Spells.Add(new Skilldata
            {
                SDataName = "gnarbigq",
                ChampionName = "gnar",
                Slot = SpellSlot.Q,
                CastRange = 1150f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 2000,
                MissileName = "gnarbigqmissile"
            });

            Spells.Add(new Skilldata
            {
                SDataName = "gnarbigw",
                ChampionName = "gnar",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 600f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "gnarult",
                ChampionName = "gnar",
                CastRange = 600f, // 590f + 10 Better safe than sorry. :)
                Slot = SpellSlot.R,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },

                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "garenw",
                ChampionName = "garen",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "garene",
                ChampionName = "garen",
                Slot = SpellSlot.E,
                CastRange = 300f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "garenr",
                ChampionName = "garen",
                Slot = SpellSlot.R,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "gragasq",
                ChampionName = "gragas",
                Slot = SpellSlot.Q,
                CastRange = 1000, // 850f + Radius
                Delay = 500f,
                HitType = new HitType[] { },
                MissileName = "gragasqmissile",
                MissileSpeed = 1000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "gragasqtoggle",
                ChampionName = "gragas",
                Slot = SpellSlot.Q,
                CastRange = 1100f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "gragasw",
                ChampionName = "gragas",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "gragase",
                ChampionName = "gragas",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 200f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "gragase",
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "gragasr",
                ChampionName = "gragas",
                Slot = SpellSlot.R,
                CastRange = 1150f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "gragasrboom",
                MissileSpeed = 1750
            });

            Spells.Add(new Skilldata
            {
                SDataName = "gravesclustershot",
                ChampionName = "graves",
                Slot = SpellSlot.Q,
                CastRange = 1025,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "gravesclustershotattack",
                MissileSpeed = 2000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "gravessmokegrenade",
                ChampionName = "graves",
                Slot = SpellSlot.W,
                CastRange = 1100f,
                Delay = 300f,
                HitType = new HitType[] { },
                MissileSpeed = 1650
            });

            Spells.Add(new Skilldata
            {
                SDataName = "gravessmokegrenadeboom",
                ChampionName = "graves",
                Slot = SpellSlot.W,
                CastRange = 1100f, // 950 + Radius
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1350
            });

            Spells.Add(new Skilldata
            {
                SDataName = "gravesmove",
                ChampionName = "graves",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 300f,
                HitType = new HitType[] { },
                MissileSpeed = 1000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "graveschargeshot",
                ChampionName = "graves",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileName = "graveschargeshotshot",
                MissileSpeed = 2100
            });

            Spells.Add(new Skilldata
            {
                SDataName = "hecarimrapidslash",
                ChampionName = "hecarim",
                Slot = SpellSlot.Q,
                CastRange = 350f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "hecarimw",
                ChampionName = "hecarim",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "hecarimramp",
                ChampionName = "hecarim",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "hecarimult",
                ChampionName = "hecarim",
                Slot = SpellSlot.R,
                CastRange = 1350f,
                Delay = 50f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "heimerdingerturretenergyblast",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 435f,
                HitType = new HitType[] { },
                MissileSpeed = 1650
            });

            Spells.Add(new Skilldata
            {
                SDataName = "heimerdingerturretbigenergyblast",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 350f,
                HitType = new HitType[] { },
                MissileSpeed = 1650
            });

            Spells.Add(new Skilldata
            {
                SDataName = "heimerdingerw",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.W,
                CastRange = 1100,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1750
            });

            Spells.Add(new Skilldata
            {
                SDataName = "heimerdingere",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.E,
                CastRange = 1025f, // 925 + Radius
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "heimerdingerespell",
                MissileSpeed = 1450
            });

            Spells.Add(new Skilldata
            {
                SDataName = "heimerdingerr",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 230f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "heimerdingereult",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.E,
                CastRange = 1250f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1450
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ireliagatotsu",
                ChampionName = "irelia",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 150f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ireliahitenstyle",
                ChampionName = "irelia",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 230f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ireliaequilibriumstrike",
                ChampionName = "irelia",
                Slot = SpellSlot.E,
                CastRange = 450f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ireliatranscendentblades",
                ChampionName = "irelia",
                Slot = SpellSlot.R,
                CastRange = 1200f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileName = "ireliatranscendentbladesspell",
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "howlinggalespell",
                ChampionName = "janna",
                Slot = SpellSlot.Q,
                CastRange = 1550f,
                Delay = 0f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "howlinggalespell",
                MissileSpeed = 2000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "sowthewind",
                ChampionName = "janna",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "eyeofthestorm",
                ChampionName = "janna",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "reapthewhirlwind",
                ChampionName = "janna",
                Slot = SpellSlot.R,
                CastRange = 725f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "jarvanivdragonstrike",
                ChampionName = "jarvaniv",
                Slot = SpellSlot.Q,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "",
                MissileSpeed = 2000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "jarvanivgoldenaegis",
                ChampionName = "jarvaniv",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "jarvanivdemacianstandard",
                ChampionName = "jarvaniv",
                Slot = SpellSlot.E,
                CastRange = 830f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "jarvanivdemacianstandard",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "jarvanivcataclysm",
                ChampionName = "jarvaniv",
                Slot = SpellSlot.R,
                CastRange = 825f,
                Delay = 0f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "jaxleapstrike",
                ChampionName = "jax",
                Slot = SpellSlot.Q,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = 2200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "jaxempowertwo",
                ChampionName = "jax",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "jaxrelentlessasssault",
                ChampionName = "jax",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "jaycetotheskies",
                ChampionName = "jayce",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 450f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "jayceshockblast",
                ChampionName = "jayce",
                Slot = SpellSlot.Q,
                CastRange = 1570f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileName = "jayceshockblastmis",
                MissileSpeed = 2350
            });

            Spells.Add(new Skilldata
            {
                SDataName = "jaycestaticfield",
                ChampionName = "jayce",
                Slot = SpellSlot.W,
                CastRange = 285f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "jaycehypercharge",
                ChampionName = "jayce",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "jaycethunderingblow",
                ChampionName = "jayce",
                Slot = SpellSlot.E,
                CastRange = 325f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "jayceaccelerationgate",
                ChampionName = "jayce",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "jaycestancehtg",
                ChampionName = "jayce",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "jaycestancegth",
                ChampionName = "jayce",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "jinxq",
                ChampionName = "jinx",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "jinxw",
                ChampionName = "jinx",
                Slot = SpellSlot.W,
                CastRange = 1550f,
                Delay = 600f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "jinxwmis",
                MissileSpeed = 2200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "jinxe",
                ChampionName = "jinx",
                Slot = SpellSlot.E,
                CastRange = 900f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "jinxr",
                ChampionName = "jinx",
                Slot = SpellSlot.R,
                CastRange = 25000f,
                Global = true,
                Delay = 600f,
                MissileName = "jinxr",
                ExtraMissileNames = new [] { "jinxrwrapper" },
                HitType = new [] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileSpeed = 1700
            });

            Spells.Add(new Skilldata
            {
                SDataName = "karmaq",
                ChampionName = "karma",
                Slot = SpellSlot.Q,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "karmaqmissile",
                MissileSpeed = 1800
            });

            Spells.Add(new Skilldata
            {
                SDataName = "karmaspiritbind",
                ChampionName = "karma",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "karmasolkimshield",
                ChampionName = "karma",
                Slot = SpellSlot.E,
                CastRange = 800f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "karmamantra",
                ChampionName = "karma",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1300
            });

            Spells.Add(new Skilldata
            {
                SDataName = "laywaste",
                ChampionName = "karthus",
                Slot = SpellSlot.Q,
                CastRange = 875f,
                Delay = 900f,
                HitType = new HitType[] { },
                ExtraMissileNames = new[]  {
                            "karthuslaywastea3", "karthuslaywastea1", "karthuslaywastedeada1", "karthuslaywastedeada2",
                            "karthuslaywastedeada3"
                        },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "wallofpain",
                ChampionName = "karthus",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "defile",
                ChampionName = "karthus",
                Slot = SpellSlot.E,
                CastRange = 550f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "fallenone",
                ChampionName = "karthus",
                Slot = SpellSlot.R,
                CastRange = 22000f,
                Global = true,
                Delay = 2800f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "nulllance",
                ChampionName = "kassadin",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileSpeed = 1900
            });

            Spells.Add(new Skilldata
            {
                SDataName = "netherblade",
                ChampionName = "kassadin",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "forcepulse",
                ChampionName = "kassadin",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "riftwalk",
                ChampionName = "kassadin",
                Slot = SpellSlot.R,
                CastRange = 675f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "riftwalk",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "katarinaq",
                ChampionName = "katarina",
                Slot = SpellSlot.Q,
                CastRange = 675f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1800
            });

            Spells.Add(new Skilldata
            {
                SDataName = "katarinaw",
                ChampionName = "katarina",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1800
            });

            Spells.Add(new Skilldata
            {
                SDataName = "katarinae",
                ChampionName = "katarina",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "katarinar",
                ChampionName = "katarina",
                Slot = SpellSlot.R,
                CastRange = 550f,
                Delay = 250f,
                HitType = new[] { Base.HitType.ForceExhaust },
                MissileSpeed = 1450
            });

            Spells.Add(new Skilldata
            {
                SDataName = "judicatorreckoning",
                ChampionName = "kayle",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "judicatordevineblessing",
                ChampionName = "kayle",
                Slot = SpellSlot.W,
                CastRange = 900f,
                Delay = 220f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "judicatorrighteousfury",
                ChampionName = "kayle",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "judicatorintervention",
                ChampionName = "kayle",
                Slot = SpellSlot.R,
                CastRange = 900f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "kennenshurikenhurlmissile1",
                ChampionName = "kennen",
                Slot = SpellSlot.Q,
                CastRange = 1175f,
                Delay = 180f,
                HitType = new HitType[] { },
                MissileName = "kennenshurikenhurlmissile1",
                MissileSpeed = 1700
            });

            Spells.Add(new Skilldata
            {
                SDataName = "kennenbringthelight",
                ChampionName = "kennen",
                Slot = SpellSlot.W,
                CastRange = 900f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "kennenlightningrush",
                ChampionName = "kennen",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "kennenshurikenstorm",
                ChampionName = "kennen",
                Slot = SpellSlot.R,
                CastRange = 550f,
                Delay = 500f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "khazixq",
                ChampionName = "khazix",
                Slot = SpellSlot.Q,
                CastRange = 325f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "khazixqlong",
                ChampionName = "khazix",
                Slot = SpellSlot.Q,
                CastRange = 375f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "khazixw",
                ChampionName = "khazix",
                Slot = SpellSlot.W,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "khazixwmissile",
                MissileSpeed = 81700
            });

            Spells.Add(new Skilldata
            {
                SDataName = "khazixwlong",
                ChampionName = "khazix",
                Slot = SpellSlot.W,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1700
            });

            Spells.Add(new Skilldata
            {
                SDataName = "khazixe",
                ChampionName = "khazix",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "khazixe",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "khazixelong",
                ChampionName = "khazix",
                Slot = SpellSlot.E,
                CastRange = 900f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "khazixr",
                ChampionName = "khazix",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                Delay = 0f,
                HitType = new [] { Base.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "khazixrlong",
                ChampionName = "khazix",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                Delay = 0f,
                HitType = new[] { Base.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "kindredq",
                ChampionName = "kindred",
                Slot = SpellSlot.Q,
                CastRange = 350f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "kindrede",
                ChampionName = "kindred",
                Slot = SpellSlot.E,
                CastRange = 510f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "kogmawcausticspittle",
                ChampionName = "kogmaw",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "kogmawbioarcanbarrage",
                ChampionName = "kogmaw",
                Slot = SpellSlot.W,
                CastRange = 130f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "kogmawvoidooze",
                ChampionName = "kogmaw",
                Slot = SpellSlot.E,
                CastRange = 1150f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "kogmawvoidoozemissile",
                MissileSpeed = 1250
            });

            Spells.Add(new Skilldata
            {
                SDataName = "kogmawlivingartillery",
                ChampionName = "kogmaw",
                Slot = SpellSlot.R,
                CastRange = 2200f,
                Delay = 1200f,
                HitType = new[] { Base.HitType.Danger },
                MissileName = "kogmawlivingartillery",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "leblancchaosorb",
                ChampionName = "leblanc",
                Slot = SpellSlot.Q,
                CastRange = 700f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "leblancslide",
                ChampionName = "leblanc",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileName = "leblancslide",
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "leblacslidereturn",
                ChampionName = "leblanc",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "leblancsoulshackle",
                ChampionName = "leblanc",
                Slot = SpellSlot.E,
                CastRange = 925f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "leblancsoulshackle",
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "leblancchaosorbm",
                ChampionName = "leblanc",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = 2000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "leblancslidem",
                ChampionName = "leblanc",
                Slot = SpellSlot.R,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileName = "leblancslidem",
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "leblancslidereturnm",
                ChampionName = "leblanc",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "leblancsoulshacklem",
                ChampionName = "leblanc",
                Slot = SpellSlot.R,
                CastRange = 925f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "leblancsoulshacklem",
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "blindmonkqone",
                ChampionName = "leesin",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileName = "blindmonkqone",
                MissileSpeed = 1800
            });

            Spells.Add(new Skilldata
            {
                SDataName = "blindmonkqtwo",
                ChampionName = "leesin",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "blindmonkwone",
                ChampionName = "leesin",
                Slot = SpellSlot.W,
                CastRange = 700f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "blindmonkwtwo",
                ChampionName = "leesin",
                Slot = SpellSlot.W,
                CastRange = 700f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "blindmonkeone",
                ChampionName = "leesin",
                Slot = SpellSlot.E,
                CastRange = 425f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "blindmonketwo",
                ChampionName = "leesin",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "blindmonkrkick",
                ChampionName = "leesin",
                Slot = SpellSlot.R,
                CastRange = 375f,
                Delay = 500f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "leonashieldofdaybreak",
                ChampionName = "leona",
                Slot = SpellSlot.Q,
                CastRange = 215f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "leonasolarbarrier",
                ChampionName = "leona",
                Slot = SpellSlot.W,
                CastRange = 250f,
                Delay = 3000f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "leonazenithblade",
                ChampionName = "leona",
                Slot = SpellSlot.E,
                CastRange = 900f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileName = "leonazenithblademissile",
                MissileSpeed = 2000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "leonasolarflare",
                ChampionName = "leona",
                Slot = SpellSlot.R,
                CastRange = 1200f,
                Delay = 1200f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl  },
                MissileName = "leonasolarflare",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "lissandraq",
                ChampionName = "lissandra",
                Slot = SpellSlot.Q,
                CastRange = 725f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "lissandraqmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "lissandraw",
                ChampionName = "lissandra",
                Slot = SpellSlot.W,
                CastRange = 450f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "lissandrae",
                ChampionName = "lissandra",
                Slot = SpellSlot.E,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "lissandraemissile",
                MissileSpeed = 850
            });

            Spells.Add(new Skilldata
            {
                SDataName = "lissandrar",
                ChampionName = "lissandra",
                Slot = SpellSlot.R,
                CastRange = 550f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger, Base.HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "lucianq",
                ChampionName = "lucian",
                Slot = SpellSlot.Q,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileName = "lucianq",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "lucianw",
                ChampionName = "lucian",
                Slot = SpellSlot.W,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "lucianwmissile",
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "luciane",
                ChampionName = "lucian",
                Slot = SpellSlot.E,
                CastRange = 650f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "lucianr",
                ChampionName = "lucian",
                Slot = SpellSlot.R,
                CastRange = 1400f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileName  = "lucianrmissileoffhand",
                ExtraMissileNames = new[] { "lucianrmissile" },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "luluq",
                ChampionName = "lulu",
                Slot = SpellSlot.Q,
                CastRange = 925f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "luluqmissile",
                MissileSpeed = 1450
            });

            Spells.Add(new Skilldata
            {
                SDataName = "luluw",
                ChampionName = "lulu",
                Slot = SpellSlot.W,
                CastRange = 650f,
                Delay = 640f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 2000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "lulue",
                ChampionName = "lulu",
                Slot = SpellSlot.E,
                CastRange = 650f,
                Delay = 640f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "lulur",
                ChampionName = "lulu",
                Slot = SpellSlot.R,
                CastRange = 900f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "luxlightbinding",
                ChampionName = "lux",
                Slot = SpellSlot.Q,
                CastRange = 1300f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "luxlightbindingmis",
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "luxprismaticwave",
                ChampionName = "lux",
                Slot = SpellSlot.W,
                CastRange = 1075f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "luxlightstrikekugel",
                ChampionName = "lux",
                Slot = SpellSlot.E,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "luxlightstrikekugel",
                MissileSpeed = 1300
            });

            Spells.Add(new Skilldata
            {
                SDataName = "luxlightstriketoggle",
                ChampionName = "lux",
                Slot = SpellSlot.E,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "luxmalicecannon",
                ChampionName = "lux",
                Slot = SpellSlot.R,
                CastRange = 3340f,
                Delay = 1750f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileName = "luxmalicecannonmis",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "kalistamysticshot",
                ChampionName = "kalista",
                Slot = SpellSlot.Q,
                CastRange = 1200f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "kalistamysticshotmis",
                ExtraMissileNames = new[] { "kalistamysticshotmistrue" },
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "kalistaw",
                ChampionName = "kalista",
                Slot = SpellSlot.W,
                CastRange = 5000f,
                Delay = 800f,
                HitType = new HitType[] { },
                MissileSpeed = 200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "kalistaexpungewrapper",
                ChampionName = "kalista",
                Slot = SpellSlot.E,
                CastRange = 1200f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "seismicshard",
                ChampionName = "malphite",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "obduracy",
                ChampionName = "malphite",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "landslide",
                ChampionName = "malphite",
                Slot = SpellSlot.E,
                CastRange = 400f,
                Delay = 500f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ufslash",
                ChampionName = "malphite",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileName = "ufslash",
                MissileSpeed = 2200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "alzaharcallofthevoid",
                ChampionName = "malzahar",
                Slot = SpellSlot.Q,
                CastRange = 900f,
                Delay = 600f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "alzaharcallofthevoid",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "alzaharnullzone",
                ChampionName = "malzahar",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "alzaharmaleficvisions",
                ChampionName = "malzahar",
                Slot = SpellSlot.E,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "alzaharnethergrasp",
                ChampionName = "malzahar",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "maokaitrunkline",
                ChampionName = "maokai",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "maokaiunstablegrowth",
                ChampionName = "maokai",
                Slot = SpellSlot.W,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "maokaisapling2",
                ChampionName = "maokai",
                Slot = SpellSlot.E,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1750
            });

            Spells.Add(new Skilldata
            {
                SDataName = "maokaidrain3",
                ChampionName = "maokai",
                Slot = SpellSlot.R,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "alphastrike",
                ChampionName = "masteryi",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 600f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "meditate",
                ChampionName = "masteryi",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "wujustyle",
                ChampionName = "masteryi",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 230f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "highlander",
                ChampionName = "masteryi",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 370f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "missfortunericochetshot",
                ChampionName = "missfortune",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new Skilldata
            {
                SDataName = "missfortuneviciousstrikes",
                ChampionName = "missfortune",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "missfortunescattershot",
                ChampionName = "missfortune",
                Slot = SpellSlot.E,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "missfortunebullettime",
                ChampionName = "missfortune",
                Slot = SpellSlot.R,
                CastRange = 1400f,
                Delay = 500f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "monkeykingdoubleattack",
                ChampionName = "monkeyking",
                Slot = SpellSlot.Q,
                CastRange = 300f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 20
            });

            Spells.Add(new Skilldata
            {
                SDataName = "monkeykingdecoy",
                ChampionName = "monkeyking",
                Slot = SpellSlot.W,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "monkeykingdecoyswipe",
                ChampionName = "monkeyking",
                Slot = SpellSlot.W,
                CastRange = 325f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "monkeykingnimbus",
                ChampionName = "monkeyking",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "monkeykingspintowin",
                ChampionName = "monkeyking",
                Slot = SpellSlot.R,
                CastRange = 450f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "monkeykingspintowinleave",
                ChampionName = "monkeyking",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 700
            });

            Spells.Add(new Skilldata
            {
                SDataName = "mordekaisermaceofspades",
                ChampionName = "mordekaiser",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "mordekaisercreepindeathcast",
                ChampionName = "mordekaiser",
                Slot = SpellSlot.W,
                CastRange = 750f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "mordekaisersyphoneofdestruction",
                ChampionName = "mordekaiser",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "mordekaiserchildrenofthegrave",
                ChampionName = "mordekaiser",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "darkbindingmissile",
                ChampionName = "morgana",
                Slot = SpellSlot.Q,
                CastRange = 1175f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "darkbindingmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "tormentedsoil",
                ChampionName = "morgana",
                Slot = SpellSlot.W,
                CastRange = 850f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "blackshield",
                ChampionName = "morgana",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "soulshackles",
                ChampionName = "morgana",
                Slot = SpellSlot.R,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "namiq",
                ChampionName = "nami",
                Slot = SpellSlot.Q,
                CastRange = 875f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "namiqmissile",
                MissileSpeed = 1750
            });

            Spells.Add(new Skilldata
            {
                SDataName = "namiw",
                ChampionName = "nami",
                Slot = SpellSlot.W,
                CastRange = 725f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1100
            });

            Spells.Add(new Skilldata
            {
                SDataName = "namie",
                ChampionName = "nami",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "namir",
                ChampionName = "nami",
                Slot = SpellSlot.R,
                CastRange = 2550f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "namirmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "nasusq",
                ChampionName = "nasus",
                Slot = SpellSlot.Q,
                CastRange = 450f,
                Delay = 500f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "nasusw",
                ChampionName = "nasus",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "nasuse",
                ChampionName = "nasus",
                Slot = SpellSlot.E,
                CastRange = 850f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "nasusr",
                ChampionName = "nasus",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "nautilusanchordrag",
                ChampionName = "nautilus",
                Slot = SpellSlot.Q,
                CastRange = 1080f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileName = "nautilusanchordragmissile",
                MissileSpeed = 2000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "nautiluspiercinggaze",
                ChampionName = "nautilus",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "nautilussplashzone",
                ChampionName = "nautilus",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1300
            });

            Spells.Add(new Skilldata
            {
                SDataName = "nautilusgandline",
                ChampionName = "nautilus",
                Slot = SpellSlot.R,
                CastRange = 1250f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new Skilldata
            {
                SDataName = "javelintoss",
                ChampionName = "nidalee",
                Slot = SpellSlot.Q,
                CastRange = 1500f,
                Delay = 125f,
                HitType = new[] { Base.HitType.Danger },
                MissileName = "javelintoss",
                MissileSpeed = 1300
            });

            Spells.Add(new Skilldata
            {
                SDataName = "takedown",
                ChampionName = "nidalee",
                Slot = SpellSlot.Q,
                CastRange = 150f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "bushwhack",
                ChampionName = "nidalee",
                Slot = SpellSlot.W,
                CastRange = 900f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1450
            });

            Spells.Add(new Skilldata
            {
                SDataName = "pounce",
                ChampionName = "nidalee",
                Slot = SpellSlot.W,
                CastRange = 375f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "primalsurge",
                ChampionName = "nidalee",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "swipe",
                ChampionName = "nidalee",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "aspectofthecougar",
                ChampionName = "nidalee",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "nocturneduskbringer",
                ChampionName = "nocturne",
                Slot = SpellSlot.Q,
                CastRange = 1125f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "nocturneshroudofdarkness",
                ChampionName = "nocturne",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "nocturneunspeakablehorror",
                ChampionName = "nocturne",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "nocturneparanoia",
                ChampionName = "nocturne",
                Slot = SpellSlot.R,
                CastRange = 20000f,
                Global = true,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "consume",
                ChampionName = "nunu",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new Skilldata
            {
                SDataName = "bloodboil",
                ChampionName = "nunu",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "iceblast",
                ChampionName = "nunu",
                Slot = SpellSlot.E,
                CastRange = 550f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "absolutezero",
                ChampionName = "nunu",
                Slot = SpellSlot.R,
                CastRange = 650f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "olafaxethrowcast",
                ChampionName = "olaf",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "olafaxethrow",
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "olaffrenziedstrikes",
                ChampionName = "olaf",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "olafrecklessstrike",
                ChampionName = "olaf",
                Slot = SpellSlot.E,
                CastRange = 325f,
                Delay = 500f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "olafragnarok",
                ChampionName = "olaf",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "orianaizunacommand",
                ChampionName = "orianna",
                Slot = SpellSlot.Q,
                CastRange = 900f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "orianaizuna",
                FromObject = new[] { "yomu_ring" },
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "orianadissonancecommand",
                ChampionName = "orianna",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 350f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "orianadissonancecommand",
                FromObject = new[] { "yomu_ring" },
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "orianaredactcommand",
                ChampionName = "orianna",
                Slot = SpellSlot.E,
                CastRange = 1095f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "orianaredact",
                FromObject = new[] { "yomu_ring" },
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "orianadetonatecommand",
                ChampionName = "orianna",
                Slot = SpellSlot.R,
                CastRange = 425f,
                Delay = 500f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileName = "orianadetonatecommand",
                FromObject = new[] { "yomu_ring" },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "pantheonq",
                ChampionName = "pantheon",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1900
            });

            Spells.Add(new Skilldata
            {
                SDataName = "pantheonw",
                ChampionName = "pantheon",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "pantheone",
                ChampionName = "pantheon",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "pantheonrjump",
                ChampionName = "pantheon",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 1000f,
                HitType = new HitType[] { },
                MissileSpeed = 3000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "pantheonrfall",
                ChampionName = "pantheon",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 1000f,
                HitType = new HitType[] { },
                MissileSpeed = 3000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "poppydevastatingblow",
                ChampionName = "poppy",
                Slot = SpellSlot.Q,
                CastRange = 300f,
                Delay = 500f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "poppyparagonofdemacia",
                ChampionName = "poppy",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "poppyheroiccharge",
                ChampionName = "poppy",
                Slot = SpellSlot.E,
                CastRange = 525f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1450
            });

            Spells.Add(new Skilldata
            {
                SDataName = "poppydiplomaticimmunity",
                ChampionName = "poppy",
                Slot = SpellSlot.R,
                CastRange = 900f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl  },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "quinnq",
                ChampionName = "quinn",
                Slot = SpellSlot.Q,
                CastRange = 1025f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "quinnqmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "quinnw",
                ChampionName = "quinn",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "quinne",
                ChampionName = "quinn",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 775
            });

            Spells.Add(new Skilldata
            {
                SDataName = "quinnr",
                ChampionName = "quinn",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "quinnrfinale",
                ChampionName = "quinn",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "powerball",
                ChampionName = "rammus",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 775
            });

            Spells.Add(new Skilldata
            {
                SDataName = "defensiveballcurl",
                ChampionName = "rammus",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "puncturingtaunt",
                ChampionName = "rammus",
                Slot = SpellSlot.E,
                CastRange = 325f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "tremors2",
                ChampionName = "rammus",
                Slot = SpellSlot.R,
                CastRange = 300f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "renektoncleave",
                ChampionName = "renekton",
                Slot = SpellSlot.Q,
                CastRange = 225f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "renektonpreexecute",
                ChampionName = "renekton",
                Slot = SpellSlot.W,
                CastRange = 275f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "renektonsliceanddice",
                ChampionName = "renekton",
                Slot = SpellSlot.E,
                CastRange = 450f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new Skilldata
            {
                SDataName = "renektonreignofthetyrant",
                ChampionName = "renekton",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "rengarq",
                ChampionName = "rengar",
                Slot = SpellSlot.Q,
                CastRange = 275f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "rengarw",
                ChampionName = "rengar",
                Slot = SpellSlot.W,
                CastRange = 500f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "rengare",
                ChampionName = "rengar",
                Slot = SpellSlot.E,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "rengarefinal",
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "rengarr",
                ChampionName = "rengar",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "reksaiq",
                ChampionName = "reksai",
                Slot = SpellSlot.Q,
                CastRange = 275f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "reksaiqburrowed",
                ChampionName = "reksai",
                Slot = SpellSlot.W,
                CastRange = 1650f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "reksaiqburrowedmis",
                MissileSpeed = 1950
            });

            Spells.Add(new Skilldata
            {
                SDataName = "reksaiw",
                ChampionName = "reksai",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 350f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "reksaiwburrowed",
                ChampionName = "reksai",
                Slot = SpellSlot.W,
                CastRange = 200f,
                Delay = 500f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "reksaie",
                ChampionName = "reksai",
                Slot = SpellSlot.E,
                CastRange = 250f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "reksaieburrowed",
                ChampionName = "reksai",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 900f,
                HitType = new HitType[] { },
                MissileSpeed = 1450
            });

            Spells.Add(new Skilldata
            {
                SDataName = "reksair",
                ChampionName = "reksai",
                Slot = SpellSlot.R,
                CastRange = 2.147484E+09f,
                Delay = 1000f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "riventricleave",
                ChampionName = "riven",
                Slot = SpellSlot.Q,
                CastRange = 270f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "rivenmartyr",
                ChampionName = "riven",
                Slot = SpellSlot.W,
                CastRange = 260f,
                Delay = 0f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "rivenfeint",
                ChampionName = "riven",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 1450
            });

            Spells.Add(new Skilldata
            {
                SDataName = "rivenfengshuiengine",
                ChampionName = "riven",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "rivenizunablade",
                ChampionName = "riven",
                Slot = SpellSlot.R,
                CastRange = 1075f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileName = "rivenlightsabermissile",
                ExtraMissileNames = new[] { "rivenlightsabermissileside" },
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "rumbleflamethrower",
                ChampionName = "rumble",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "rumbleshield",
                ChampionName = "rumble",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "rumbegrenade",
                ChampionName = "rumble",
                Slot = SpellSlot.E,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "rumblecarpetbomb",
                ChampionName = "rumble",
                Slot = SpellSlot.R,
                CastRange = 1700f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ryzeq",
                ChampionName = "ryze",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ryzew",
                ChampionName = "ryze",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl , Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ryzee",
                ChampionName = "ryze",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ryzer",
                ChampionName = "ryze",
                Slot = SpellSlot.R,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new Skilldata
            {
                SDataName = "sejuaniarcticassault",
                ChampionName = "sejuani",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "",
                MissileSpeed = 1450
            });

            Spells.Add(new Skilldata
            {
                SDataName = "sejuaninorthernwinds",
                ChampionName = "sejuani",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 1000f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "sejuaniwintersclaw",
                ChampionName = "sejuani",
                Slot = SpellSlot.E,
                CastRange = 550f,
                Delay = 0f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1450
            });

            Spells.Add(new Skilldata
            {
                SDataName = "sejuaniglacialprisoncast",
                ChampionName = "sejuani",
                Slot = SpellSlot.R,
                CastRange = 1200f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileName = "sejuaniglacialprison",
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "deceive",
                ChampionName = "shaco",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "jackinthebox",
                ChampionName = "shaco",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1450
            });

            Spells.Add(new Skilldata
            {
                SDataName = "twoshivpoison",
                ChampionName = "shaco",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "hallucinatefull",
                ChampionName = "shaco",
                Slot = SpellSlot.R,
                CastRange = 1125f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 395
            });

            Spells.Add(new Skilldata
            {
                SDataName = "shenvorpalstar",
                ChampionName = "shen",
                Slot = SpellSlot.Q,
                CastRange = 475f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "shenfeint",
                ChampionName = "shen",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "shenshadowdash",
                ChampionName = "shen",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "shenshadowdash",
                MissileSpeed = 1250
            });

            Spells.Add(new Skilldata
            {
                SDataName = "shenstandunited",
                ChampionName = "shen",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "shyvanadoubleattack",
                ChampionName = "shyvana",
                Slot = SpellSlot.Q,
                CastRange = 275f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "shyvanadoubleattackdragon",
                ChampionName = "shyvana",
                Slot = SpellSlot.Q,
                CastRange = 325f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "shyvanaimmolationauraqw",
                ChampionName = "shyvana",
                Slot = SpellSlot.W,
                CastRange = 275f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "shyvanaimmolateddragon",
                ChampionName = "shyvana",
                Slot = SpellSlot.W,
                CastRange = 250f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "shyvanafireball",
                ChampionName = "shyvana",
                Slot = SpellSlot.E,
                CastRange = 925f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "shyvanafireballmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "shyvanafireballdragon2",
                ChampionName = "shyvana",
                Slot = SpellSlot.E,
                CastRange = 925f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "shyvanatransformcast",
                ChampionName = "shyvana",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                Delay = 100f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.CrowdControl,
                        Base.HitType.Ultimate
                    },
                MissileName = "shyvanatransformcast",
                MissileSpeed = 1100
            });

            Spells.Add(new Skilldata
            {
                SDataName = "poisentrail",
                ChampionName = "singed",
                Slot = SpellSlot.Q,
                CastRange = 250f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "megaadhesive",
                ChampionName = "singed",
                Slot = SpellSlot.W,
                CastRange = 1175f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 700
            });

            Spells.Add(new Skilldata
            {
                SDataName = "fling",
                ChampionName = "singed",
                Slot = SpellSlot.E,
                CastRange = 125f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "insanitypotion",
                ChampionName = "singed",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "sionq",
                ChampionName = "sion",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 2000f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "sionw",
                ChampionName = "sion",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "sione",
                ChampionName = "sion",
                Slot = SpellSlot.E,
                CastRange = 725f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "sionemissile",
                MissileSpeed = 1800
            });

            Spells.Add(new Skilldata
            {
                SDataName = "sionr",
                ChampionName = "sion",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "",
                MissileSpeed = 500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "sivirq",
                ChampionName = "sivir",
                Slot = SpellSlot.Q,
                CastRange = 1165f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "sivirqmissile",
                ExtraMissileNames = new []{ "sivirqmissilereturn" },
                MissileSpeed = 1350
            });

            Spells.Add(new Skilldata
            {
                SDataName = "sivirw",
                ChampionName = "sivir",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "sivire",
                ChampionName = "sivir",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "sivirr",
                ChampionName = "sivir",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "skarnervirulentslash",
                ChampionName = "skarner",
                Slot = SpellSlot.Q,
                CastRange = 350f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "skarnerexoskeleton",
                ChampionName = "skarner",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "skarnerfracture",
                ChampionName = "skarner",
                Slot = SpellSlot.E,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "skarnerfracturemissile",
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "skarnerimpale",
                ChampionName = "skarner",
                Slot = SpellSlot.R,
                CastRange = 350f,
                Delay = 350f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "sonaq",
                ChampionName = "sona",
                Slot = SpellSlot.Q,
                CastRange = 700f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "sonaw",
                ChampionName = "sona",
                Slot = SpellSlot.W,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "sonae",
                ChampionName = "sona",
                Slot = SpellSlot.E,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "sonar",
                ChampionName = "sona",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileName = "sonar",
                MissileSpeed = 2400
            });

            Spells.Add(new Skilldata
            {
                SDataName = "sorakaq",
                ChampionName = "soraka",
                Slot = SpellSlot.Q,
                CastRange = 970f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "",
                MissileSpeed = 1100
            });

            Spells.Add(new Skilldata
            {
                SDataName = "sorakaw",
                ChampionName = "soraka",
                Slot = SpellSlot.W,
                CastRange = 750f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "sorakae",
                ChampionName = "soraka",
                Slot = SpellSlot.E,
                CastRange = 925f,
                Delay = 1750f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "sorakar",
                ChampionName = "soraka",
                Slot = SpellSlot.R,
                CastRange = 25000f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "swaindecrepify",
                ChampionName = "swain",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "swainshadowgrasp",
                ChampionName = "swain",
                Slot = SpellSlot.W,
                CastRange = 1040f,
                Delay = 1100f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "swainshadowgrasp",
                MissileSpeed = int.MaxValue 
            });

            Spells.Add(new Skilldata
            {
                SDataName = "swaintorment",
                ChampionName = "swain",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new Skilldata
            {
                SDataName = "swainmetamorphism",
                ChampionName = "swain",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 950
            });

            Spells.Add(new Skilldata
            {
                SDataName = "syndraq",
                ChampionName = "syndra",
                Slot = SpellSlot.Q,
                CastRange = 800f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "syndraq",
                MissileSpeed = 1750
            });

            Spells.Add(new Skilldata
            {
                SDataName = "syndrawcast",
                ChampionName = "syndra",
                Slot = SpellSlot.W,
                CastRange = 950f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "syndrawcast",
                MissileSpeed = 1450
            });

            Spells.Add(new Skilldata
            {
                SDataName = "syndrae",
                ChampionName = "syndra",
                Slot = SpellSlot.E,
                CastRange = 950f,
                Delay = 300f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "syndrae",
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "syndrar",
                ChampionName = "syndra",
                Slot = SpellSlot.R,
                CastRange = 675f,
                Delay = 450f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileSpeed = 1250
            });

            Spells.Add(new Skilldata
            {
                SDataName = "tahmkenchq",
                ChampionName = "tahmkench",
                Slot = SpellSlot.Q,
                CastRange = 950f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 2800
            });

            Spells.Add(new Skilldata
            {
                SDataName = "talonnoxiandiplomacy",
                ChampionName = "talon",
                Slot = SpellSlot.Q,
                CastRange = 275f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "talonrake",
                ChampionName = "talon",
                Slot = SpellSlot.W,
                CastRange = 750f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "talonrakemissileone",
                MissileSpeed = 2300
            });

            Spells.Add(new Skilldata
            {
                SDataName = "taloncutthroat",
                ChampionName = "talon",
                Slot = SpellSlot.E,
                CastRange = 750f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "talonshadowassault",
                ChampionName = "talon",
                Slot = SpellSlot.R,
                CastRange = 750f,
                Delay = 260f,
                HitType = new[] { Base.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "imbue",
                ChampionName = "taric",
                Slot = SpellSlot.Q,
                CastRange = 750f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "shatter",
                ChampionName = "taric",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "dazzle",
                ChampionName = "taric",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1400
            });

            Spells.Add(new Skilldata
            {
                SDataName = "tarichammersmash",
                ChampionName = "taric",
                Slot = SpellSlot.R,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "blindingdart",
                ChampionName = "teemo",
                Slot = SpellSlot.Q,
                CastRange = 580f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "movequick",
                ChampionName = "teemo",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 943
            });

            Spells.Add(new Skilldata
            {
                SDataName = "toxicshot",
                ChampionName = "teemo",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "bantamtrap",
                ChampionName = "teemo",
                Slot = SpellSlot.R,
                CastRange = 230f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "threshq",
                ChampionName = "thresh",
                Slot = SpellSlot.Q,
                CastRange = 1175f,
                Delay = 500f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger  },
                MissileName = "threshqmissile",
                MissileSpeed = 1900
            });

            Spells.Add(new Skilldata
            {
                SDataName = "threshw",
                ChampionName = "thresh",
                Slot = SpellSlot.W,
                CastRange = 950f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "threshe",
                ChampionName = "thresh",
                Slot = SpellSlot.E,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "threshemissile1",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "threshrpenta",
                ChampionName = "thresh",
                Slot = SpellSlot.R,
                CastRange = 420f,
                Delay = 300f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "tristanaq",
                ChampionName = "tristana",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "tristanaw",
                ChampionName = "tristana",
                Slot = SpellSlot.W,
                CastRange = 900f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1150
            });

            Spells.Add(new Skilldata
            {
                SDataName = "tristanae",
                ChampionName = "tristana",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new Skilldata
            {
                SDataName = "tristanar",
                ChampionName = "tristana",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "trundletrollsmash",
                ChampionName = "trundle",
                Slot = SpellSlot.Q,
                CastRange = 275f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "trundledesecrate",
                ChampionName = "trundle",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "trundlecircle",
                ChampionName = "trundle",
                Slot = SpellSlot.E,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "trundlepain",
                ChampionName = "trundle",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 500f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "bloodlust",
                ChampionName = "tryndamere",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "mockingshout",
                ChampionName = "tryndamere",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "slashcast",
                ChampionName = "tryndamere",
                Slot = SpellSlot.E,
                CastRange = 660f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "slashcast",
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "undyingrage",
                ChampionName = "tryndamere",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "hideinshadows",
                ChampionName = "twich",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 450f,
                HitType = new[] { Base.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "twitchvenomcask",
                ChampionName = "twich",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "twitchvenomcaskmissile",
                MissileSpeed = 1750
            });

            Spells.Add(new Skilldata
            {
                SDataName = "twitchvenomcaskmissle",
                ChampionName = "twich",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1750
            });

            Spells.Add(new Skilldata
            {
                SDataName = "expunge",
                ChampionName = "twich",
                Slot = SpellSlot.E,
                CastRange = 1200f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "fullautomatic",
                ChampionName = "twich",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "wildcards",
                ChampionName = "twistedfate",
                Slot = SpellSlot.Q,
                CastRange = 1450f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "sealfatemissile",
                MissileSpeed = 1450
            });

            Spells.Add(new Skilldata
            {
                SDataName = "pickacard",
                ChampionName = "twistedfate",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "goldcardpreattack",
                ChampionName = "twistedfate",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "redcardpreattack",
                ChampionName = "twistedfate",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "bluecardpreattack",
                ChampionName = "twistedfate",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "cardmasterstack",
                ChampionName = "twistedfate",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "destiny",
                ChampionName = "twistedfate",
                Slot = SpellSlot.R,
                CastRange = 5250f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "udyrtigerstance",
                ChampionName = "udyr",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "udyrturtlestance",
                ChampionName = "udyr",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "udyrbearstanceattack",
                ChampionName = "udyr",
                Slot = SpellSlot.E,
                CastRange = 250f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "udyrphoenixstance",
                ChampionName = "udyr",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "urgotheatseekinglineqqmissile",
                ChampionName = "urgot",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new [] { Base.HitType.Danger  },
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "urgotheatseekingmissile",
                ChampionName = "urgot",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "urgotterrorcapacitoractive2",
                ChampionName = "urgot",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "urgotplasmagrenade",
                ChampionName = "urgot",
                Slot = SpellSlot.E,
                CastRange = 950f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "urgotplasmagrenadeboom",
                MissileSpeed = 1750
            });

            Spells.Add(new Skilldata
            {
                SDataName = "urgotplasmagrenadeboom",
                ChampionName = "urgot",
                Slot = SpellSlot.E,
                CastRange = 950f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1750
            });

            Spells.Add(new Skilldata
            {
                SDataName = "urgotswap2",
                ChampionName = "urgot",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] {  Base.HitType.CrowdControl },
                MissileSpeed = 1800
            });

            Spells.Add(new Skilldata
            {
                SDataName = "varusq",
                ChampionName = "varus",
                Slot = SpellSlot.Q,
                CastRange = 1250f,
                Delay = 0f,
                HitType = new[] { Base.HitType.Danger },
                MissileName = "varusqmissile",
                MissileSpeed = 1900
            });

            Spells.Add(new Skilldata
            {
                SDataName = "varusw",
                ChampionName = "varus",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "varuse",
                ChampionName = "varus",
                Slot = SpellSlot.E,
                CastRange = 925f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "varuse",
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "varusr",
                ChampionName = "varus",
                Slot = SpellSlot.R,
                CastRange = 1300f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileName = "varusrmissile",
                MissileSpeed = 1950
            });

            Spells.Add(new Skilldata
            {
                SDataName = "vaynetumble",
                ChampionName = "vayne",
                Slot = SpellSlot.Q,
                CastRange = 850f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "vaynesilverbolts",
                ChampionName = "vayne",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "vaynecondemnmissile",
                ChampionName = "vayne",
                Slot = SpellSlot.E,
                CastRange = 450f,
                Delay = 500f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger  },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "vayneinquisition",
                ChampionName = "vayne",
                Slot = SpellSlot.R,
                CastRange = 1200f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "veigarbalefulstrike",
                ChampionName = "veigar",
                Slot = SpellSlot.Q,
                CastRange = 950f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileName = "veigarbalefulstrikemis",
                MissileSpeed = 1750
            });

            Spells.Add(new Skilldata
            {
                SDataName = "veigardarkmatter",
                ChampionName = "veigar",
                Slot = SpellSlot.W,
                CastRange = 900f,
                Delay = 1200f,
                HitType = new HitType[] { },
                MissileName = "",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "veigareventhorizon",
                ChampionName = "veigar",
                Slot = SpellSlot.E,
                CastRange = 650f,
                Delay = 0f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "",
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "veigarprimordialburst",
                ChampionName = "veigar",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileSpeed = 1400
            });

            Spells.Add(new Skilldata
            {
                SDataName = "velkozq",
                ChampionName = "velkoz",
                Slot = SpellSlot.Q,
                CastRange = 1050f,
                Delay = 300f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "velkozqmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "velkozqmissle",
                ChampionName = "velkoz",
                Slot = SpellSlot.Q,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "velkozqplitactive",
                ChampionName = "velkoz",
                Slot = SpellSlot.Q,
                CastRange = 1050f,
                Delay = 0f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "velkozw",
                ChampionName = "velkoz",
                Slot = SpellSlot.W,
                CastRange = 1050f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileName = "velkozwmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "velkoze",
                ChampionName = "velkoz",
                Slot = SpellSlot.E,
                CastRange = 850f,
                Delay = 0f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "velkozemissile",
                MissileSpeed = 1700
            });

            Spells.Add(new Skilldata
            {
                SDataName = "velkozr",
                ChampionName = "velkoz",
                Slot = SpellSlot.R,
                CastRange = 1575f,
                Delay = 0f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "viq",
                ChampionName = "vi",
                Slot = SpellSlot.Q,
                CastRange = 800f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "viw",
                ChampionName = "vi",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "vie",
                ChampionName = "vi",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 0f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "vir",
                ChampionName = "vi",
                Slot = SpellSlot.R,
                CastRange = 800f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = 1400
            });

            Spells.Add(new Skilldata
            {
                SDataName = "viktorpowertransfer",
                ChampionName = "viktor",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new Skilldata
            {
                SDataName = "viktorgravitonfield",
                ChampionName = "viktor",
                Slot = SpellSlot.W,
                CastRange = 815f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1750
            });

            Spells.Add(new Skilldata
            {
                SDataName = "viktordeathray",
                ChampionName = "viktor",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileName = "viktordeathraymis",
                MissileSpeed = 1210
            });

            Spells.Add(new Skilldata
            {
                SDataName = "viktorchaosstorm",
                ChampionName = "viktor",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 350f,
                HitType =
                    new[]
                    {
                        Base.HitType.CrowdControl, Base.HitType.Ultimate,
                        Base.HitType.Danger
                    },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "vladimirtransfusion",
                ChampionName = "vladimir",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = 1400
            });

            Spells.Add(new Skilldata
            {
                SDataName = "vladimirsanguinepool",
                ChampionName = "vladimir",
                Slot = SpellSlot.W,
                CastRange = 350f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "vladimirtidesofblood",
                ChampionName = "vladimir",
                Slot = SpellSlot.E,
                CastRange = 610f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1100
            });

            Spells.Add(new Skilldata
            {
                SDataName = "vladimirhemoplague",
                ChampionName = "vladimir",
                Slot = SpellSlot.R,
                CastRange = 875f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "volibearq",
                ChampionName = "volibear",
                Slot = SpellSlot.Q,
                CastRange = 300f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "volibearw",
                ChampionName = "volibear",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = 1450
            });

            Spells.Add(new Skilldata
            {
                SDataName = "volibeare",
                ChampionName = "volibear",
                Slot = SpellSlot.E,
                CastRange = 425f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 825
            });

            Spells.Add(new Skilldata
            {
                SDataName = "volibearr",
                ChampionName = "volibear",
                Slot = SpellSlot.R,
                CastRange = 425f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 825
            });

            Spells.Add(new Skilldata
            {
                SDataName = "hungeringstrike",
                ChampionName = "warwick",
                Slot = SpellSlot.Q,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "hunterscall",
                ChampionName = "warwick",
                Slot = SpellSlot.W,
                CastRange = 1000f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "bloodscent",
                ChampionName = "warwick",
                Slot = SpellSlot.E,
                CastRange = 1250f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "infiniteduress",
                ChampionName = "warwick",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });
            
            Spells.Add(new Skilldata
            {
                SDataName = "xeratharcanopulsechargeup",
                ChampionName = "xerath",
                Slot = SpellSlot.Q,
                CastRange = 750f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = 500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "xeratharcanebarrage2",
                ChampionName = "xerath",
                Slot = SpellSlot.W,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "xeratharcanebarrage2",
                MissileSpeed = 20
            });

            Spells.Add(new Skilldata
            {
                SDataName = "xerathmagespear",
                ChampionName = "xerath",
                Slot = SpellSlot.E,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileName = "xerathmagespearmissile",
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "xerathlocusofpower2",
                ChampionName = "xerath",
                Slot = SpellSlot.R,
                CastRange = 5600f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = 500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "xenzhaothrust3",
                ChampionName = "xinzhao",
                Slot = SpellSlot.Q,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "xenzhaobattlecry",
                ChampionName = "xinzhao",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 2000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "xenzhaosweep",
                ChampionName = "xinzhao",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileSpeed = 1750
            });

            Spells.Add(new Skilldata
            {
                SDataName = "xenzhaoparry",
                ChampionName = "xinzhao",
                Slot = SpellSlot.R,
                CastRange = 375f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileSpeed = 1750
            });

            Spells.Add(new Skilldata
            {
                SDataName = "yasuoqw",
                ChampionName = "yasuo",
                Slot = SpellSlot.Q,
                CastRange = 475f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "yasuoq2w",
                ChampionName = "yasuo",
                Slot = SpellSlot.Q,
                CastRange = 475f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "yasuoq3",
                ChampionName = "yasuo",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "yasuoq3mis",
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "yasuowmovingwall",
                ChampionName = "yasuo",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "yasuodashwrapper",
                ChampionName = "yasuo",
                Slot = SpellSlot.E,
                CastRange = 475f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 20
            });

            Spells.Add(new Skilldata
            {
                SDataName = "yasuorknockupcombow",
                ChampionName = "yasuo",
                Slot = SpellSlot.R,
                CastRange = 1200f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "yorickspectral",
                ChampionName = "yorick",
                Slot = SpellSlot.Q,
                CastRange = 350f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "yorickdecayed",
                ChampionName = "yorick",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "yorickravenous",
                ChampionName = "yorick",
                Slot = SpellSlot.E,
                CastRange = 550f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "yorickreviveally",
                ChampionName = "yorick",
                Slot = SpellSlot.R,
                CastRange = 900f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "zacq",
                ChampionName = "zac",
                Slot = SpellSlot.Q,
                CastRange = 550f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "zacq",
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "zacw",
                ChampionName = "zac",
                Slot = SpellSlot.W,
                CastRange = 350f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "zace",
                ChampionName = "zac",
                Slot = SpellSlot.E,
                CastRange = 1550f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1500
            });

            Spells.Add(new Skilldata
            {
                SDataName = "zacr",
                ChampionName = "zac",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "zedq",
                ChampionName = "zed",
                Slot = SpellSlot.Q,
                CastRange = 900f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "zedshurikenmisone",
                FromObject = new[] { "Zed_Base_W_tar.troy", "Zed_Base_W_cloneswap_buf.troy" },
                ExtraMissileNames = new[] { "zedshurikenmistwo", "zedshurikenmisthree" },
                MissileSpeed = 1700
            });

            Spells.Add(new Skilldata
            {
                SDataName = "zedw",
                ChampionName = "zed",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new Skilldata
            {
                SDataName = "zede",
                ChampionName = "zed",
                Slot = SpellSlot.E,
                CastRange = 300f,
                Delay = 0f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "zedr",
                ChampionName = "zed",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ziggsq",
                ChampionName = "ziggs",
                Slot = SpellSlot.Q,
                CastRange = 850f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "ziggsqspell",
                ExtraMissileNames = new[] { "ziggsqspell2", "ziggsqspell3" },
                MissileSpeed = 1750
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ziggsw",
                ChampionName = "ziggs",
                Slot = SpellSlot.W,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "ziggsw",
                MissileSpeed = 1750
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ziggswtoggle",
                ChampionName = "ziggs",
                Slot = SpellSlot.W,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1750
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ziggse",
                ChampionName = "ziggs",
                Slot = SpellSlot.E,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "ziggse",
                MissileSpeed = 1750
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ziggse2",
                ChampionName = "ziggs",
                Slot = SpellSlot.E,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1750
            });

            Spells.Add(new Skilldata
            {
                SDataName = "ziggsr",
                ChampionName = "ziggs",
                Slot = SpellSlot.R,
                CastRange = 2250f,
                Delay = 1800f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileName = "ziggsr",
                MissileSpeed = 1750
            });

            Spells.Add(new Skilldata
            {
                SDataName = "zileanq",
                ChampionName = "zilean",
                Slot = SpellSlot.Q,
                CastRange = 900f,
                Delay = 300f,
                HitType = new HitType[] { },
                MissileName = "zileanqmissile",
                MissileSpeed = 2000
            });

            Spells.Add(new Skilldata
            {
                SDataName = "zileanw",
                ChampionName = "zilean",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "zileane",
                ChampionName = "zilean",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1100
            });

            Spells.Add(new Skilldata
            {
                SDataName = "zileanr",
                ChampionName = "zilean",
                Slot = SpellSlot.R,
                CastRange = 780f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Skilldata
            {
                SDataName = "zyraqfissure",
                ChampionName = "zyra",
                Slot = SpellSlot.Q,
                CastRange = 800f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "zyraqfissure",
                MissileSpeed = 1400
            });

            Spells.Add(new Skilldata
            {
                SDataName = "zyraseed",
                ChampionName = "zyra",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new Skilldata
            {
                SDataName = "zyragraspingroots",
                ChampionName = "zyra",
                Slot = SpellSlot.E,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "zyragraspingroots",
                MissileSpeed = 1400
            });

            Spells.Add(new Skilldata
            {
                SDataName = "zyrabramblezone",
                ChampionName = "zyra",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 500f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });
        }

        public static List<Skilldata> Spells = new List<Skilldata>();
        public static List<Skilldata> SomeSpells = new List<Skilldata>();

        public static Dictionary<SpellDamageDelegate, SpellSlot> DamageLib = 
            new Dictionary<SpellDamageDelegate, SpellSlot>();

        public static Skilldata GetByMissileName(string missilename)
        {
            foreach (var sdata in Spells)
            {
                if (sdata.MissileName != null && sdata.MissileName.ToLower() == missilename ||
                    sdata.ExtraMissileNames != null && sdata.ExtraMissileNames.Contains(missilename))
                {
                    return sdata;
                }
            }

            return null;
        }
    }
}
