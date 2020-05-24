using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CompletionMod.Placeholders
{
    public class DemoniteCrimtaneBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault(" ");
            Tooltip.SetDefault("You... shouldn't have this.");
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.CloneDefaults(ItemID.DemoniteBar);
            item.value = 0;
        }
        /*public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("CompletionMod:DemoniteCrimtaneBar", 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }*/
    }
}
