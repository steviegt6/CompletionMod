using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CompletionMod.Items
{
    public class CompletionGlobalItem : GlobalItem
    {
        public override bool CloneNewInstances => true;

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
        }

        public override void SetDefaults(Item item)
        {
            if (Config.Instance.MaxStackEnabled)
                if (!(item.type == ItemID.CopperCoin || item.type == ItemID.SilverCoin || item.type == ItemID.GoldCoin))
                {
                    if (item.maxStack == 30 || item.maxStack == 50 || item.maxStack == 75 || item.maxStack == 20)
                        item.maxStack = 99;
                    else if (item.accessory == true || (item.damage > 0 && (item.type != ItemID.PlatinumCoin || item.ammo >= 1)) || item.defense > 0)
                        item.maxStack = 1;
                    else
                        item.maxStack = 9999;
                }
                else
                    base.SetDefaults(item);
            else
                base.SetDefaults(item);
            if (item.ammo != 0 && !Config.Instance.MaxStackEnabled)
                item.maxStack = 3996;
            switch (item.type)
            {
                case ItemID.SlimeCrown:
                    item.value = 1 * 100 * 100;
                    break;

                case ItemID.SuspiciousLookingEye:
                    item.value = 1 * 100 * 100;
                    break;

                case ItemID.WormFood:
                case ItemID.BloodySpine:
                    item.value = 2 * 100 * 100 + (50 * 100);
                    break;

                case ItemID.Abeemination:
                    item.value = 5 * 100 * 100 + (50 * 100);
                    break;

                case ItemID.PirateMap:
                    item.value = 10 * 100 * 100;
                    break;

                case ItemID.GoblinBattleStandard:
                    item.value = 1 * 100 * 100;
                    break;

                case ItemID.CelestialSigil:
                    item.value = 10 * 100 * 100;
                    break;

                case ItemID.SolarTablet:
                    item.value = 7 * 100 * 100 + (50 * 100);
                    break;

                case ItemID.PumpkinMoonMedallion:
                case ItemID.NaughtyPresent:
                    item.value = 10 * 100 * 100;
                    break;
            }
        }

        public override bool PreDrawInWorld(Item item, SpriteBatch spriteBatch, Color lightColor, Color alphaColor, ref float rotation, ref float scale, int whoAmI)
        {
            if (Config.Instance.RainbowOutline)
            {
                switch (item.type)
                {
                    case ItemID.SlimeCrown:
                        if (NPC.downedSlimeKing)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/SlimeCrown");

                            Vector2 position = item.position - Main.screenPosition + new Vector2(item.width / 2, item.height - texture.Height * 0.5f + 2f);

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPosition = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPosition, null, Main.DiscoColor, rotation, texture.Size() * 0.5f, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.SuspiciousLookingEye:
                        if (NPC.downedBoss1)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/SuspiciousLookingEye");

                            Vector2 position = item.position - Main.screenPosition + new Vector2(item.width / 2, item.height - texture.Height * 0.5f + 2f);

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPosition = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPosition, null, Main.DiscoColor, rotation, texture.Size() * 0.5f, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.WormFood:
                        if (NPC.downedBoss2)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/WormFood");

                            Vector2 position = item.position - Main.screenPosition + new Vector2(item.width / 2, item.height - texture.Height * 0.5f + 2f);

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPosition = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPosition, null, Main.DiscoColor, rotation, texture.Size() * 0.5f, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.BloodySpine:
                        if (NPC.downedBoss3)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/BloodySpine");

                            Vector2 position = item.position - Main.screenPosition + new Vector2(item.width / 2, item.height - texture.Height * 0.5f + 2f);

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPosition = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPosition, null, Main.DiscoColor, rotation, texture.Size() * 0.5f, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.Abeemination:
                        if (NPC.downedQueenBee)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/Abeemination");

                            Vector2 position = item.position - Main.screenPosition + new Vector2(item.width / 2, item.height - texture.Height * 0.5f + 2f);

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPosition = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPosition, null, Main.DiscoColor, rotation, texture.Size() * 0.5f, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.MechanicalWorm:
                        if (NPC.downedMechBoss1)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/MechanicalWorm");

                            Vector2 position = item.position - Main.screenPosition + new Vector2(item.width / 2, item.height - texture.Height * 0.5f + 2f);

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPosition = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPosition, null, Main.DiscoColor, rotation, texture.Size() * 0.5f, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.MechanicalEye:
                        if (NPC.downedMechBoss2)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/MechanicalEye");

                            Vector2 position = item.position - Main.screenPosition + new Vector2(item.width / 2, item.height - texture.Height * 0.5f + 2f);

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPosition = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPosition, null, Main.DiscoColor, rotation, texture.Size() * 0.5f, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.MechanicalSkull:
                        if (NPC.downedMechBoss3)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/MechanicalSkull");

                            Vector2 position = item.position - Main.screenPosition + new Vector2(item.width / 2, item.height - texture.Height * 0.5f + 2f);

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPosition = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPosition, null, Main.DiscoColor, rotation, texture.Size() * 0.5f, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.LihzahrdPowerCell:
                        if (NPC.downedGolemBoss)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/LihzahrdPowerCell");

                            Vector2 position = item.position - Main.screenPosition + new Vector2(item.width / 2, item.height - texture.Height * 0.5f + 2f);

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPosition = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPosition, null, Main.DiscoColor, rotation, texture.Size() * 0.5f, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.TruffleWorm:
                        if (NPC.downedFishron)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/TruffleWorm");

                            Vector2 position = item.position - Main.screenPosition + new Vector2(item.width / 2, item.height - texture.Height * 0.5f + 2f);

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPosition = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPosition, null, Main.DiscoColor, rotation, texture.Size() * 0.5f, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.CelestialSigil:
                        if (NPC.downedMoonlord)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/CelestialSigil");

                            Vector2 position = item.position - Main.screenPosition + new Vector2(item.width / 2, item.height - texture.Height * 0.5f + 2f);

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPosition = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPosition, null, Main.DiscoColor, rotation, texture.Size() * 0.5f, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.SolarTablet:
                        if (CompletionModWorld.downedEclipse)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/SolarTablet");

                            Vector2 position = item.position - Main.screenPosition + new Vector2(item.width / 2, item.height - texture.Height * 0.5f + 2f);

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPosition = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPosition, null, Main.DiscoColor, rotation, texture.Size() * 0.5f, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.PumpkinMoonMedallion:
                        if (CompletionModWorld.downedPumpkinMoon)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/PumpkinMoonMedallion");

                            Vector2 position = item.position - Main.screenPosition + new Vector2(item.width / 2, item.height - texture.Height * 0.5f + 2f);

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPosition = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPosition, null, Main.DiscoColor, rotation, texture.Size() * 0.5f, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.NaughtyPresent:
                        if (CompletionModWorld.downedFrostMoon)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/NaughtyPresent");

                            Vector2 position = item.position - Main.screenPosition + new Vector2(item.width / 2, item.height - texture.Height * 0.5f + 2f);

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPosition = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPosition, null, Main.DiscoColor, rotation, texture.Size() * 0.5f, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.GoblinBattleStandard:
                        if (NPC.downedGoblins)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/GoblinBattleStandard");

                            Vector2 position = item.position - Main.screenPosition + new Vector2(item.width / 2, item.height - texture.Height * 0.5f + 2f);

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPosition = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPosition, null, Main.DiscoColor, rotation, texture.Size() * 0.5f, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    default:
                        return base.PreDrawInWorld(item, spriteBatch, lightColor, alphaColor, ref rotation, ref scale, whoAmI);
                }
            }
            else
                return base.PreDrawInWorld(item, spriteBatch, lightColor, alphaColor, ref rotation, ref scale, whoAmI);
        }

        public override bool PreDrawInInventory(Item item, SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale)
        {
            if (Config.Instance.RainbowOutline)
            {
                switch (item.type)
                {
                    case ItemID.SlimeCrown:
                        if (NPC.downedSlimeKing)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/SlimeCrown");

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPositon = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPositon, null, Main.DiscoColor, 0, origin, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.SuspiciousLookingEye:
                        if (NPC.downedBoss1)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/SuspiciousLookingEye");

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPositon = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPositon, null, Main.DiscoColor, 0, origin, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.WormFood:
                        if (NPC.downedBoss2)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/WormFood");

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPositon = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPositon, null, Main.DiscoColor, 0, origin, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.BloodySpine:
                        if (NPC.downedBoss3)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/BloodySpine");

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPositon = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPositon, null, Main.DiscoColor, 0, origin, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.Abeemination:
                        if (NPC.downedQueenBee)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/Abeemination");

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPositon = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPositon, null, Main.DiscoColor, 0, origin, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.MechanicalWorm:
                        if (NPC.downedMechBoss1)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/MechanicalWorm");

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPositon = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPositon, null, Main.DiscoColor, 0, origin, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.MechanicalEye:
                        if (NPC.downedMechBoss2)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/MechanicalEye");

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPositon = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPositon, null, Main.DiscoColor, 0, origin, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.MechanicalSkull:
                        if (NPC.downedMechBoss3)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/MechanicalSkull");

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPositon = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPositon, null, Main.DiscoColor, 0, origin, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.LihzahrdPowerCell:
                        if (NPC.downedGolemBoss)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/LihzahrdPowerCell");

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPositon = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPositon, null, Main.DiscoColor, 0, origin, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.TruffleWorm:
                        if (NPC.downedFishron)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/TruffleWorm");

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPositon = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPositon, null, Main.DiscoColor, 0, origin, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.CelestialSigil:
                        if (NPC.downedMoonlord)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/CelestialSigil");

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPositon = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPositon, null, Main.DiscoColor, 0, origin, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.SolarTablet:
                        if (CompletionModWorld.downedEclipse)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/SolarTablet");

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPositon = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPositon, null, Main.DiscoColor, 0, origin, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.PumpkinMoonMedallion:
                        if (CompletionModWorld.downedPumpkinMoon)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/PumpkinMoonMedallion");

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPositon = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPositon, null, Main.DiscoColor, 0, origin, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.NaughtyPresent:
                        if (CompletionModWorld.downedFrostMoon)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/NaughtyPresent");

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPositon = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPositon, null, Main.DiscoColor, 0, origin, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    case ItemID.GoblinBattleStandard:
                        if (NPC.downedGoblins)
                        {
                            Texture2D texture = mod.GetTexture("Glowmasks/GoblinBattleStandard");

                            for (int i = 0; i < 4; i++)
                            {
                                Vector2 offsetPositon = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                                spriteBatch.Draw(texture, position + offsetPositon, null, Main.DiscoColor, 0, origin, scale, SpriteEffects.None, 0f);
                            }
                        }
                        return true;

                    default:
                        return base.PreDrawInInventory(item, spriteBatch, position, frame, drawColor, itemColor, origin, scale);
                }
            }
            else
                return base.PreDrawInInventory(item, spriteBatch, position, frame, drawColor, itemColor, origin, scale);
        }

        public override void UpdateInventory(Item item, Player player)
        {
            if (Config.Instance.infPotions)
                if (item.buffTime != 0 && item.stack >= Config.Instance.potionsNeeded)
                    player.AddBuff(item.buffType, 1);
        }

        public override bool ConsumeItem(Item item, Player player)
        {
            if (Config.Instance.infThrowing && item.thrown)
                if (item.maxStack > 1 && item.stack >= Config.Instance.throwingNeeded)
                    return false;
                else
                    return base.ConsumeItem(item, player);
            else if (Config.Instance.infPotions && item.buffTime != 0)
                if (item.stack >= Config.Instance.potionsNeeded)
                    return false;
                else
                    return base.ConsumeItem(item, player);
            else
                return base.ConsumeItem(item, player);
        }

        public override bool ConsumeAmmo(Item item, Player player)
        {
            if (Config.Instance.infAmmo && item.ammo != 0)
                if (item.maxStack > 1 && item.stack >= Config.Instance.ammoNeeded)
                    return false;
                else
                    return base.ConsumeAmmo(item, player);
            else
                return base.ConsumeAmmo(item, player);
        }

        public override void OpenVanillaBag(string context, Player player, int arg)
        {
            if (context == "present")
            {
                if (Main.rand.Next(156) == 0)
                    player.QuickSpawnItem(mod.ItemType("GreenCandyCaneHookItem"));
                else if (Main.rand.Next(159) == 0)
                    player.QuickSpawnItem(mod.ItemType("GreenCnadyCanePickaxe"));
                else if (Main.rand.Next(159) == 0)
                    player.QuickSpawnItem(mod.ItemType("GreenCandyCaneSword"));
            }
        }
    }
}