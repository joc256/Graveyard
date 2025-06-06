﻿using Hearthstone_Deck_Tracker.API;
using Hearthstone_Deck_Tracker.Hearthstone;
using System.Collections.Generic;
using static HearthDb.CardIds.Collectible;

namespace HDT.Plugins.Graveyard
{
    public class LadyLiadrinView
    {
        private static ViewConfig _Config;
        internal static ViewConfig Config
        {
            get => _Config ?? (_Config = new ViewConfig(Paladin.LadyLiadrin)
            {
                Name = "LadyLiadrin",
                Enabled = "LadyLiadrinEnabled",
                CreateView = () => new NormalView(),
                UpdateOn = GameEvents.OnPlayerPlay,
                Condition = card => card.Type == "Spell" && SpellList.Contains(card.Id),
            });
        }
        
        public static readonly List<string> SpellList = new List<string>
        {
            // 0
            Paladin.ForbiddenHealing,
            // 1
            Paladin.Adaptation,
            Paladin.BlessingOfMightLegacy,
            Paladin.BlessingOfWisdom,
            Paladin.DivineStrength,
            Paladin.HandOfProtectionLegacy,
            Paladin.HolyMakiRoll,
            //Paladin.Humility
            Paladin.SandBreath,
            Paladin.ShieldOfHonor,
            // 2
            Paladin.DarkConviction,
            Paladin.DesperateStand,
            Paladin.ForQuelthalas,
            Paladin.FlashOfLight,
            Paladin.HandOfAdalCore,
            Paladin.LibramOfWisdom,
            Paladin.LightforgedBlessing,
            Paladin.NobleMount,
            Paladin.PotionOfHeroism,
            Paladin.RingOfCourage,
            Paladin.SoundTheBells,
            //Paladin.Subdue
            // 3
            Paladin.GiftOfLuminance,
            Paladin.HoldTheBridge,
            //Paladin.RighteousDefense,
            Paladin.SealOfBlood,
            Paladin.SealOfChampions,
            // 4
            Paladin.BlessingOfKingsLegacy,
            //Paladin.HammerOfWrath,
            Paladin.SilvermoonPortalKARA,
            // 5
            Paladin.BlessedChampion,
            Paladin.BlessingOfAuthority,
            //Paladin.HolyWrath,
            // 6
            //?Paladin.Righteousness, all minions
            //?Paladin.ShrinkRay, all minions
            //?Paladin.LevelUp, all minions
            Paladin.PharaohsBlessing,
            Paladin.SpikeridgedSteed,
            // 8
            Paladin.Dinosize,
            Paladin.LayOnHandsExpert1,
            // 9
            Paladin.LibramOfHope,
            // 10
            Paladin.TheGardensGrace,
        };
    }
}
