using TheConfectionRebirth.Dusts;
using TheConfectionRebirth.Items.Placeable;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace TheConfectionRebirth.Tiles
{
    public class YumBlock : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileMerge[Type][mod.TileType("CreamGrass")] = true;
            Main.tileMerge[Type][mod.TileType("Creamstone")] = true;
            Main.tileMerge[Type][mod.TileType("CreamWood")] = true;
			Main.tileMerge[Type][mod.TileType("CookieBlock")] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = false;
            drop = ModContent.ItemType<Items.Placeable.YumBlock>();
            AddMapEntry(new Color(110, 234, 184));
			dustType = mod.DustType("YumDust");
        }
    }
}