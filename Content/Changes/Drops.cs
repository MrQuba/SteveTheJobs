using SteveTheJobs.Content.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace SteveTheJobs.Content.Changes
{
	public class TreasureBags : GlobalItem
	{
		public override void ModifyItemLoot(Item item, ItemLoot itemLoot)
		{
			// checks if calamity mod is installed
			if (ModLoader.TryGetMod("CalamityMod", out Mod calamityMod) && calamityMod.TryFind("DevourerofGodsBag", out ModItem DoGBag))
			{
				// if item is Devour of Gods Treasure Bag
				if (item.type == DoGBag.Type)
				{
					// gets BitApple item
					if (ModLoader.TryGetMod("SteveTheJobs", out Mod steve) && steve.TryFind<ModItem>("BitApple", out ModItem apple))
					{
						// and adds it to the bag loot, 100% chance
						itemLoot.Add(ItemDropRule.Common(apple.Type, 1));
					}
				}
			}
		}
	}
}
