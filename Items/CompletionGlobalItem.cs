using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CompletionMod;
using static Terraria.ModLoader.ModContent;

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
        }
        /*public override void OpenVanillaBag(string context, Player player, int arg)
        {
            base.OpenVanillaBag(context, player, arg);
            switch (arg)
            {
                case ItemID.Present:
                    if (Main.rand.Next(156) == 0)
                    {
                        player.QuickSpawnItem(mod.ItemType("GreenCandyCaneHook"));
                    }
                    else if (Main.rand.Next(159) == 0)
                    {
                        int[] items = { mod.ItemType("GreenCnadyCanePickaxe"), mod.ItemType("GreenCandyCaneSword") };
                        player.QuickSpawnItem(Main.rand.Next(items));
                    }
                    break;
            }
        }*/
    }
}