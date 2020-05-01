using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CompletionMod.Items.Accessories
{
    public class SigilDuster : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Sigil Duster");
            Tooltip.SetDefault("Provides immunity to Webbed and Distorted");
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.width = 44;
            item.height = 34;
            item.rare = 0;
            item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
            player.buffImmune[BuffID.Webbed] = true;
        }
        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("FeatherDuster"), 1);
            recipe.AddIngredient(mod.ItemType("TornRobe"), 1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
