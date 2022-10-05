using SanguineArcanus.Content.Items.Materials;
//using SanguineArcanus.Content.Tiles.CraftingStations;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SanguineArcanus.Content.Items.Accessories
{
    public class SanguineRune : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sanguine Rune");
            Tooltip.SetDefault("A rune infused with the Element of Blood.\nMelee Accessory");
        }

        public override void SetDefaults()
        {
            Item.width = 19;
            Item.height = 18;
            Item.value = 1500; // 15 silver
            Item.rare = ItemRarityID.Green;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statDefense += 3;
            player.lifeRegen += 3;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<Content.Items.Materials.ArcaneSigil>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Content.Items.Materials.SanguineEssence>(), 5);
            recipe.AddTile(TileID.WorkBenches);//recipe.AddTile(ModContent.TileType<Tiles.CraftingStations.ElementalInfuser>());
            recipe.Register();
        }
    }
}