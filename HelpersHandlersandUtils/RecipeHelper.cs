using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CompletionMod.HelpersHandlersandUtils
{
    public static class RecipeHelper
    {
		public static void AddCompletionRecipes(Mod mod)
		{
			AddCandyCaneRecipes(mod);
			AddMiscItemRecipes(mod);
			AddUncraftables(mod);
		}
		public static void AddUncraftables(Mod mod)
		{
			AddMandibleBlade(mod);
			AddBladedGlove(mod);
			AddRuler(mod);
			AddBreathingReed(mod);
			AddBoneSword(mod);
			AddKatana(mod);
			AddIceBladeTungsten(mod);
			AddIceBladeSilver(mod);
			AddDungeonItems(mod);
			AddArkhalis(mod);
			AddExoticScimitar(mod);
			AddStarfuryGold(mod);
			AddStarfuryPlatinum(mod);
			AddFalconBlade(mod);
			AddIceSickle(mod);
			AddFrostbrand(mod);
			AddBeamSword(mod);
		}
		public static void AddCandyCaneRecipes(Mod mod)
		{
			AddCnadyCanePickaxe(mod);
			AddCandyCaneSword(mod);
			AddCandyCaneHook(mod);
		}
		public static void AddMiscItemRecipes(Mod mod)
		{
			AddHandWarmerRecipe(mod);
			AddCorruptionCrimsonCounterparts(mod);
			AddBars(mod);
		}
		public static void AddCorruptionCrimsonCounterparts(Mod mod)
		{
			AddVariationSwap(mod, ItemID.RottenChunk, ItemID.Vertebrae, 1);
			AddVariationSwap(mod, ItemID.Vertebrae, ItemID.RottenChunk, 1);
			AddVariationSwap(mod, ItemID.ShadowScale, ItemID.TissueSample, 1);
			AddVariationSwap(mod, ItemID.TissueSample, ItemID.ShadowScale, 1);
			AddVariationSwap(mod, ItemID.Musket, ItemID.TheUndertaker, 1);
			AddVariationSwap(mod, ItemID.TheUndertaker, ItemID.Musket, 1);
			AddVariationSwap(mod, ItemID.BandofStarpower, ItemID.PanicNecklace, 1);
			AddVariationSwap(mod, ItemID.PanicNecklace, ItemID.BandofStarpower, 1);
			AddVariationSwap(mod, ItemID.BallOHurt, ItemID.TheRottedFork, 1);
			AddVariationSwap(mod, ItemID.TheRottedFork, ItemID.BallOHurt, 1);
			AddVariationSwap(mod, ItemID.Vilethorn, ItemID.CrimsonRod, 1);
			AddVariationSwap(mod, ItemID.CrimsonRod, ItemID.Vilethorn, 1);
			AddVariationSwap(mod, ItemID.ShadowOrb, ItemID.CrimsonHeart, 1);
			AddVariationSwap(mod, ItemID.CrimsonHeart, ItemID.ShadowOrb, 1);
			AddVariationSwap(mod, ItemID.VileMushroom, ItemID.ViciousMushroom, 1);
			AddVariationSwap(mod, ItemID.ViciousMushroom, ItemID.VileMushroom, 1);
			AddVariationSwap(mod, ItemID.Ebonwood, ItemID.Shadewood, 1);
			AddVariationSwap(mod, ItemID.Shadewood, ItemID.Ebonwood, 1);
			AddVariationSwap(mod, ItemID.EbonstoneBlock, ItemID.CrimstoneBlock, 1);
			AddVariationSwap(mod, ItemID.CrimstoneBlock, ItemID.EbonstoneBlock, 1);
			AddVariationSwap(mod, ItemID.EbonsandBlock, ItemID.CrimsandBlock, 1);
			AddVariationSwap(mod, ItemID.CrimsandBlock, ItemID.EbonsandBlock, 1);
			AddVariationSwap(mod, ItemID.PurpleIceBlock, ItemID.RedIceBlock, 1);
			AddVariationSwap(mod, ItemID.RedIceBlock, ItemID.PurpleIceBlock, 1);
			AddVariationSwap(mod, ItemID.CorruptFishingCrate, ItemID.CrimsonFishingCrate, 1);
			AddVariationSwap(mod, ItemID.CrimsonFishingCrate, ItemID.CorruptFishingCrate, 1);
			AddVariationSwap(mod, ItemID.CrimsonTigerfish, ItemID.Ebonkoi, 1);
			AddVariationSwap(mod, ItemID.Hemopiranha, ItemID.Ebonkoi, 1);
			AddVariationSwap(mod, ItemID.Ebonkoi, ItemID.CrimsonTigerfish, 1);
			AddVariationSwap(mod, ItemID.Ebonkoi, ItemID.Hemopiranha, 1);
			AddVariationSwap(mod, ItemID.CursedFlame, ItemID.Ichor, 1);
			AddVariationSwap(mod, ItemID.Ichor, ItemID.CursedFlame, 1);
			AddVariationSwap(mod, ItemID.DartRifle, ItemID.DartPistol, 1);
			AddVariationSwap(mod, ItemID.DartPistol, ItemID.DartRifle, 1);
			AddVariationSwap(mod, ItemID.WormHook, ItemID.TendonHook, 1);
			AddVariationSwap(mod, ItemID.TendonHook, ItemID.WormHook, 1);
			AddVariationSwap(mod, ItemID.ClingerStaff, ItemID.SoulDrain, 1);
			AddVariationSwap(mod, ItemID.SoulDrain, ItemID.ClingerStaff, 1);
			AddVariationSwap(mod, ItemID.PutridScent, ItemID.FleshKnuckles, 1);
			AddVariationSwap(mod, ItemID.FleshKnuckles, ItemID.PutridScent, 1);
			AddVariationSwap(mod, ItemID.ChainGuillotines, ItemID.FetidBaghnakhs, 1);
			AddVariationSwap(mod, ItemID.FetidBaghnakhs, ItemID.ChainGuillotines, 1);
			AddVariationSwap(mod, ItemID.CorruptionKey, ItemID.CrimsonKey, 1);
			AddVariationSwap(mod, ItemID.CrimsonKey, ItemID.CorruptionKey, 1);
		}
		public static void AddBars(Mod mod)
		{
			AddVariationSwap(mod, ItemID.CopperBar, ItemID.TinBar, 1);
			AddVariationSwap(mod, ItemID.TinBar, ItemID.CopperBar, 1);
			AddVariationSwap(mod, ItemID.IronBar, ItemID.LeadBar, 1);
			AddVariationSwap(mod, ItemID.LeadBar, ItemID.IronBar, 1);
			AddVariationSwap(mod, ItemID.SilverBar, ItemID.TungstenBar, 1);
			AddVariationSwap(mod, ItemID.TungstenBar, ItemID.SilverBar, 1);
			AddVariationSwap(mod, ItemID.GoldBar, ItemID.TungstenBar, 1);
			AddVariationSwap(mod, ItemID.TungstenBar, ItemID.GoldBar, 1);
			AddVariationSwap(mod, ItemID.DemoniteBar, ItemID.DemoniteBar, 1);
			AddVariationSwap(mod, ItemID.CrimtaneBar, ItemID.CrimtaneBar, 1);
			AddVariationSwap(mod, ItemID.CobaltBar, ItemID.PalladiumBar, 1);
			AddVariationSwap(mod, ItemID.PalladiumBar, ItemID.CobaltBar, 1);
			AddVariationSwap(mod, ItemID.MythrilBar, ItemID.OrichalcumBar, 1);
			AddVariationSwap(mod, ItemID.OrichalcumBar, ItemID.MythrilBar, 1);
			AddVariationSwap(mod, ItemID.AdamantiteBar, ItemID.TitaniumBar, 1);
			AddVariationSwap(mod, ItemID.TitaniumBar, ItemID.AdamantiteBar, 1);
		}
		public static void AddDungeonItems(Mod mod)
		{
			AddChestSwap(mod, ItemID.GoldenKey, ItemID.LockBox, ItemID.MagicMissile, 1);
			AddChestSwap(mod, ItemID.GoldenKey, ItemID.LockBox, ItemID.Muramasa, 1);
			AddChestSwap(mod, ItemID.GoldenKey, ItemID.LockBox, ItemID.CobaltShield, 1);
			AddChestSwap(mod, ItemID.GoldenKey, ItemID.LockBox, ItemID.AquaScepter, 1);
			AddChestSwap(mod, ItemID.GoldenKey, ItemID.LockBox, ItemID.BlueMoon, 1);
			AddChestSwap(mod, ItemID.GoldenKey, ItemID.LockBox, ItemID.Handgun, 1);
			AddChestSwap(mod, ItemID.GoldenKey, ItemID.LockBox, ItemID.ShadowKey, 1);
		}
		public static void AddVariationSwap(Mod mod, short ingredient, short result, int iStack = 1, int rStack = 1, string reqTile = null)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ingredient, iStack);
			if (reqTile != null)
				recipe.AddTile(null, reqTile);
			recipe.SetResult(result, rStack);
			recipe.AddRecipe();
		}
		public static void AddChestSwap(Mod mod, short ingredient1, short ingredient2, short result, int iStack1 = 1, int iStack2 = 1, int rStack = 1, string reqTile = null)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ingredient1, iStack1);
			recipe.AddIngredient(ingredient2, iStack2);
			if (reqTile != null)
				recipe.AddTile(null, reqTile);
			recipe.SetResult(result, rStack);
			recipe.AddRecipe();
		}
		public static void AddBeamSword(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("CompletionMod:CobaltPalladiumBar", 6);
			recipe.AddIngredient(ItemID.EnchantedSword);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.BeamSword);
			recipe.AddRecipe();
		}
		public static void AddFrostbrand(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("CompletionMod:CobaltPalladiumBar", 10);
			recipe.AddIngredient(ItemID.IceBlade);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.Frostbrand);
			recipe.AddRecipe();
		}
		public static void AddIceSickle(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("CompletionMod:CobaltPalladiumBar", 8);
			recipe.AddIngredient(ItemID.IceBlade);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.IceSickle);
			recipe.AddRecipe();
		}
		public static void AddFalconBlade(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("CompletionMod:IronLeadBar", 14);
			recipe.AddRecipeGroup(RecipeGroupID.Wood, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.FalconBlade);
			recipe.AddRecipe();
		}
		public static void AddStarfuryGold(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SunplateBlock, 40);
			recipe.AddIngredient(ItemID.FallenStar, 5);
			recipe.AddIngredient(ItemID.GoldBroadsword);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Starfury);
			recipe.AddRecipe();
		}
		public static void AddStarfuryPlatinum(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SunplateBlock, 40);
			recipe.AddIngredient(ItemID.FallenStar, 5);
			recipe.AddIngredient(ItemID.PlatinumBroadsword);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Starfury);
			recipe.AddRecipe();
		}
		public static void AddExoticScimitar(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("CompletionMod:SilverTungstenBar", 12);
			recipe.AddRecipeGroup(RecipeGroupID.Wood, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.DyeTradersScimitar);
			recipe.AddRecipe();
		}
		public static void AddArkhalis(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.EnchantedSword, 2);
			recipe.AddIngredient(ItemID.IceBlock, 30);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.IceBlade);
			recipe.AddRecipe();
		}
		public static void AddIceBladeTungsten(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TungstenBroadsword, 1);
			recipe.AddRecipeGroup("CompletionMod:GoldPlatinumBar", 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Arkhalis);
			recipe.AddRecipe();
		}
		public static void AddIceBladeSilver(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverBroadsword, 1);
			recipe.AddIngredient(ItemID.IceBlock, 30);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.IceBlade);
			recipe.AddRecipe();
		}
		public static void AddKatana(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("CompletionMod:SilverTungstenBar", 12);
			recipe.AddRecipeGroup("CompletionMod:GoldPlatinumBar", 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Katana);
			recipe.AddRecipe();
		}
		public static void AddBoneSword(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bone, 35);
			recipe.AddRecipeGroup(RecipeGroupID.Wood, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BoneSword);
			recipe.AddRecipe();
		}
		public static void AddBreathingReed(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup(RecipeGroupID.Wood, 30);
			recipe.AddTile(TileID.Sawmill);
			recipe.SetResult(ItemID.BreathingReed);
			recipe.AddRecipe();
		}
		public static void AddRuler(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup(RecipeGroupID.Wood, 25);
			recipe.AddTile(TileID.Sawmill);
			recipe.SetResult(ItemID.Ruler);
			recipe.AddRecipe();
		}
		public static void AddMandibleBlade(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AntlionMandible, 7);
			recipe.AddIngredient(ItemID.FossilOre, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.AntlionClaw);
			recipe.AddRecipe();
		}
		public static void AddBladedGlove(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Leather, 5);
			recipe.AddIngredient(ItemID.ThrowingKnife, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.AntlionClaw);
			recipe.AddRecipe();
		}
		public static void AddHandWarmerRecipe(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.HandWarmer);
			recipe.AddRecipe();
		}
		public static void AddCnadyCanePickaxe(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CandyCaneBlock, 35);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.CnadyCanePickaxe);
			recipe.AddRecipe();
		}
		public static void AddCandyCaneSword(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CandyCaneBlock, 50);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.CandyCaneSword);
			recipe.AddRecipe();
		}
		public static void AddCandyCaneHook(Mod mod)
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
			RecipeGroup.RegisterGroup("CompletionMod:DemoniteCrimtaneBar", group8);

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
		public static void SwitchRecipes(/*Mod mod*/)
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