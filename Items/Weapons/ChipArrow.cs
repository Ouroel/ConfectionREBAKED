using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheConfectionRebirth.Items.Weapons
{
	public class ChipArrow : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Cunks of Chocolate bounce around after impact.");
		}

		public override void SetDefaults() {
			item.damage = 10;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true; 
			item.knockBack = 1.5f;
			item.value = 80;
			item.rare = ItemRarityID.Orange;
			item.shoot = ModContent.ProjectileType<Projectiles.ChipArrow>();
			item.shootSpeed = 7f;
			item.ammo = AmmoID.Arrow;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(40, 25);
			recipe.AddIngredient(ModContent.ItemType<CookieDough>(), 2);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
		}
	}
}
