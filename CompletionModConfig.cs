using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using System;
using Terraria.ModLoader.Config;
using System.ComponentModel;

namespace CompletionMod
{
	public class Config : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ServerSide;

		public static Config Instance;

		public override void OnLoaded()
		{
			Instance = this;
		}

		[Header("$Mods.CompletionMod.Misc")]
		[Label("$Mods.CompletionMod.MaxStack")]
		[Tooltip("THIS IS A VERY SIMPLE MAX STACK FEATURE, I WOULD RECOMMEND SWITCHING TO A MOD SUCH AS 'Max Stack Plus Extra' AND DISABLING THIS ONE!")]
		[ReloadRequired]
		[DefaultValue(true)]
		public bool MaxStackEnabled;
	}
}