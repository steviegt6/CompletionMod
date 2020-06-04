using Terraria;
using Terraria.ModLoader;

namespace CompletionMod.Items
{
    public abstract class UnconsumableItem : ModItem
    {
        /*public Color[] RedBlack => new Color[] { new Color(255, 0, 0), new Color(0, 0, 0) };
        int index = (int)(Main.GameUpdateCount / 60 % 2);*/

        public override void SetDefaults()
        {
            item.consumable = false;
        }

        public override bool ConsumeItem(Player player)
        {
            return false;
        }

        /*public override bool PreDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, ref float rotation, ref float scale, int whoAmI)
        {
            if (downedBoss)
            {
                Texture2D texture = mod.GetTexture("Glowmasks/" + glowMask);

                Vector2 position = item.position - Main.screenPosition + new Vector2(item.width / 2, item.height - texture.Height * 0.5f + 2f);

                for (int i = 0; i < 4; i++)
                {
                    Vector2 offsetPosition = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                    spriteBatch.Draw(texture, position + offsetPosition, null, Color.Lerp(RedBlack[index], RedBlack[(index + 1) % 2], CompletionModWorld.tick), rotation, texture.Size() * 0.5f, scale, SpriteEffects.None, 0f);
                }
            }
            return true;
        }

        public override bool PreDrawInInventory(SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale)
        {
            if (Main.hardMode)
            {
                Texture2D texture = mod.GetTexture("Glowmasks/ClothierVoodooDoll" + glowMask);

                for (int i = 0; i < 4; i++)
                {
                    Vector2 offsetPositon = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                    spriteBatch.Draw(texture, position + offsetPositon, null, Color.Lerp(RedBlack[index], RedBlack[(index + 1) % 2], CompletionModWorld.tick), 0, origin, scale, SpriteEffects.None, 0f);
                }
            }
            return true;
        }*/
    }
}