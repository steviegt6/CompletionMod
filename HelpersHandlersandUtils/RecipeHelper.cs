using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CompletionMod.HelpersHandlersandUtils
{
    public static class RecipeHelper
    {
		public static void addCandyCaneRecipes(Mod mod)
		{
			addCnadyCanePickaxe(mod);
			addCandyCaneSword(mod);
			addCandyCaneHook(mod);
		}
		public static void addMiscItemRecipes(Mod mod)
		{
			addHandWarmerRecipe(mod);
			addCorruptionCrimsonCounterparts(mod);
			addBars(mod);
		}
		public static void addCorruptionCrimsonCounterparts(Mod mod)
		{
			addVariationSwap(mod, ItemID.RottenChunk, ItemID.Vertebrae, 1);
			addVariationSwap(mod, ItemID.Vertebrae, ItemID.RottenChunk, 1);
			addVariationSwap(mod, ItemID.ShadowScale, ItemID.TissueSample, 1);
			addVariationSwap(mod, ItemID.TissueSample, ItemID.ShadowScale, 1);
			addVariationSwap(mod, ItemID.Musket, ItemID.TheUndertaker, 1);
			addVariationSwap(mod, ItemID.TheUndertaker, ItemID.Musket, 1);
			addVariationSwap(mod, ItemID.BandofStarpower, ItemID.PanicNecklace, 1);
			addVariationSwap(mod, ItemID.PanicNecklace, ItemID.BandofStarpower, 1);
			addVariationSwap(mod, ItemID.BallOHurt, ItemID.TheRottedFork, 1);
			addVariationSwap(mod, ItemID.TheRottedFork, ItemID.BallOHurt, 1);
			addVariationSwap(mod, ItemID.Vilethorn, ItemID.CrimsonRod, 1);
			addVariationSwap(mod, ItemID.CrimsonRod, ItemID.Vilethorn, 1);
			addVariationSwap(mod, ItemID.ShadowOrb, ItemID.CrimsonHeart, 1);
			addVariationSwap(mod, ItemID.CrimsonHeart, ItemID.ShadowOrb, 1);
			addVariationSwap(mod, ItemID.VileMushroom, ItemID.ViciousMushroom, 1);
			addVariationSwap(mod, ItemID.ViciousMushroom, ItemID.VileMushroom, 1);
			addVariationSwap(mod, ItemID.Ebonwood, ItemID.Shadewood, 1);
			addVariationSwap(mod, ItemID.Shadewood, ItemID.Ebonwood, 1);
			addVariationSwap(mod, ItemID.EbonstoneBlock, ItemID.CrimstoneBlock, 1);
			addVariationSwap(mod, ItemID.CrimstoneBlock, ItemID.EbonstoneBlock, 1);
			addVariationSwap(mod, ItemID.EbonsandBlock, ItemID.CrimsandBlock, 1);
			addVariationSwap(mod, ItemID.CrimsandBlock, ItemID.EbonsandBlock, 1);
			addVariationSwap(mod, ItemID.PurpleIceBlock, ItemID.RedIceBlock, 1);
			addVariationSwap(mod, ItemID.RedIceBlock, ItemID.PurpleIceBlock, 1);
			addVariationSwap(mod, ItemID.CorruptFishingCrate, ItemID.CrimsonFishingCrate, 1);
			addVariationSwap(mod, ItemID.CrimsonFishingCrate, ItemID.CorruptFishingCrate, 1);
			addVariationSwap(mod, ItemID.CrimsonTigerfish, ItemID.Ebonkoi, 1);
			addVariationSwap(mod, ItemID.Hemopiranha, ItemID.Ebonkoi, 1);
			addVariationSwap(mod, ItemID.Ebonkoi, ItemID.CrimsonTigerfish, 1);
			addVariationSwap(mod, ItemID.Ebonkoi, ItemID.Hemopiranha, 1);
			addVariationSwap(mod, ItemID.CursedFlame, ItemID.Ichor, 1);
			addVariationSwap(mod, ItemID.Ichor, ItemID.CursedFlame, 1);
			addVariationSwap(mod, ItemID.DartRifle, ItemID.DartPistol, 1);
			addVariationSwap(mod, ItemID.DartPistol, ItemID.DartRifle, 1);
			addVariationSwap(mod, ItemID.WormHook, ItemID.TendonHook, 1);
			addVariationSwap(mod, ItemID.TendonHook, ItemID.WormHook, 1);
			addVariationSwap(mod, ItemID.ClingerStaff, ItemID.SoulDrain, 1);
			addVariationSwap(mod, ItemID.SoulDrain, ItemID.ClingerStaff, 1);
			addVariationSwap(mod, ItemID.PutridScent, ItemID.FleshKnuckles, 1);
			addVariationSwap(mod, ItemID.FleshKnuckles, ItemID.PutridScent, 1);
			addVariationSwap(mod, ItemID.ChainGuillotines, ItemID.FetidBaghnakhs, 1);
			addVariationSwap(mod, ItemID.FetidBaghnakhs, ItemID.ChainGuillotines, 1);
			addVariationSwap(mod, ItemID.CorruptionKey, ItemID.CrimsonKey, 1);
			addVariationSwap(mod, ItemID.CrimsonKey, ItemID.CorruptionKey, 1);
		}
		public static void addBars(Mod mod)
		{
			addVariationSwap(mod, ItemID.CopperBar, ItemID.TinBar, 1);
			addVariationSwap(mod, ItemID.TinBar, ItemID.CopperBar, 1);
			addVariationSwap(mod, ItemID.IronBar, ItemID.LeadBar, 1);
			addVariationSwap(mod, ItemID.LeadBar, ItemID.IronBar, 1);
			addVariationSwap(mod, ItemID.SilverBar, ItemID.TungstenBar, 1);
			addVariationSwap(mod, ItemID.TungstenBar, ItemID.SilverBar, 1);
			addVariationSwap(mod, ItemID.GoldBar, ItemID.TungstenBar, 1);
			addVariationSwap(mod, ItemID.TungstenBar, ItemID.GoldBar, 1);
			addVariationSwap(mod, ItemID.DemoniteBar, ItemID.DemoniteBar, 1);
			addVariationSwap(mod, ItemID.CrimtaneBar, ItemID.CrimtaneBar, 1);
			addVariationSwap(mod, ItemID.CobaltBar, ItemID.PalladiumBar, 1);
			addVariationSwap(mod, ItemID.PalladiumBar, ItemID.CobaltBar, 1);
			addVariationSwap(mod, ItemID.MythrilBar, ItemID.OrichalcumBar, 1);
			addVariationSwap(mod, ItemID.OrichalcumBar, ItemID.MythrilBar, 1);
			addVariationSwap(mod, ItemID.AdamantiteBar, ItemID.TitaniumBar, 1);
			addVariationSwap(mod, ItemID.TitaniumBar, ItemID.AdamantiteBar, 1);
		}
		public static void addVariationSwap(Mod mod, short ingredient, short result, int iStack = 1, int rStack = 1, string reqTile = null)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ingredient, iStack);
			if (reqTile != null)
				recipe.AddTile(null, reqTile);
			recipe.SetResult(result, rStack);
			recipe.AddRecipe();
		}
		public static void addHandWarmerRecipe(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.HandWarmer);
			recipe.AddRecipe();
		}
		public static void addCnadyCanePickaxe(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CandyCaneBlock, 35);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.CnadyCanePickaxe);
			recipe.AddRecipe();
		}
		public static void addCandyCaneSword(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CandyCaneBlock, 50);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.CandyCaneSword);
			recipe.AddRecipe();
		}
		public static void addCandyCaneHook(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CandyCaneBlock, 85);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.CandyCaneHook);
			recipe.AddRecipe();
		}
		public static void AddCompletionRecipeGroups()
		{
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

			RecipeGroup group8 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Demonite or Crimtane Bar", new int[]
{
				ModContent.ItemType<Placeholders.DemoniteCrimtaneBar>(),
				ItemID.DemoniteBar,
				ItemID.CrimtaneBar
});
			RecipeGroup.RegisterGroup("CompletionMod:GoldPlatinumBar", group8);

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

			RecipeGroup group9 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Rotten Chunk or Vertebrae", new int[]
			{
				ItemID.RottenChunk,
				ItemID.Vertebrae
			});
			RecipeGroup.RegisterGroup("CompletionMod:AdamantiteTitaniumBar", group9);
		}
		public static void SummonReplacements(Mod mod)
        {
			if (Config.Instance.AutoConvert)
			{
				RecipeFinder finder = new RecipeFinder();
				finder.AddIngredient(ItemID.GuideVoodooDoll);

				foreach (Recipe recipe in finder.SearchRecipes())
				{
					RecipeEditor editor = new RecipeEditor(recipe);
					editor.DeleteIngredient(ItemID.GuideVoodooDoll);
					editor.AddIngredient(mod.ItemType("ImprovedGuideVoodooDoll"));
				}

				finder = new RecipeFinder();
				finder.SetResult(ItemID.GuideVoodooDoll);

				foreach (Recipe recipe in finder.SearchRecipes())
				{
					RecipeEditor editor = new RecipeEditor(recipe);
					editor.SetResult(mod.ItemType("ImprovedGuideVoodooDoll"));
				}

				finder = new RecipeFinder();
				finder.AddIngredient(ItemID.ClothierVoodooDoll);

				foreach (Recipe recipe in finder.SearchRecipes())
				{
					RecipeEditor editor = new RecipeEditor(recipe);
					editor.DeleteIngredient(ItemID.ClothierVoodooDoll);
					editor.AddIngredient(mod.ItemType("ImprovedClothierVoodooDoll"));
				}

				finder = new RecipeFinder();
				finder.SetResult(ItemID.ClothierVoodooDoll);

				foreach (Recipe recipe in finder.SearchRecipes())
				{
					RecipeEditor editor = new RecipeEditor(recipe);
					editor.SetResult(mod.ItemType("ImprovedClothierVoodooDoll"));
				}
			}
		}
		public static void SwitchRecipes(Mod mod)
		{
			if (Config.Instance.RecipeSwitch)
			{
				RecipeFinder finder = new RecipeFinder();
				finder.AddIngredient(ItemID.CopperBar);

				foreach (Recipe recipe in finder.SearchRecipes())
				{
					RecipeEditor editor = new RecipeEditor(recipe);
					editor.AcceptRecipeGroup("CompletionMod:CopperTinBar");
				}

				finder = new RecipeFinder();
				finder.AddIngredient(ItemID.TinBar);

				foreach (Recipe recipe in finder.SearchRecipes())
				{
					RecipeEditor editor = new RecipeEditor(recipe);
					editor.AcceptRecipeGroup("CompletionMod:CopperTinBar");
				}

				finder = new RecipeFinder();
				finder.AddIngredient(ItemID.IronBar);

				foreach (Recipe recipe in finder.SearchRecipes())
				{
					RecipeEditor editor = new RecipeEditor(recipe);
					editor.AcceptRecipeGroup("CompletionMod:IronLeadBar");
				}

				finder = new RecipeFinder();
				finder.AddIngredient(ItemID.LeadBar);

				foreach (Recipe recipe in finder.SearchRecipes())
				{
					RecipeEditor editor = new RecipeEditor(recipe);
					editor.AcceptRecipeGroup("CompletionMod:IronLeadBar");
				}

				finder = new RecipeFinder();
				finder.AddIngredient(ItemID.SilverBar);

				foreach (Recipe recipe in finder.SearchRecipes())
				{
					RecipeEditor editor = new RecipeEditor(recipe);
					editor.AcceptRecipeGroup("CompletionMod:SilverTungstenBar");
				}

				finder = new RecipeFinder();
				finder.AddIngredient(ItemID.TungstenBar);

				foreach (Recipe recipe in finder.SearchRecipes())
				{
					RecipeEditor editor = new RecipeEditor(recipe);
					editor.AcceptRecipeGroup("CompletionMod:SilverTungstenBar");
				}

				finder = new RecipeFinder();
				finder.AddIngredient(ItemID.GoldBar);

				foreach (Recipe recipe in finder.SearchRecipes())
				{
					RecipeEditor editor = new RecipeEditor(recipe);
					editor.AcceptRecipeGroup("CompletionMod:GoldPlatinumBar");
				}

				finder = new RecipeFinder();
				finder.AddIngredient(ItemID.PlatinumBar);

				foreach (Recipe recipe in finder.SearchRecipes())
				{
					RecipeEditor editor = new RecipeEditor(recipe);
					editor.AcceptRecipeGroup("CompletionMod:GoldPlatinumBar");
				}

				finder = new RecipeFinder();
				finder.AddIngredient(ItemID.DemoniteBar);

				foreach (Recipe recipe in finder.SearchRecipes())
				{
					RecipeEditor editor = new RecipeEditor(recipe);
					editor.AcceptRecipeGroup("CompletionMod:DemoniteCrimtaneBar");
				}

				finder = new RecipeFinder();
				finder.AddIngredient(ItemID.CrimtaneBar);

				foreach (Recipe recipe in finder.SearchRecipes())
				{
					RecipeEditor editor = new RecipeEditor(recipe);
					editor.AcceptRecipeGroup("CompletionMod:DemoniteCrimtaneBar");
				}

				finder = new RecipeFinder();
				finder.AddIngredient(ItemID.CobaltBar);

				foreach (Recipe recipe in finder.SearchRecipes())
				{
					RecipeEditor editor = new RecipeEditor(recipe);
					editor.AcceptRecipeGroup("CompletionMod:CobaltPalladiumBar");
				}

				finder = new RecipeFinder();
				finder.AddIngredient(ItemID.PalladiumBar);

				foreach (Recipe recipe in finder.SearchRecipes())
				{
					RecipeEditor editor = new RecipeEditor(recipe);
					editor.AcceptRecipeGroup("CompletionMod:CobaltPalladiumBar");
				}

				finder = new RecipeFinder();
				finder.AddIngredient(ItemID.MythrilBar);

				foreach (Recipe recipe in finder.SearchRecipes())
				{
					RecipeEditor editor = new RecipeEditor(recipe);
					editor.AcceptRecipeGroup("CompletionMod:MythrilOrichalcumBar");
				}

				finder = new RecipeFinder();
				finder.AddIngredient(ItemID.OrichalcumBar);

				foreach (Recipe recipe in finder.SearchRecipes())
				{
					RecipeEditor editor = new RecipeEditor(recipe);
					editor.AcceptRecipeGroup("CompletionMod:MythrilOrichalcumBar");
				}

				finder = new RecipeFinder();
				finder.AddIngredient(ItemID.AdamantiteBar);

				foreach (Recipe recipe in finder.SearchRecipes())
				{
					RecipeEditor editor = new RecipeEditor(recipe);
					editor.AcceptRecipeGroup("CompletionMod:AdamantiteTitaniumBar");
				}

				finder = new RecipeFinder();
				finder.AddIngredient(ItemID.TitaniumBar);

				foreach (Recipe recipe in finder.SearchRecipes())
				{
					RecipeEditor editor = new RecipeEditor(recipe);
					editor.AcceptRecipeGroup("CompletionMod:AdamantiteTitaniumBar");
				}
			}
		}
    }
}