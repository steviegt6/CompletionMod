using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CompletionMod.Items.Summons
{
    public class PiratesSail : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pirate's Sail");
            Tooltip.SetDefault("Summons the Flying Dutchman");
        }

        public override void SetDefaults()
        {
            item.useStyle = 4;
            item.width = 22;
            item.height = 14;
            item.consumable = true;
            item.useAnimation = 45;
            item.useTime = 45;
            item.maxStack = 20;
            item.value = 25 * 100 * 100;
        }

        public override bool PreDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, ref float rotation, ref float scale, int whoAmI)
        {
            if (CompletionModWorld.downedPirateShip)
            {
                Texture2D texture = mod.GetTexture("Glowmasks/PiratesSail");

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
            if (CompletionModWorld.downedPirateShip)
            {
                Texture2D texture = mod.GetTexture("Glowmasks/PiratesSail");

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
            if (!NPC.AnyNPCs(NPCID.PirateShip) || CompletionModWorld.downedPirateShip)
            {
                return true;
            }
            else
                return false;
        }
        public override bool UseItem(Player player)
        {
            if (NPC.downedPirates)
                CompletionModPlayer.SpawnOnCompletionPlayer(player.whoAmI, NPCID.PirateShip);
            else
                NPC.SpawnOnPlayer(player.whoAmI, NPCID.PirateShip);
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}