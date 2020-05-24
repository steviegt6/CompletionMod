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
				ItemType<Placeholders.CopperTinBar>(),
				ItemID.CopperBar,
				ItemID.TinBar
			});
			RecipeGroup.RegisterGroup("CompletionMod:CopperTinBar", group1);

			RecipeGroup group2 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Iron or Lead Bar", new int[]
			{
				ItemType<Placeholders.IronLeadBar>(),
				ItemID.IronBar,
				ItemID.LeadBar
			});
			RecipeGroup.RegisterGroup("CompletionMod:IronLeadBar", group2);

			RecipeGroup group3 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Silver or Tungsten Bar", new int[]
			{
				ItemType<Placeholders.SilverTungstenBar>(),
				ItemID.SilverBar,
				ItemID.TungstenBar
			});
			RecipeGroup.RegisterGroup("CompletionMod:SilverTungstenBar", group3);

			RecipeGroup group4 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Gold or Platinum Bar", new int[]
			{
				ItemType<Placeholders.GoldPlatinumBar>(),
				ItemID.GoldBar,
				ItemID.PlatinumBar
			});
			RecipeGroup.RegisterGroup("CompletionMod:GoldPlatinumBar", group4);

			RecipeGroup group5 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Cobalt or Palladium Bar", new int[]
			{
				ItemType<Placeholders.CobaltPalladiumBar>(),
				ItemID.CobaltBar,
				ItemID.PalladiumBar
			});
			RecipeGroup.RegisterGroup("CompletionMod:CobaltPalladiumBar", group5);

			RecipeGroup group6 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Mythril or Orichalcum Bar", new int[]
			{
				ItemType<Placeholders.MythrilOrichalcumBar>(),
				ItemID.MythrilBar,
				ItemID.OrichalcumBar
			});
			RecipeGroup.RegisterGroup("CompletionMod:MythrilOrichalcumBar", group6);

			RecipeGroup group7 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Adamantite or Titanium Bar", new int[]
			{
				ItemType<Placeholders.AdamantiteTitaniumBar>(),
				ItemID.AdamantiteBar,
				ItemID.TitaniumBar
			});
			RecipeGroup.RegisterGroup("CompletionMod:AdamantiteTitaniumBar", group7);
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
    }
}