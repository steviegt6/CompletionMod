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
            switch (npc.type)
            {
                case NPCID.DD2OgreT2:
                case NPCID.DD2OgreT3:
                    CompletionModWorld.downedOgre = true;
                    break;
                case NPCID.DD2DarkMageT1:
                case NPCID.DD2DarkMageT3:
                    CompletionModWorld.downedDarkMage = true;
                    break;
            }
        }
    }
}
