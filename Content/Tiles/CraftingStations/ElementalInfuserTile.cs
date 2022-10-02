using Microsoft.Xna.Framework;
using SanguineArcanus.Content.Items.Placeables;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace SanguineArcanus.Content.Tiles.CraftingStations
{
    public class ElementalInfuserTile : ModTile
    {
        public override void SetDefults()
        {
            Main.tileSolid[Type] = false;
            Main.tileMergeDirt[Type] = true;
            drop = ModContent.ItemType<ElementalInfuserItem>();
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Elemental Infuser");
            AddMapEntry(new Color(236, 211, 85));
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 16, ModContent.ItemType<ElementalInfuserItem>());
        }
    }
}