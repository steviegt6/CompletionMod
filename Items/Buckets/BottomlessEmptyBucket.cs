﻿using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace CompletionMod.Items.Buckets
{
    [AutoloadEquip(EquipType.Head)]
    public class BottomlessEmptyBucket : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Bottomless Bucket");
            Tooltip.SetDefault("Contains an endless amount of ɔiʇ>⊣s l>eɹeʇui");
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.width = 30;
            item.height = 28;
            item.defense = 3;
            item.value = Item.sellPrice(0, 10, 0, 0);
        }
        public override void UpdateArmorSet(Player player)
        {
            base.UpdateArmorSet(player);
            player.statDefense += 3;
        }
       
        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EmptyBucket, 30);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
