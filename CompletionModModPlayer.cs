using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CompletionMod
{
	public class CompletionModModPlayer : ModPlayer
	{
		public override void UpdateDead()
		{
			base.UpdateDead();
		}
		public override void ResetEffects()
		{
			base.ResetEffects();
		}
		public override void PreUpdate()
		{
			base.PreUpdate();
			if (player.wet)
			{
				for (int OgreSpitBuff = 0; OgreSpitBuff < Player.MaxBuffs; OgreSpitBuff++)
				{
					if (player.buffType[OgreSpitBuff] == BuffID.OgreSpit)
					{
						player.DelBuff(OgreSpitBuff);
					}
				}
				player.buffImmune[BuffID.OgreSpit] = true;
			}
		}
		public CompletionModModPlayer()
		{
		}
	}
}