using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CompletionMod.Items.Accessories
{
    public class FeatherDuster : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Feather Duster");
            Tooltip.SetDefault("Provides immunity to Webbed");
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
            recipe.AddIngredient(ItemID.Wood, 5);
            recipe.AddIngredient(ItemID.Feather, 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
