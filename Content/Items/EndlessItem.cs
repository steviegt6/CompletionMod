using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CompletionMod.Content.Items
{
    /// <summary>
    /// Serves as a base for endless items.
    /// </summary>
    public class EndlessItem : CompletionItem
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="itemType">The endless item's vanilla counterparts's type.</param>
        /// <param name="itemAmount">The ammount of the vanilla item required to craft this item.</param>
        /// <param name="craftingStation">The tile the item should be crafted at.</param>
        public EndlessItem(int itemType, int itemAmount = 3996, int craftingStation = TileID.WorkBenches)
        {
            ItemType = itemType;
            ItemAmount = itemAmount;
            CraftingStation = craftingStation;
        }

        private int ItemType;
        private int ItemAmount;
        private int CraftingStation;

        public override string Texture => "Terraria/Item_" + ItemType;

        public override void SetStaticDefaults()
        {
            string tooltip = "";

            for (int i = 0; i < Lang.GetTooltip(ItemType).Lines; i++)
            {
                if (i == 0)
                {
                    tooltip = Lang.GetTooltip(ItemType).GetLine(i);
                }
                else
                {
                    tooltip += "\n" + Lang.GetTooltip(ItemType).GetLine(i);
                }
            }

            DisplayName.SetDefault("Endless " + Lang.GetItemNameValue(ItemType));
            Tooltip.SetDefault(tooltip);
        }

        public override void SetItemDefaults()
        {
            item.CloneDefaults(ItemType);
            item.consumable = false;
            item.maxStack = 1;
            item.value *= ItemAmount;
            item.createTile = -1;
        }

        public override void UpdateInventory(Player player) => player.AddBuff(item.buffType, 2);

        public override bool PreDrawInInventory(SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale)
        {
            spriteBatch.Draw(Main.itemTexture[item.type], position, null, Main.DiscoColor, 0f, origin, scale, SpriteEffects.None, 1f);

            return false;
        }

        public override bool PreDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, ref float rotation, ref float scale, int whoAmI)
        {
            spriteBatch.Draw(Main.itemTexture[item.type], item.position - Main.screenPosition + new Vector2(item.width / 2, item.height - Main.itemTexture[item.type].Height * 0.5f + 2f), null, Main.DiscoColor, rotation, Main.itemTexture[item.type].Size() * 0.5f, scale, SpriteEffects.None, 0f);

            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType, ItemAmount);
            recipe.AddTile(CraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}