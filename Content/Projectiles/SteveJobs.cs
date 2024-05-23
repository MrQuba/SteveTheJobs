using SteveTheJobs.Content.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SteveTheJobs.Content.Projectiles
{
	public class SteveJobs : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			Main.projPet[Projectile.type] = true;
		}
		public override void SetDefaults()
		{
			Projectile.CloneDefaults(ProjectileID.BabySkeletronHead);
			Projectile.width = 83;
			Projectile.height = 76;
			AIType = ProjectileID.BabySkeletronHead;
		}
		public override bool PreAI()
		{
			Player player = Main.player[Projectile.owner];

			return true;
		}
		public override void AI()
		{
			Player player = Main.player[Projectile.owner];

			if (!player.dead && player.HasBuff(ModContent.BuffType<SteveJobsBuff>()))
			{
				Projectile.timeLeft = 2;
			}
		}
	}
}
