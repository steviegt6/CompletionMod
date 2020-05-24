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
			addBars(mod);
		}
		public static void addMiscItemRecipes(Mod mod)
		{
			addHandWarmerRecipe(mod);
		}
		public static void addBars(Mod mod)
		{
			addCopper(mod);
			addTin(mod);
			addIron(mod);
			addLead(mod);
			addSilver(mod);
			addTungsten(mod);
			addGold(mod);
			addPlatinum(mod);
			addCobalt(mod);
			addPalladium(mod);
			addMythril(mod);
			addOrichalcum(mod);
			addAdamantite(mod);
			addTitanium(mod);
		}
		public static void addCopper(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar);
			recipe.SetResult(ItemID.TinBar);
			recipe.AddRecipe();
		}
		public static void addTin(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinBar);
			recipe.SetResult(ItemID.CopperBar);
			recipe.AddRecipe();
		}
		public static void addIron(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar);
			recipe.SetResult(ItemID.LeadBar);
			recipe.AddRecipe();
		}
		public static void addLead(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar);
			recipe.SetResult(ItemID.IronBar);
			recipe.AddRecipe();
		}
		public static void addSilver(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverBar);
			recipe.SetResult(ItemID.TungstenBar);
			recipe.AddRecipe();
		}
		public static void addTungsten(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TungstenBar);
			recipe.SetResult(ItemID.SilverBar);
			recipe.AddRecipe();
		}
		public static void addGold(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar);
			recipe.SetResult(ItemID.PlatinumBar);
			recipe.AddRecipe();
		}
		public static void addPlatinum(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar);
			recipe.SetResult(ItemID.GoldBar);
			recipe.AddRecipe();
		}
		public static void addCobalt(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltBar);
			recipe.SetResult(ItemID.PalladiumBar);
			recipe.AddRecipe();
		}
		public static void addPalladium(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PalladiumBar);
			recipe.SetResult(ItemID.CobaltBar);
			recipe.AddRecipe();
		}
		public static void addMythril(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MythrilBar);
			recipe.SetResult(ItemID.OrichalcumBar);
			recipe.AddRecipe();
		}
		public static void addOrichalcum(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.OrichalcumBar);
			recipe.SetResult(ItemID.MythrilBar);
			recipe.AddRecipe();
		}
		public static void addAdamantite(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AdamantiteBar);
			recipe.SetResult(ItemID.TitaniumBar);
			recipe.AddRecipe();
		}
		public static void addTitanium(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TitaniumBar);
			recipe.SetResult(ItemID.AdamantiteBar);
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