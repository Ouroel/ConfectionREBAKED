using Terraria.ID;
using Terraria.ModLoader;

namespace TheConfectionRebirth.Items.Placeable
{
	public class CreamwoodCandelabra : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Creamwood Candelabra");
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
			item.createTile = mod.TileType("CreamwoodCandel");
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Placeable.CreamWood>(), 5);
			recipe.AddIngredient(ItemID.Torch, 3);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
