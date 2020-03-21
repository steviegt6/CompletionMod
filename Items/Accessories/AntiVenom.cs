using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CompletionMod.Items.Accessories
{
    [AutoloadEquip(EquipType.Waist)]
    public class AntiVenom : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Anti-Venom");
            Tooltip.SetDefault("Immunity to Venom");
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.width = 22;
            item.height = 30;
            item.value = ((10 * 100) * 5) * 5;
            item.rare = 4;
            item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
            player.buffImmune[BuffID.Venom] = true;
        }
    }
}
