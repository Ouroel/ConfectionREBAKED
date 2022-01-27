using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheConfectionRebirth.Tiles
{
	public class Creamsandstone : ModTile
	{
		public override void SetDefaults() {
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileMerge[Type][mod.TileType("CreamstoneBrick")] = true;
			Main.tileMerge[Type][mod.TileType("CreamWood")] = true;
			Main.tileMerge[Type][mod.TileType("HardenedCreamsand")] = true;
			Main.tileMerge[Type][mod.TileType("Creamsand")] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = false;
			drop = ModContent.ItemType<Items.Placeable.Creamsandstone>();
			AddMapEntry(new Color(89, 47, 36));
			TileID.Sets.Conversion.HardenedSand[Type] = true;
		    TileID.Sets.ForAdvancedCollision.ForSandshark[Type] = true;
			
			soundType = SoundID.Tink;
		}

		public override void NumDust(int i, int j, bool fail, ref int num) {
			num = fail ? 1 : 3;
		}
		
		public override void RandomUpdate(int i, int j)
        {
          ConfectionWorld.InfectionSpread(i, j, "Confection");
        }
	}
}