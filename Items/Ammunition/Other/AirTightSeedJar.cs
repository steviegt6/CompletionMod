using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CompletionMod.Items.Ammunition.Other
{
    public class AirTightSeedJar : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Air-Tight Seed Jar");
            Tooltip.SetDefault("For use with the Blowpipe");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.CloneDefaults(ItemID.Seed);
            item.consumable = false;
        }

        public override bool ConsumeItem(Player player)
        {
            return false;
            //return base.ConsumeItem(player);
        }

        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Seed, 3996);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}