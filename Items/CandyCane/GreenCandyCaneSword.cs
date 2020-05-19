using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CompletionMod.Items.CandyCane
{
    public class GreenCandyCaneSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Green Candy Cane Pickaxe");
            //Tooltip.SetDefault("");
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.CloneDefaults(ItemID.CandyCaneSword);
            item.damage = 18;
        }
        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GreenCandyCaneBlock, 50);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
