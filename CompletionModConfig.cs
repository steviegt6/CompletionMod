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
		[Tooltip("Enabling this auto-converts summoning items into their 'stackable' counterpart." +
			"\n(Stackable counterparts can be used to summon the same boss multiple times)" +
			"\nDisabling this allows you to craft summons into their stackable counterpart and vice-versa.")]
		[ReloadRequired]
		[DefaultValue(true)]
		public bool AutoConvert;
		[Label("$Mods.CompletionMod.RecipeSwitch")]
		[Tooltip("Enabling this replaces various items with recipe groups so you can use that item or the item's variant." +
			"\n(i.e. use copper and tin bars instead of just copper)")]
		[ReloadRequired]
		[DefaultValue(true)]
		public bool RecipeSwitch;

		[Header("$Mods.CompletionMod.Potions")]
		[Label("$Mods.CompletionMod.InfPotionsEnabled")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool infPotions;
		[Label("$Mods.CompletionMod.PotionsNeeded")]
		[DefaultValue(30)]
		[Range(1, 60)]
		[ReloadRequired]
		public int potionsNeeded;

		[Header("$Mods.CompletionMod.Misc")]
		[Label("$Mods.CompletionMod.MaxStack")]
		[Tooltip("I would recommend using Max Stack Plus Extra instead.")]
		[ReloadRequired]
		[DefaultValue(false)]
		public bool MaxStackEnabled;
	}
}