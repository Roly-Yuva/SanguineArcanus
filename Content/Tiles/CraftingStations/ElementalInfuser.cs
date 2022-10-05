/*using Microsoft.Xna.Framework;
using SanguineArcanus.Content.Items;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace SanguineArcanus.Content.Tiles.CraftingStations
{
    public class ElementalInfuser : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileSolid[Type] = false;
            Main.tileMergeDirt[Type] = true;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Elemental Infuser");
            AddMapEntry(new Color(236, 211, 85));
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {
            Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 16, ModContent.ItemType<Items.Placeables.ElementalInfuser>());
        }
    }
}*/