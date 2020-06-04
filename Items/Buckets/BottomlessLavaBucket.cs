using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CompletionMod.Items.Buckets
{
    public class BottomlessLavaBucket : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Bottomless Bucket");
            Tooltip.SetDefault("Contains an endless amount of lava");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.CloneDefaults(ItemID.BottomlessBucket);
            item.width = 30;
            item.height = 28;
            item.defense = 3;
            item.value = Item.sellPrice(0, 10, 0, 0);
        }

        public override bool UseItem(Player player)
        {
            return MoreBottomlessBuckets.UseBucket(player, MoreBottomlessBuckets.LiquidTypes.Lava, 2);
        }

        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LavaBucket, 30);
            //recipe.needLava = true;
            recipe.SetResult(this);
            recipe.AddRecipe();

            ModRecipe recipe1 = new ModRecipe(mod);
            recipe1.AddIngredient(mod.ItemType("BottomlessEmptyBucket"), 1);
            recipe1.needLava = true;
            recipe1.SetResult(this);
            recipe1.AddRecipe();
        }
    }
}