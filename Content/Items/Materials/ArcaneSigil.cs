using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SanguineArcanus.Content.Items.Materials
{
    public class ArcaneSigil : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arcane Sigil");
            Tooltip.SetDefault("A special stone used for elemental crafting.");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 999;
            Item.value = 100; // 1 silver
            Item.rare = ItemRarityID.Green;
        }
    }
}