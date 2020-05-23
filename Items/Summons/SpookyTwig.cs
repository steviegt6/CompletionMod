﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CompletionMod.Items.Summons
{
    public class SpookyTwig : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spooky Twig");
            Tooltip.SetDefault("Summons Mourning Wood");
        }

        public override void SetDefaults()
        {
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.width = 32;
            item.height = 28;
            item.consumable = true;
            item.useAnimation = 45;
            item.useTime = 45;
            item.maxStack = 20;
            item.value = 10 * 100 * 100;
        }

        public override bool PreDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, ref float rotation, ref float scale, int whoAmI)
        {
            if (CompletionModWorld.downedMourningWood)
            {
                Texture2D texture = mod.GetTexture("Glowmasks/SpookyTwig");

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
            if (CompletionModWorld.downedMourningWood)
            {
                Texture2D texture = mod.GetTexture("Glowmasks/SpookyTwig");

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
            if (CompletionModWorld.downedMourningWood || !NPC.AnyNPCs(NPCID.MourningWood))
                return true;
            else
                return false;
        }
        public override bool UseItem(Player player)
        {
            if (CompletionModWorld.downedMourningWood)
                CompletionModPlayer.SpawnOnCompletionPlayer(player.whoAmI, NPCID.MourningWood);
            else
                NPC.SpawnOnPlayer(player.whoAmI, NPCID.MourningWood);
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}