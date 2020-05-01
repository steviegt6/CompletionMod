using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CompletionMod.Items.Accessories
{
    public class HoneyBottle : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Honey Bottle");
            Tooltip.SetDefault("Tasty!" +
                "\nProvides immunity to On Fire!, Oozed, Ichor, and Cursed Inferno" +
                "\nYou are always Wet");
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.width = 16;
            item.height = 24;
            item.value = (4 * 5) * 2;
            item.rare = 0;
            item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
            player.buffImmune[BuffID.OnFire] = true;
            player.buffImmune[BuffID.OgreSpit] = true;
            player.buffImmune[BuffID.Ichor] = true;
            player.buffImmune[BuffID.CursedInferno] = true;

            //bool submerged = Collision.DrownCollision(player.position, player.width, player.height, player.gravDir);
            /*player.wet = true;
            if (!submerged)
                player.ignoreWater = true;*/
            player.AddBuff(BuffID.Wet, 0, true);
        }
        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("WaterBottle"), 1);
            recipe.AddTile(TileID.Bottles);
            recipe.needHoney = true;
            recipe.SetResult(this);
            recipe.AddRecipe();

            ModRecipe recipe1 = new ModRecipe(mod);
            recipe1.AddIngredient(mod.ItemType("WaterBottle"), 1);
            recipe1.AddIngredient(ItemID.BottledHoney, 5);
            recipe1.AddTile(TileID.Bottles);
            recipe1.SetResult(this);
            recipe1.AddRecipe();
        }
    }
}
