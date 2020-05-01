using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CompletionMod
{
	public class CompletionModModPlayer : ModPlayer
	{
		public bool WaterBottle;
		public override void UpdateDead()
		{
			base.UpdateDead();
			WaterBottle = false;
		}
		public override void ResetEffects()
		{
			base.ResetEffects();
			WaterBottle = false;
		}
		public override void PreUpdate()
		{
			base.PreUpdate();
			if (player.wet || player.honeyWet)
			{
				for (int OgreSpit = 0; OgreSpit < Player.MaxBuffs; OgreSpit++)
				{
					if (player.buffType[OgreSpit] == BuffID.OgreSpit)
					{
						player.DelBuff(OgreSpit);
					}
				}
				player.buffImmune[BuffID.OgreSpit] = true;
			}
			if (player.honeyWet)
			{
				for (int CursedInferno = 0; CursedInferno < Player.MaxBuffs; CursedInferno++)
				{
					if (player.buffType[CursedInferno] == BuffID.CursedInferno)
					{
						player.DelBuff(CursedInferno);
					}
				}
				player.buffImmune[BuffID.CursedInferno] = true;
			}
		}
		public CompletionModModPlayer()
		{
		}
	}
}