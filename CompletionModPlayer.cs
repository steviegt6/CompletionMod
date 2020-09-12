using Terraria;
using Terraria.ModLoader;

namespace CompletionMod
{
    public class CompletionModPlayer : ModPlayer
    {
        public override void PreUpdateBuffs()
        {
            while (player.CountBuffs() - ModContent.GetInstance<CompletionModConfigServer>().maximumBuffs > 0)
            {
                int selectedBuff = -1;

                for (int i = 0; i < Player.MaxBuffs; i++)
                {
                    if (player.buffTime[i] > 0)
                    {
                        selectedBuff = i;
                    }
                }

                if (selectedBuff == -1) return;

                player.DelBuff(selectedBuff);
            }
        }
    }
}