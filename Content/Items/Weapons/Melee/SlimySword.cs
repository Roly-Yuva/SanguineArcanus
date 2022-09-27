using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SanguineArcanus.Content.Items.Weapons.Melee
{
	public class SlimySword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slimy Sword");
			Tooltip.SetDefault("Comprised from the remains of slimy creatures.");
		}

		public override void SetDefaults()
		{
			Item.damage = 23;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 30; // average
			Item.useAnimation = 30;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 4; // weak
			Item.value = 500; // 50 silver
			Item.rare = ItemRarityID.Green;
			Item.UseSound = SoundID.Item1;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Gel, 45);
			recipe.AddTile(TileID.Solidifier);
			recipe.Register();
		}
	}
}