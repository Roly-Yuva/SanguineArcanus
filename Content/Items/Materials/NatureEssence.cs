using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SanguineArcanus.Content.Items.Materials
{
    public class NatureEssence : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nature Essence");
            Tooltip.SetDefault("The essence of creatures tied to the Element of Nature.");
        }

        public override void SetDefaults()
        {
            Item.width = 34;
            Item.height = 36;
            Item.maxStack = 999;
            Item.value = 250; // 2 silver 50 copper
            Item.rare = ItemRarityID.Green;
        }
    }
}
