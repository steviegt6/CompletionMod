using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CompletionMod;
using static Terraria.ModLoader.ModContent;
using System.Collections.Generic;
using MonoMod.Cil;
using System;
using static Mono.Cecil.Cil.OpCodes;

namespace CompletionMod.NPCs
{
    public class CompletionGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            base.NPCLoot(npc);
            switch (npc.type)
            {
                case NPCID.DD2OgreT2:
                    if (!CompletionModWorld.downedOgreHard)
                        CompletionModWorld.downedOgre = true;
                    break;
                case NPCID.DD2OgreT3:
                    {
                        CompletionModWorld.downedOgre = false;
                        CompletionModWorld.downedOgreHard = true;
                    }
                    break;
                case NPCID.DD2DarkMageT1:
                    if (!CompletionModWorld.downedDarkMageHard)
                        CompletionModWorld.downedDarkMage = true;
                    break;
                case NPCID.DD2DarkMageT3:
                    {
                        CompletionModWorld.downedDarkMage = false;
                        CompletionModWorld.downedDarkMageHard = true;
                    }
                    break;
                case NPCID.DD2Betsy:
                    CompletionModWorld.downedBetsy = true;
                    break;
                case NPCID.PirateShip:
                    CompletionModWorld.downedPirateShip = true;
                    break;
            }
        }
        public override bool Autoload(ref string name) //IL Editing credit goes to Atenfyr! :D
        {
            IL.Terraria.Main.GUIChatDrawInner += HookAdjustButton;
            return base.Autoload(ref name);
        }
        private void HookAdjustButton(ILContext il)
        {
            var c = new ILCursor(il).Goto(0);

            if (!c.TryGotoNext(i => i.MatchLdcI4(NPCID.Angler))) throw new Exception("Can't patch Angler shop button");
            if (!c.TryGotoNext(i => i.MatchLdcI4(NPCID.Angler))) throw new Exception("Can't patch Angler shop button");

            c.Index += 2;

            c.EmitDelegate<Func<string>>(() => "Shop");

            c.Emit(Stloc_S, (byte)10);
        }
        public override void OnChatButtonClicked(NPC npc, bool firstButton)
        {
            switch (npc.type)
            {
                case NPCID.Angler:
                    if (!firstButton)
                    {
                        Main.playerInventory = true;
                        Main.npcChatText = ""; // Closes chat.
                        Main.npcShop = Main.MaxShopIDs - 1;
                        Main.instance.shop[Main.npcShop].SetupShop(NPCID.Angler);
                        Main.PlaySound(SoundID.MenuTick);
                    }
                    break;
            }
        }
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
                case NPCID.Angler:
                    shop.item[nextSlot].SetDefaults(ItemID.FuzzyCarrot);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.AnglerHat);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.AnglerVest);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.AnglerPants);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.GoldenFishingRod);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.GoldenBugNet);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.FishHook);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.HighTestFishingLine);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.AnglerEarring);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.TackleBox);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.FishermansGuide);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.WeatherRadio);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.Sextant);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.ApprenticeBait);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.JourneymanBait);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.MasterBait);
                    shop.item[nextSlot].SetDefaults(ItemID.CoralstoneBlock);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.SeashellHairpin);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.MermaidAdornment);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.MermaidTail);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.FishCostumeMask);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.FishCostumeShirt);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.FishCostumeFinskirt);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.BunnyfishTrophy);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.GoldfishTrophy);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.SharkteethTrophy);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.SwordfishTrophy);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.TreasureMap);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.SeaweedPlanter);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.PillaginMePixels);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.CompassRose);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.ShipsWheel);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.LifePreserver);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.WallAnchor);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.ShipInABottle);
                    nextSlot++;
                    nextSlot++;
                    if (Main.hardMode)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.FinWings);
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemID.BottomlessBucket);
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemID.SuperAbsorbantSponge);
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemID.HotlineFishingHook);
                        nextSlot++;
                    }
                    break;
            }
        }
    }
}
