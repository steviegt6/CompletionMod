using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CompletionMod.Items.CandyCane
{
    //Misspelling of "Candy" is a reference to the actual Candy Cane Pickaxe. (https://terraria.gamepedia.com/Candy_Cane_Pickaxe#Trivia)
    public class GreenCnadyCanePickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Green Candy Cane Pickaxe");
            Tooltip.SetDefault("Can mine Meteorite");
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.CloneDefaults(ItemID.CnadyCanePickaxe);
            item.value = 0;
        }
        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GreenCandyCaneBlock, 35);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
