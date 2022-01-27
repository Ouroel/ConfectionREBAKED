using Terraria.ID;
using Terraria.ModLoader;

namespace TheConfectionRebirth.Items.Placeable
{
	public class CreamwoodLantern : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Creamwood Lantern");
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
			item.createTile = mod.TileType("CreamwoodLantern");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CreamWood", 6);
			recipe.AddIngredient(ItemID.Torch, 1);
			recipe.AddTile(18);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
