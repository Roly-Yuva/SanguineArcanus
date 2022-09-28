/*using SanguineArcanus.Content.Items.Materials;
using System;
using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.ID;
using Terraria.ModLoader;

namespace SanguineArcanus.Content.NPCs
{
    public class UndeadMagician : ModNPC
    {
        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[] {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Zones.ZoneRockLayerHeight,

                new FlavorTextBestiaryInfoElement("Some magicians may become cursed, forced to wander aimlessly underground as their flesh decays, leaving nothing but bones. How they become cursed, I know not.");
            });
        }

        public override float SpawnChance (NPCSpawnInfo spawnInfo)
        {
            if (spawnInfo.Player.ZoneRockLayerHeight) {
                return 0.25f;
            }

            return 0f;
        }

        public override void OnKill()
        {
            int droppedAmount = Main.rand(2);
            Item.NewItem(NPC.GetSource_Death(), NPC.Center, ModContent.ItemType<ArcaneSigil>(), droppedAmount + 1, true);
        }
    }
}*/