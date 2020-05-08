using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CompletionMod.Items.Summons
{
    public class PiratesSail : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pirate's Sail");
            Tooltip.SetDefault("Summons the Flying Dutchman");
        }

        public override void SetDefaults()
        {
            item.useStyle = 4;
            item.width = 22;
            item.height = 14;
            item.consumable = true;
            item.useAnimation = 45;
            item.useTime = 45;
            item.maxStack = 20;
            item.value = 25 * 100 * 100;
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.PirateShip);
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}