using Terraria;
using Terraria.ModLoader;

namespace TheConfectionRebirth.Buffs
{
	public class RollerCookiePet : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Rollercookie Pet");
			Description.SetDefault("\"A little Rollercookie is following you!\"");
			Main.buffNoTimeDisplay[Type] = true;
			Main.vanityPet[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			player.buffTime[buffIndex] = 18000;
			player.GetModPlayer<ConfectionPlayer>().RollerCookiePet = true;
			bool petProjectileNotSpawned = player.ownedProjectileCounts[ModContent.ProjectileType<Projectiles.Pets.RollerCookiePet>()] <= 0;
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer) {
				Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, ModContent.ProjectileType<Projectiles.Pets.RollerCookiePet>(), 0, 0f, player.whoAmI, 0f, 0f);
			}
		}
	}
}