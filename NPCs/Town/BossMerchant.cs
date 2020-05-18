using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CompletionMod.NPCs.Town
{
    [AutoloadHead]
    public class BossMerchant : ModNPC
    {
        public static bool shop1;
        public static bool shop2;
        public static bool shop3;

        public static int shopType = 1;
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Boss Merchant");
            Main.npcFrameCount[npc.type] = 25;
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 4;
            NPCID.Sets.DangerDetectRange[npc.type] = 700;
            NPCID.Sets.AttackType[npc.type] = 0;
            NPCID.Sets.AttackTime[npc.type] = 90;
            NPCID.Sets.AttackAverageChance[npc.type] = 30;
            NPCID.Sets.HatOffsetY[npc.type] = 4;
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 18;
            npc.height = 40;
            npc.aiStyle = 7;
            npc.damage = 10;
            npc.defense = 15;
            npc.lifeMax = 250;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
            animationType = NPCID.Guide;
        }
        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            if (NPC.downedSlimeKing)
                return true;
            else
                return false;
        }
        public override string TownNPCName()
        {
            return "Boss Merchant";
        }
        public override string GetChat()
        {
            switch (Main.rand.Next(2))
            {
                case 0:
                    return "...";
                case 1:
                    return "Yeah, my name is my profession. So what?";
                case 2:
                    return "I need a sprite, I know.";
                default:
                    return "...";
            }
        }
        public override void SetChatButtons(ref string button, ref string button2)
        {
            base.SetChatButtons(ref button, ref button2);
            switch (shopType)
            {
                case 1:
                    button = "Vanilla Summoning Items";
                    break;
                case 2:
                    button = "Vanilla Pre-Hardmode Boss Loot 1";
                    break;
                case 3:
                    button = "Vanilla Pre-Hardmode Boss Loot 2";
                    break;
            }
            if (shopType > 3)
                shopType = 1;
            button2 = "Switch Shops";
        }
        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            base.OnChatButtonClicked(firstButton, ref shop);
            if (firstButton)
            {
                //if (shopType == 1)
                //    Main.npcChatText = "Shop 1";
                //else if (shopType == 2)
                //    Main.npcChatText = "Shop 2";
                //else if (shopType == 3)
                //    Main.npcChatText = "Shop 3";
                //else
                //    Main.npcChatText = "Shop 1";
                shop = true;
                switch (shopType)
                {
                    case 1:
                        shop1 = true;
                        shop2 = false;
                        shop3 = false;
                        break;
                    case 2:
                        shop1 = false;
                        shop2 = true;
                        shop3 = false;
                        break;
                    case 3:
                        shop1 = false;
                        shop2 = false;
                        shop3 = true;
                        break;
                }
            }
            else
            {
                shopType++; ;
            }
        }
        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            if (shop1)
            {
                if (NPC.downedSlimeKing)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.SlimeCrown);
                    nextSlot++;
                }
                if (NPC.downedBoss1)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.SuspiciousLookingEye);
                    nextSlot++;
                }
                if (NPC.downedBoss2)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.WormFood);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.BloodySpine);
                    nextSlot++;
                }
                if (NPC.downedQueenBee)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.Abeemination);
                    nextSlot++;
                }
                if (NPC.downedBoss3)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.ClothierVoodooDoll);
                    nextSlot++;
                }
                if (Main.hardMode)
                {
                    shop.item[nextSlot].SetDefaults(mod.ItemType("ImprovedGuideVoodooDoll"));
                    nextSlot++;
                }
                if (NPC.downedMechBoss1)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.MechanicalWorm);
                    nextSlot++;
                }
                if (NPC.downedMechBoss2)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.MechanicalEye);
                    nextSlot++;
                }
                if (NPC.downedMechBoss3)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.MechanicalSkull);
                    nextSlot++;
                }
                if (NPC.downedPlantBoss)
                {
                    shop.item[nextSlot].SetDefaults(mod.ItemType("PlanterasBulb"));
                    nextSlot++;
                }
                if (NPC.downedGolemBoss)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.LihzahrdPowerCell);
                    nextSlot++;
                }
                if (NPC.downedFishron)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.TruffleWorm);
                    nextSlot++;
                }
                /*if (NPC.downedAncientCultist)
                {
                    shop.item[nextSlot].SetDefaults(mod.ItemType("AncientMask"));
                    nextSlot++;
                }*/
                if (NPC.downedMoonlord)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.CelestialSigil);
                    nextSlot++;
                }
                if (CompletionModWorld.downedOgre)
                {
                    shop.item[nextSlot].SetDefaults(mod.ItemType("OgresHead"));
                    nextSlot++;
                }
                if (CompletionModWorld.downedDarkMage)
                {
                    shop.item[nextSlot].SetDefaults(mod.ItemType("DarkTome"));
                    nextSlot++;
                }
                if (CompletionModWorld.downedBetsy)
                {
                    shop.item[nextSlot].SetDefaults(mod.ItemType("DragonFoot"));
                    nextSlot++;
                }
                if (NPC.downedGoblins)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.GoblinBattleStandard);
                    nextSlot++;
                }
                if (NPC.downedPirates)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.PirateMap);
                    nextSlot++;
                }
                if (CompletionModWorld.downedPirateShip)
                {
                    shop.item[nextSlot].SetDefaults(mod.ItemType("PiratesSail"));
                    nextSlot++;
                }
                if (CompletionModWorld.downedEclipse)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.SolarTablet);
                    nextSlot++;
                }
                if (CompletionModWorld.downedLegion)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.SnowGlobe);
                    nextSlot++;
                }
                if (CompletionModWorld.downedPumpkinMoon)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.PumpkinMoonMedallion);
                    nextSlot++;
                }
                if (CompletionModWorld.downedFrostMoon)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.NaughtyPresent);
                    nextSlot++;
                }

            }
            else if (shop2)
            {
                shop.item[nextSlot].SetDefaults(ItemID.EoCShield);
                nextSlot++;
            }
            else if (shop3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.SlimeCrown);
                nextSlot++;
            }
        }
        public override bool CanGoToStatue(bool toKingStatue)
        {
            return true;
        }
        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 34;
            knockback = 2f;
        }
        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 10;
            randExtraCooldown = 5;
        }
        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            projType = ProjectileID.Shuriken;
            attackDelay = 1;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 12f;
            randomOffset = 2f;
        }
    }
}
