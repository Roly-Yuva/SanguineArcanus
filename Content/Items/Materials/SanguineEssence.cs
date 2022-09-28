using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SanguineArcanus.Content.Items.Materials
{
    public class SanguineEssence : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sanguine Essence");
            Tooltip.SetDefault("The essence of creatures tied to the Element of Blood.");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.maxStack = 999;
            Item.value = 250; // 2 silver 50 copper
            Item.rare = ItemRarityID.Green;
        }
    }
}