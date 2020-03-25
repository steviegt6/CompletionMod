using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CompletionMod.Items.Accessories
{
    public class WaterBottle : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Water Bottle");
            Tooltip.SetDefault("Refreshing!" +
                "\nProvides immunity to On Fire!, Oozed, and Ichor" +
                "\nYou are always Wet");
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.width = 22;
            item.height = 30;
            item.value = ((10 * 100) * 5) * 5;
            item.rare = 0;
            item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
            player.buffImmune[BuffID.OnFire] = true;
            player.buffImmune[BuffID.OgreSpit] = true;
            player.buffImmune[BuffID.Ichor] = true;
            //player.wet = true;
            player.AddBuff(BuffID.Wet, 0, true);
        }
    }
}
