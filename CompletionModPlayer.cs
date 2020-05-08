using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CompletionMod
{
	public class CompletionModPlayer : ModPlayer
	{
		public bool waterBottle;
		public bool handWarmer;
		public override void UpdateDead()
		{
			base.UpdateDead();
			waterBottle = false;
			handWarmer = false;
		}
		public override void ResetEffects()
		{
			base.ResetEffects();
			waterBottle = false;
			handWarmer = false;
		}
		public override void UpdateEquips(ref bool wallSpeedBuff, ref bool tileSpeedBuff, ref bool tileRangeBuff)
		{
			base.UpdateEquips(ref wallSpeedBuff, ref tileSpeedBuff, ref tileRangeBuff);
		}
		public override void PreUpdate()
		{
			base.PreUpdate();
			if (player.buffImmune[46] && player.buffImmune[47])
				handWarmer = true;
			if (handWarmer)
			{
				player.AddBuff(BuffID.Warmth, 0, true);
			}
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
	}
}