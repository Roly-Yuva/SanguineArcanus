using SanguineArcanus.Content.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SanguineArcanus.Content.Items.Weapons.Magic
{
    public class GrassStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Grass Staff");
            Tooltip.SetDefault("Fires grass projectiles at enemies.");
        }

        public override void SetDefaults()
        {
            Item.damage = 7;
            Item.DamageType = DamageClass.Magic;
            Item.width = 20;
            Item.height = 20;
            Item.useTime = 25; // average-fast
            Item.useAnimation = 25;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 5; // average
            Item.value = 250; // 2 silver 50 copper
            Item.rare = ItemRarityID.White;
            Item.UseSound = SoundID.Item45;
            Item.shoot = ModContent.ProjectileType<GrassBolt>();
            Item.shootSpeed = 2;
            Item.mana = 4;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 25);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}