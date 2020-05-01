using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CompletionMod;
using static Terraria.ModLoader.ModContent;
using System.Collections.Generic;

namespace CompletionMod.NPCs
{
    public class CompletionGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            base.NPCLoot(npc);
            if (npc.type == NPCID.CultistBoss)
            {
                switch (Main.rand.Next(20))
                {
                    case 0:
                        Item.NewItem(npc.Hitbox, mod.ItemType("TornRobe"));
                        break;
                }
            }
        }
    }
}
