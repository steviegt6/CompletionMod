using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CompletionMod.Items.Summons
{
    public class DarkTome : ModItem
    { 
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dark Tome");
            Tooltip.SetDefault("Summons the Dark Mage");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SuspiciousLookingEye);
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.consumable = true;
            item.useAnimation = 45;
            item.useTime = 45;
            item.maxStack = 20;
            item.value = 15 * 100 * 100;
        }

        public override bool PreDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, ref float rotation, ref float scale, int whoAmI)
        {
            if (CompletionModWorld.downedDarkMage || CompletionModWorld.downedDarkMageHard)
            {
                Texture2D texture = mod.GetTexture("Glowmasks/DarkTome");

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
            if (CompletionModWorld.downedDarkMage || CompletionModWorld.downedDarkMageHard)
            {
                Texture2D texture = mod.GetTexture("Glowmasks/DarkTome");

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
            if (CompletionModWorld.downedDarkMage || CompletionModWorld.downedDarkMageHard || (!NPC.AnyNPCs(NPCID.DD2DarkMageT1) && !NPC.AnyNPCs(NPCID.DD2DarkMageT3)))
                return true;
            else
                return false;
        }
        public override bool UseItem(Player player)
        {
            if (CompletionModWorld.downedDarkMage && !CompletionModWorld.downedDarkMageHard)
                CompletionModPlayer.SpawnOnCompletionPlayer(player.whoAmI, NPCID.DD2DarkMageT1);
            else if (CompletionModWorld.downedDarkMageHard && !CompletionModWorld.downedDarkMage)
                CompletionModPlayer.SpawnOnCompletionPlayer(player.whoAmI, NPCID.DD2DarkMageT1);
            else
                NPC.SpawnOnPlayer(player.whoAmI, NPCID.DD2DarkMageT1);
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}