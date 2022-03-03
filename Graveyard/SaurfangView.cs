﻿using Hearthstone_Deck_Tracker.API;
using static HearthDb.CardIds.Collectible;

namespace HDT.Plugins.Graveyard
{
    public class SaurfangView
	{
		private static ViewConfig _Config;
		internal static ViewConfig Config
		{
			get => _Config ?? (_Config = new ViewConfig(Warrior.OverlordSaurfang)
            {
				Name = Strings.GetLocalized("Saurfang"),
				Enabled = () => Settings.Default.SaurfangEnabled,
				CreateView = () => new ChancesView(),
				WatchFor = GameEvents.OnPlayerPlayToGraveyard,
				Condition = card => card.EnglishText?.Contains("Frenzy:") ?? false
			});
		}
	}
}
