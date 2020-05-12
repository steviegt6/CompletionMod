using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CompletionMod;
using static Terraria.ModLoader.ModContent;
using System.Collections.Generic;

namespace CompletionMod.Items
{
    public class CompletionGlobalItem : GlobalItem
    {
        public override bool CloneNewInstances => /*base.CloneNewInstances;*/ true;
        public override void SetDefaults(Item item)
        {
            base.SetDefaults(item);
            if (Config.Instance.MaxStackEnabled)
            {
                if (!(item.type == ItemID.CopperCoin || item.type == ItemID.SilverCoin || item.type == ItemID.GoldCoin))
                {
                    if (item.maxStack == 30 || item.maxStack == 50 || item.maxStack == 75 || item.maxStack == 20)
                    {
                        item.maxStack = 99;
                    }
                    else if (item.accessory == true || (item.damage > 0 && (item.type != ItemID.PlatinumCoin || item.ammo >= 1)) || item.defense > 0)
                    {
                        item.maxStack = 1;
                    }
                    else
                    {
                        item.maxStack = 9999;
                    }
                }
                else
                {
                    base.SetDefaults(item);
                }
            }
            else
            {
                base.SetDefaults(item);
            }
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
                case ItemID.ClothierVoodooDoll:
                    item.value = 15 * 100 * 100;
                    break;
                case ItemID.GuideVoodooDoll:
                    item.value = 20 * 100 * 100;
                    break;
                case ItemID.PirateMap:
                    item.value = 20 * 100 * 100;
                    break;
                case ItemID.GoblinBattleStandard:
                    item.value = 10 * 100;
                    break;
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