using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace CompletionMod.Items
{
    public abstract class UnconsumableItem : ModItem
    {
        public override void SetDefaults()
        {
            item.consumable = false;
        }
        public override bool ConsumeItem(Player player)
        {
            return false;
        }
    }
}
