using Terraria;
using Terraria.ModLoader;

namespace SanguineArcanus.Content.Buffs
{
    public class Slimed : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Slimed");
            Description.SetDefault("The slime slows you down and makes you more vulnerable to fire.");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed *= 0.9f;
            
        }
    }
}