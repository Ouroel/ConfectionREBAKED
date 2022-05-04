using Terraria.ID;
using Terraria.ModLoader;

namespace TheConfectionRebirth.Items.Placeable
{
	public class SaccharitePiano : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Saccharite Piano");
		}

		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 22;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 0;
			item.createTile = mod.TileType("SaccharitePiano");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SacchariteBrick", 15);
			recipe.AddIngredient(154, 4);
			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddTile(TileID.Sawmill);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
