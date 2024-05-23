using SteveTheJobs.Content.Buffs;
using SteveTheJobs.Content.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SteveTheJobs.Content.Items
{ 
	public class BitApple : ModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.BoneKey);	
			Item.value = Item.sellPrice(gold: 50);
			Item.buffType = ModContent.BuffType<SteveJobsBuff>();
			Item.shoot = ModContent.ProjectileType<SteveJobs>();
		}
		public override bool? UseItem(Player player)
		{
			if (player.whoAmI == Main.myPlayer)
			{
				player.AddBuff(Item.buffType, 3600);
			}
			return true;
		}
	}
}
