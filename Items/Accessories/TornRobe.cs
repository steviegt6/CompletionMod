using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CompletionMod.Items.Accessories
{
    public class TornRobe : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Torn Robe");
            Tooltip.SetDefault("Provides immunity to Distorted");
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.width = 14;
            item.height = 26;
            item.rare = 0;
            item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
            player.buffImmune[BuffID.VortexDebuff] = true;
        }
    }
}
