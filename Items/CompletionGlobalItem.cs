using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CompletionMod;
using static Terraria.ModLoader.ModContent;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

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
            switch (item.type)
            {
                case ItemID.SlimeCrown:
                    item.value = 50 * 100;
                    break;
                case ItemID.SuspiciousLookingEye:
                    item.value = 1 * 100 * 100;
                    break;
                case ItemID.WormFood:
                case ItemID.BloodySpine:
                    item.value = 5 * 100 * 100;
                    break;
                case ItemID.Abeemination:
                    item.value = 7 * 100 * 100 + (50 * 100);
                    break;
                case ItemID.PirateMap:
                    item.value = 20 * 100 * 100;
                    break;
                case ItemID.GoblinBattleStandard:
                    item.value = 10 * 100;
                    break;
                case ItemID.TruffleWorm:
                case ItemID.LihzahrdPowerCell:
                    item.consumable = true;
                    break;
            }
        }
        public override bool PreDrawInWorld(Item item, SpriteBatch spriteBatch, Color lightColor, Color alphaColor, ref float rotation, ref float scale, int whoAmI)
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
                default:
                    return base.PreDrawInWorld(item, spriteBatch, lightColor, alphaColor, ref rotation, ref scale, whoAmI);
            }
        }
        public override bool PreDrawInInventory(Item item, SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale)
        {
            return base.PreDrawInInventory(item, spriteBatch, position, frame, drawColor, itemColor, origin, scale);
        }
        public override bool CanUseItem(Item item, Player player)
        {
            switch (item.type)
            {
                case ItemID.SlimeCrown:
                    if (!NPC.AnyNPCs(NPCID.KingSlime) || NPC.downedSlimeKing)
                        return true;
                    else
                        return false;
                case ItemID.SuspiciousLookingEye:
                    if (!NPC.AnyNPCs(NPCID.EyeofCthulhu) || NPC.downedBoss1)
                        return true;
                    else
                        return false;
                case ItemID.WormFood:
                    if (!NPC.AnyNPCs(NPCID.EaterofWorldsHead) || NPC.downedBoss2)
                        return true;
                    else
                        return false;
                case ItemID.BloodySpine:
                    if (!NPC.AnyNPCs(NPCID.BrainofCthulhu) || NPC.downedBoss3)
                        return true;
                    else
                        return false;
                case ItemID.Abeemination:
                    if (!NPC.AnyNPCs(NPCID.QueenBee) || NPC.downedQueenBee)
                        return true;
                    else
                        return false;
                case ItemID.MechanicalEye:
                    if (!NPC.AnyNPCs(NPCID.Retinazer) || !NPC.AnyNPCs(NPCID.Spazmatism) || NPC.downedMechBoss1)
                        return true;
                    else
                        return false;
                case ItemID.MechanicalWorm:
                    if (!NPC.AnyNPCs(NPCID.TheDestroyer) || NPC.downedMechBoss2)
                        return true;
                    else
                        return false;
                case ItemID.MechanicalSkull:
                    if (!NPC.AnyNPCs(NPCID.SkeletronPrime) || NPC.downedMechBoss3)
                        return true;
                    else
                        return false;
                case ItemID.LihzahrdPowerCell:
                    if (!NPC.AnyNPCs(NPCID.Golem) || NPC.downedGolemBoss)
                        return true;
                    else
                        return false;
                case ItemID.TruffleWorm:
                    if (!NPC.AnyNPCs(NPCID.DukeFishron) || NPC.downedFishron)
                        return true;
                    else
                        return false;
                case ItemID.CelestialSigil:
                    if (!NPC.AnyNPCs(NPCID.MoonLordCore) || NPC.downedMoonlord)
                        return true;
                    else
                        return false;
                default:
                    return base.CanUseItem(item, player);
            }
        }
        public override bool UseItem(Item item, Player player)
        {
            switch (item.type)
            {
                case ItemID.SlimeCrown:
                    if (NPC.downedSlimeKing)
                        CompletionModPlayer.SpawnOnCompletionPlayer(player.whoAmI, NPCID.KingSlime);
                    else
                        NPC.SpawnOnPlayer(player.whoAmI, NPCID.KingSlime);
                    Main.PlaySound(SoundID.Roar, player.position, 0);
                    return true;
                case ItemID.SuspiciousLookingEye:
                    if (NPC.downedSlimeKing)
                        CompletionModPlayer.SpawnOnCompletionPlayer(player.whoAmI, NPCID.EyeofCthulhu);
                    else
                        NPC.SpawnOnPlayer(player.whoAmI, NPCID.KingSlime);
                    Main.PlaySound(SoundID.Roar, player.position, 0);
                    return true;
                case ItemID.WormFood:
                    if (NPC.downedSlimeKing)
                        CompletionModPlayer.SpawnOnCompletionPlayer(player.whoAmI, NPCID.EaterofWorldsHead);
                    else
                        NPC.SpawnOnPlayer(player.whoAmI, NPCID.KingSlime);
                    Main.PlaySound(SoundID.Roar, player.position, 0);
                    return true;
                case ItemID.BloodySpine:
                    if (NPC.downedSlimeKing)
                        CompletionModPlayer.SpawnOnCompletionPlayer(player.whoAmI, NPCID.BrainofCthulhu);
                    else
                        NPC.SpawnOnPlayer(player.whoAmI, NPCID.KingSlime);
                    Main.PlaySound(SoundID.Roar, player.position, 0);
                    return true;
                case ItemID.Abeemination:
                    if (NPC.downedSlimeKing)
                        CompletionModPlayer.SpawnOnCompletionPlayer(player.whoAmI, NPCID.QueenBee);
                    else
                        NPC.SpawnOnPlayer(player.whoAmI, NPCID.KingSlime);
                    Main.PlaySound(SoundID.Roar, player.position, 0);
                    return true;
                case ItemID.MechanicalEye:
                    if (NPC.downedSlimeKing)
                    {
                        CompletionModPlayer.SpawnOnCompletionPlayer(player.whoAmI, NPCID.Retinazer);
                        CompletionModPlayer.SpawnOnCompletionPlayer(player.whoAmI, NPCID.Spazmatism);
                    }
                    else
                    {
                        NPC.SpawnOnPlayer(player.whoAmI, NPCID.Retinazer);
                        NPC.SpawnOnPlayer(player.whoAmI, NPCID.Spazmatism);
                    }
                    Main.PlaySound(SoundID.Roar, player.position, 0);
                    return true;
                case ItemID.MechanicalWorm:
                    if (NPC.downedSlimeKing)
                        CompletionModPlayer.SpawnOnCompletionPlayer(player.whoAmI, NPCID.TheDestroyer);
                    else
                        NPC.SpawnOnPlayer(player.whoAmI, NPCID.KingSlime);
                    Main.PlaySound(SoundID.Roar, player.position, 0);
                    return true;
                case ItemID.MechanicalSkull:
                    if (NPC.downedSlimeKing)
                        CompletionModPlayer.SpawnOnCompletionPlayer(player.whoAmI, NPCID.SkeletronPrime);
                    else
                        NPC.SpawnOnPlayer(player.whoAmI, NPCID.KingSlime);
                    Main.PlaySound(SoundID.Roar, player.position, 0);
                    return true;
                case ItemID.LihzahrdPowerCell:
                    if (NPC.downedSlimeKing)
                        CompletionModPlayer.SpawnOnCompletionPlayer(player.whoAmI, NPCID.Golem);
                    else
                        NPC.SpawnOnPlayer(player.whoAmI, NPCID.KingSlime);
                    Main.PlaySound(SoundID.Roar, player.position, 0);
                    return true;
                case ItemID.TruffleWorm:
                    if (NPC.downedSlimeKing)
                        CompletionModPlayer.SpawnOnCompletionPlayer(player.whoAmI, NPCID.DukeFishron);
                    else
                        NPC.SpawnOnPlayer(player.whoAmI, NPCID.KingSlime);
                    Main.PlaySound(SoundID.Roar, player.position, 0);
                    return true;
                case ItemID.CelestialSigil:
                    if (NPC.downedSlimeKing)
                        CompletionModPlayer.SpawnOnCompletionPlayer(player.whoAmI, NPCID.MoonLordCore);
                    else
                        NPC.SpawnOnPlayer(player.whoAmI, NPCID.KingSlime);
                    Main.PlaySound(SoundID.Roar, player.position, 0);
                    return true;
                default:
                    return base.UseItem(item, player);
            }
        }
        public override void OpenVanillaBag(string context, Player player, int arg)
        {
            //base.OpenVanillaBag(context, player, arg);
            if (context == "present")
            {
                if (Main.rand.Next(156) == 0)
                {
                    player.QuickSpawnItem(mod.ItemType("GreenCandyCaneHookItem"));
                }
                else if (Main.rand.Next(159) == 0)
                {
                    player.QuickSpawnItem(mod.ItemType("GreenCnadyCanePickaxe"));
                }
                else if (Main.rand.Next(159) == 0)
                {
                    player.QuickSpawnItem(mod.ItemType("GreenCandyCaneSword"));
                }
            }
        }
    }
}