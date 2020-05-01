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
        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            base.UpdateAccessory(item, player, hideVisual);
            if (item.type == ItemID.Blindfold || item.type == ItemID.AnkhCharm || item.type == ItemID.AnkhShield)
            {
                player.buffImmune[BuffID.Blackout] = true;
            }
            if (item.type == ItemID.ArmorPolish || item.type == ItemID.ArmorBracing || item.type == ItemID.AnkhCharm || item.type == ItemID.AnkhShield)
            {
                player.buffImmune[BuffID.WitheredArmor] = true;
            }
            if (item.type == ItemID.Nazar || item.type == ItemID.CountercurseMantra || item.type == ItemID.AnkhCharm || item.type == ItemID.AnkhShield)
            {
                player.buffImmune[BuffID.WitheredWeapon] = true;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            base.ModifyTooltips(item, tooltips);
            if (item.type == ItemID.Blindfold)
            {
                TooltipLine addTooltip = new TooltipLine(mod, "immunity", "Immunity to Blackout");
                tooltips.Add(addTooltip);
            }
            if (item.type == ItemID.ArmorPolish || item.type == ItemID.ArmorBracing)
            {
                TooltipLine addTooltip = new TooltipLine(mod, "immunity", "Immunity to Withered Armor");
                tooltips.Add(addTooltip);
            }
            if (item.type == ItemID.HandWarmer)
            {
                TooltipLine addTooltip = new TooltipLine(mod, "buffimmunity", "Immunity to Forstburn" +
                    "\nGives the player Warmth");
                tooltips.Add(addTooltip);
            }
        }
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