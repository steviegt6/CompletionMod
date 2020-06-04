using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CompletionMod.Items.Buckets
{
    public class BottomlessHoneyBucket : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Bottomless Honey Bucket");
            Tooltip.SetDefault("Contains an endless amount of honey");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.CloneDefaults(ItemID.BottomlessBucket);
            item.width = 30;
            item.height = 28;
            item.value = Item.sellPrice(0, 10, 0, 0);
        }

        public override bool UseItem(Player player)
        {
            return MoreBottomlessBuckets.UseBucket(player, MoreBottomlessBuckets.LiquidTypes.Honey, 2);
        }

        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HoneyBucket, 30);
            //recipe.needLava = true;
            recipe.SetResult(this);
            recipe.AddRecipe();

            ModRecipe recipe1 = new ModRecipe(mod);
            recipe1.AddIngredient(mod.ItemType("BottomlessEmptyBucket"), 1);
            recipe1.needHoney = true;
            recipe1.SetResult(this);
            recipe1.AddRecipe();
        }
    }
}