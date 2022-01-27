using TheConfectionRebirth.Items.Placeable;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TheConfectionRebirth.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class NeapoliniteHat : ModItem
	{
		public override void SetStaticDefaults() {
		Tooltip.SetDefault("8% Increased Summoner Damage"
				+ "\nIncreased Max number of minions");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 250000;
			item.rare = ItemRarityID.Pink;
			item.defense = 2;
		}
		
		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ModContent.ItemType<NeapoliniteConeMail>() && legs.type == ModContent.ItemType<NeapoliniteGreaves>();
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "14% Increased Summon Damage and 2% Increased Critical Stike Chance";
			player.minionDamage += 0.14f;
			player.meleeCrit += 2;
			player.magicCrit += 2;
			player.rangedCrit += 2;
			player.thrownCrit += 2;
		}
		
		public override void UpdateEquip(Player player) {
			player.minionDamage += 0.08f;
			player.maxMinions++;
			player.maxMinions++;
			player.maxMinions++;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Placeable.NeapoliniteBar>(), 12);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}