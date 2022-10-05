/*using SanguineArcanus.Content.Items.Materials;
using SanguineArcanus.Content.Tiles.CraftingStations;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SanguineArcanus.Content.Item.Placeables
{
    public class ElementalInfuser : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Elemental Infuser");
            Tooltip.SetDefault("A special furnace that can be used to infuse essence into special stones.");
        }

        public override void SetDefaults()
        {
            Item.width = 15;
            Item.height = 15;
            Item.value = 10000; // 1 gold
            Item.rare = ItemRarityID.Blue;
            Item.createTile = ModContent.TileType<Tiles.CraftingStations.ElementalInfuser>();
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Furnace);
            recipe.AddIngredient(ModContent.ItemType<ArcaneSigil>(), 15);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}*/