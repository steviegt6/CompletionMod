using System.ComponentModel;
using Terraria.ID;
using Terraria.ModLoader.Config;

namespace CompletionMod
{
    [Label("Config")]
    public class CompletionModConfigServer : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        // 188 = ItemID.HealingPotion
        [Header("[i:188] Buffs/Potions")]
        [Label("Max Buffs")]
        [Tooltip("The maximum amount of buffs a player can have." +
            "\nDefault is 22." +
            "\nMinimum: 0" +
            "\nMaximum: 100")]
        [DefaultValue(22)]
        [Range(0, 100)]
        public int maximumBuffs;
    }
}