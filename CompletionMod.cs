using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using System;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using CompletionMod.HelpersHandlersandUtils;
using Microsoft.Xna.Framework;

namespace CompletionMod
{
	public class CompletionMod : Mod
	{
		internal static CompletionMod Instance;

		public override void Load()
		{
			Instance = this;

			AddToggle("General", "General", ItemID.Acorn, "6B5D37");
			AddToggle("AutoConvert", "Auto-Convert Boss Summons", ItemID.SuspiciousLookingEye, "FFFFFF");
			AddToggle("RecipeSwitch", "Add Extra Recipe Groups", ItemID.SoulofFlight, "42CEE4");
			AddToggle("PotionsNeeded", "Potion Stack Needed", ItemID.TallyCounter, "89909B");
			AddToggle("InfPotionsEnabled", "Get Potion Buff when You Have " + Config.Instance.potionsNeeded + "+ Potions", ItemID.RestorationPotion, "F965BD");
			AddToggle("ThrowingNeeded", "Throwing Item Stack Needed", ItemID.TallyCounter, "89909B");
			AddToggle("InfThrowingEnabled", "Infinite throwing items when you have " + Config.Instance.throwingNeeded + "+ of an Item", ItemID.StarAnise, "CB8F54");

			AddToggle("Misc", "Miscellaneous", ItemID.SoulofMight, "4BABFF");
			AddToggle("MaxStack", "Max Stack Increase", ItemID.TallyCounter, "89909B");
		}
		public override void Unload()
		{
			Instance = null;
		}

	// -- AddToggle Code taken from Fargo's Soul Mod (FargowiltasSouls)! All credit goes to Fargo & other contributors!

	//For modded items
	public void AddToggle(String toggle, String name, String item, String color)
		{
			ModTranslation text = CreateTranslation(toggle);
			text.SetDefault("[i:" + Instance.ItemType(item) + "][c/" + color + ": " + name + "]");
			AddTranslation(text);
		}

		//For Vanilla items
		public void AddToggle(String toggle, String name, int item, String color)
		{
			ModTranslation text = CreateTranslation(toggle);
			text.SetDefault("[i:" + item + "][c/" + color + ": " + name + "]");
			AddTranslation(text);
		}
		public override void PostAddRecipes()
		{
			RecipeHelper.SummonReplacements(this);
			RecipeHelper.SwitchRecipes(/*this*/);
		}
		public override void AddRecipes()
		{
			RecipeHelper.AddCompletionRecipes(this);
		}
		public override void AddRecipeGroups()
		{
			RecipeHelper.AddCompletionRecipeGroups();
		}
		public CompletionMod()
		{
		}
	}
}