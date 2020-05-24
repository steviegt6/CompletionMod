using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using System;
using Terraria.ModLoader.Config;
using System.ComponentModel;

namespace CompletionMod
{
	[Label("Completion Config")]
	public class Config : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ServerSide;

		public static Config Instance;

		public override void OnLoaded()
		{
			Instance = this;
		}

		[Header("$Mods.CompletionMod.General")]
		[Label("$Mods.CompletionMod.AutoConvert")]
		[Tooltip("Enabling this auto-converts summoning items into their 'stackable' counterpart. (Stackable counterparts can be used to summon the same boss multiple times) Disabling this allows you to craft summons into their stackable counterpart and vice-versa.")]
		[ReloadRequired]
		[DefaultValue(true)]
		public bool AutoConvert;
		[Label("$Mods.CompletionMod.RecipeSwitch")]
		[Tooltip("Enabling this replaces various items with recipe groups so you can use that item or the item's variant (i.e. use copper and tin bars instead of just copper).")]
		[ReloadRequired]
		[DefaultValue(true)]
		public bool RecipeSwitch;

		[Header("$Mods.CompletionMod.Misc")]
		[Label("$Mods.CompletionMod.MaxStack")]
		[Tooltip("THIS IS A VERY SIMPLE MAX STACK FEATURE, I WOULD RECOMMEND SWITCHING TO A MOD SUCH AS 'Max Stack Plus Extra' AND DISABLING THIS ONE!")]
		[ReloadRequired]
		[DefaultValue(false)]
		public bool MaxStackEnabled;
	}
}