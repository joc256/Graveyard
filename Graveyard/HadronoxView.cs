using Hearthstone_Deck_Tracker.API;
using System.Linq;
using static HearthDb.CardIds.Collectible;

namespace HDT.Plugins.Graveyard
{
    public class HadronoxView
	{
		private static ViewConfig _Config;
		internal static ViewConfig Config
		{
			get => _Config ?? (_Config = new ViewConfig(Druid.Hadronox)
            {
				Name = Strings.GetLocalized("Hadronox"),
				Enabled = () => Settings.Default.HadronoxEnabled,
				CreateView = () => new NormalView(),
				WatchFor = GameEvents.OnPlayerPlayToGraveyard,
				Condition = card => card.Mechanics.Contains("Taunt"),
			});
		}
	
	}
}
