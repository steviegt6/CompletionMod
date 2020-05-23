using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CompletionMod.Items.Summons
{
    public class ImprovedGuideVoodooDoll : ModItem
    {
        public override string Texture => "Terraria/Item_267";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Guide Voodoo Doll");
            Tooltip.SetDefault("Can summon the Wall of Flesh without killing the Guide.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.GuideVoodooDoll);
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.consumable = true;
            item.useAnimation = 45;
            item.useTime = 45;
            item.maxStack = 20;
            item.value = 10 * 100 * 100;
            item.accessory = false;
        }

        public override bool PreDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, ref float rotation, ref float scale, int whoAmI)
        {
            if (Main.hardMode)
            {
                Texture2D texture = mod.GetTexture("Glowmasks/GuideVoodooDoll");

                Vector2 position = item.position - Main.screenPosition + new Vector2(item.width / 2, item.height - texture.Height * 0.5f + 2f);

                for (int i = 0; i < 4; i++)
                {
                    Vector2 offsetPosition = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                    spriteBatch.Draw(texture, position + offsetPosition, null, Main.DiscoColor, rotation, texture.Size() * 0.5f, scale, SpriteEffects.None, 0f);
                }
            }
            return true;
        }

        public override bool PreDrawInInventory(SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale)
        {
            if (Main.hardMode)
            {
                Texture2D texture = mod.GetTexture("Glowmasks/GuideVoodooDoll");

                for (int i = 0; i < 4; i++)
                {
                    Vector2 offsetPositon = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                    spriteBatch.Draw(texture, position + offsetPositon, null, Main.DiscoColor, 0, origin, scale, SpriteEffects.None, 0f);
                }
            }
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.ZoneUnderworldHeight && (!NPC.AnyNPCs(NPCID.WallofFlesh) || Main.hardMode))
                return true;
            else
                return false;
        }
        public override bool UseItem(Player player)
        {
            CompletionModPlayer.SpawnCompletionWOF(player.position);
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}