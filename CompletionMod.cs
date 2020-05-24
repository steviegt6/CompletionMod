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

		public static int InfiniR = 255;
		public static int InfiniB = 0;
		public static int InfiniG = 0;
		public static int InfiniStyle;

		public override void Load()
		{
			Instance = this;

			AddToggle("General", "General", ItemID.Acorn, "6B5D37");
			AddToggle("AutoConvert", "Auto-Convert Boss Summons", ItemID.SuspiciousLookingEye, "FFFFFF");

			AddToggle("Misc", "Miscellaneous", ItemID.SoulofFlight, "42CEE4");
			AddToggle("MaxStack", "Max Stack Increase", ItemID.TallyCounter, "89909B");
		}
		public override void Unload()
		{
			Instance = null;
		}

		public static void DoUpdate_AnimeInfiniRGB()
		{
			int num = 30;
			if (InfiniStyle == 0)
			{
				InfiniR -= num;
				if (InfiniR < 0)
					InfiniR = 0;
				InfiniStyle++;
			}
			if (InfiniStyle == 1)
			{
				InfiniR -= num;
				if (InfiniR < 0)
					InfiniR = 0;
				InfiniStyle++;
			}
			if (InfiniStyle == 2)
			{
				InfiniR -= num;
				if (InfiniR < 0)
					InfiniR = 0;
				InfiniStyle++;
			}
			if (InfiniStyle == 3)
			{
				InfiniR -= num;
				if (InfiniR < 0)
					InfiniR = 0;
				InfiniStyle++;
			}
			if (InfiniStyle == 4)
			{
				InfiniR -= num;
				if (InfiniR < 0)
					InfiniR = 0;
				InfiniStyle++;
			}
			if (InfiniStyle == 5)
			{
				InfiniR -= num;
				if (InfiniR < 0)
					InfiniR = 0;
				InfiniStyle++;
			}
			if (InfiniStyle == 6)
			{
				InfiniR -= num;
				if (InfiniR < 0)
					InfiniR = 0;
				InfiniStyle++;
			}
			if (InfiniStyle == 7)
			{
				InfiniR += num;
				if (InfiniR > 255)
					InfiniR = 255;
				InfiniStyle++;
			}
			if (InfiniStyle == 8)
			{
				InfiniR += num;
				if (InfiniR > 255)
					InfiniR = 255;
				InfiniStyle++;
			}
			if (InfiniStyle == 9)
			{
				InfiniR += num;
				if (InfiniR > 255)
					InfiniR = 255;
				InfiniStyle++;
			}
			if (InfiniStyle == 10)
			{
				InfiniR += num;
				if (InfiniR > 255)
					InfiniR = 255;
				InfiniStyle++;
			}
			if (InfiniStyle == 11)
			{
				InfiniR += num;
				if (InfiniR > 255)
					InfiniR = 255;
				InfiniStyle++;
			}
			if (InfiniStyle == 12)
			{
				InfiniR += num;
				if (InfiniR > 255)
					InfiniR = 255;
				InfiniStyle++;
			}
			if (InfiniStyle == 13)
			{
				InfiniR += num;
				if (InfiniR > 255)
					InfiniR = 255;
				InfiniStyle = 0;
			}
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
		}
		public override void AddRecipes()
		{
			RecipeHelper.addCandyCaneRecipes(this);
			RecipeHelper.addMiscItemRecipes(this);
		}
		public override void AddRecipeGroups()
		{
			base.AddRecipeGroups();
			RecipeGroup group1 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Copper or Tin Bar", new int[]
			{
				ModContent.ItemType<Placeholders.CopperTinBar>(),
				ItemID.CopperBar,
				ItemID.TinBar
			});
			RecipeGroup.RegisterGroup("CompletionMod:CopperTinBar", group1);

			RecipeGroup group2 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Iron or Lead Bar", new int[]
			{
				ModContent.ItemType<Placeholders.IronLeadBar>(),
				ItemID.IronBar,
				ItemID.LeadBar
			});
			RecipeGroup.RegisterGroup("CompletionMod:IronLeadBar", group2);

			RecipeGroup group3 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Silver or Tungsten Bar", new int[]
			{
				ModContent.ItemType<Placeholders.SilverTungstenBar>(),
				ItemID.SilverBar,
				ItemID.TungstenBar
			});
			RecipeGroup.RegisterGroup("CompletionMod:SilverTungstenBar", group3);

			RecipeGroup group4 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Gold or Platinum Bar", new int[]
			{
				ModContent.ItemType<Placeholders.GoldPlatinumBar>(),
				ItemID.GoldBar,
				ItemID.PlatinumBar
			});
			RecipeGroup.RegisterGroup("CompletionMod:GoldPlatinumBar", group4);

			RecipeGroup group5 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Cobalt or Palladium Bar", new int[]
			{
				ModContent.ItemType<Placeholders.CobaltPalladiumBar>(),
				ItemID.CobaltBar,
				ItemID.PalladiumBar
			});
			RecipeGroup.RegisterGroup("CompletionMod:CobaltPalladiumBar", group5);

			RecipeGroup group6 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Mythril or Orichalcum Bar", new int[]
			{
				ModContent.ItemType<Placeholders.MythrilOrichalcumBar>(),
				ItemID.MythrilBar,
				ItemID.OrichalcumBar
			});
			RecipeGroup.RegisterGroup("CompletionMod:MythrilOrichalcumBar", group6);

			RecipeGroup group7 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Adamantite or Titanium Bar", new int[]
			{
				ModContent.ItemType<Placeholders.AdamantiteTitaniumBar>(),
				ItemID.AdamantiteBar,
				ItemID.TitaniumBar
			});
			RecipeGroup.RegisterGroup("CompletionMod:AdamantiteTitaniumBar", group7);
		}
		public CompletionMod()
		{
		}
	}
}