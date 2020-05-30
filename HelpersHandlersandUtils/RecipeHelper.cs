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
			AddRally(mod);
			AddCascade(mod);
			AddYelets(mod);
			AddHelFire(mod);
			AddSpear(mod);
			AddTrident(mod);
			AddBoomerang(mod);
			AddEnchantedBoomerang(mod);
			AddIceBoomerang(mod);
			AddChainKnife(mod);
			AddChainGuillotines(mod);
			AddMarrow(mod);
			AddBlowpipe(mod);
			AddFlareGun(mod);
			AddSlimeStaff(mod);
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
			AddVariationSwap(mod, ItemID.RottenChunk, ItemID.Vertebrae, true);
			AddVariationSwap(mod, ItemID.ShadowScale, ItemID.TissueSample, true);
			AddVariationSwap(mod, ItemID.Musket, ItemID.TheUndertaker, true);
			AddVariationSwap(mod, ItemID.BandofStarpower, ItemID.PanicNecklace, true);
			AddVariationSwap(mod, ItemID.BallOHurt, ItemID.TheRottedFork, true);
			AddVariationSwap(mod, ItemID.Vilethorn, ItemID.CrimsonRod, true);
			AddVariationSwap(mod, ItemID.ShadowOrb, ItemID.CrimsonHeart, true);
			AddVariationSwap(mod, ItemID.VileMushroom, ItemID.ViciousMushroom, true);
			AddVariationSwap(mod, ItemID.Ebonwood, ItemID.Shadewood, true);
			AddVariationSwap(mod, ItemID.EbonstoneBlock, ItemID.CrimstoneBlock, true);
			AddVariationSwap(mod, ItemID.EbonsandBlock, ItemID.CrimsandBlock, true);
			AddVariationSwap(mod, ItemID.PurpleIceBlock, ItemID.RedIceBlock, true);
			AddVariationSwap(mod, ItemID.CorruptFishingCrate, ItemID.CrimsonFishingCrate, true);
			AddVariationSwap(mod, ItemID.CrimsonTigerfish, ItemID.Ebonkoi, true);
			AddVariationSwap(mod, ItemID.Hemopiranha, ItemID.Ebonkoi, true);
			AddVariationSwap(mod, ItemID.CursedFlame, ItemID.Ichor, true);
			AddVariationSwap(mod, ItemID.DartRifle, ItemID.DartPistol, true);
			AddVariationSwap(mod, ItemID.WormHook, ItemID.TendonHook, true);
			AddVariationSwap(mod, ItemID.ClingerStaff, ItemID.SoulDrain, true);
			AddVariationSwap(mod, ItemID.PutridScent, ItemID.FleshKnuckles, true);
			AddVariationSwap(mod, ItemID.ChainGuillotines, ItemID.FetidBaghnakhs, true);
			AddVariationSwap(mod, ItemID.CorruptionKey, ItemID.CrimsonKey, true);
		}
		public static void AddBars(Mod mod)
		{
			AddVariationSwap(mod, ItemID.CopperBar, ItemID.TinBar, true);
			AddVariationSwap(mod, ItemID.IronBar, ItemID.LeadBar, true);
			AddVariationSwap(mod, ItemID.SilverBar, ItemID.TungstenBar, true);
			AddVariationSwap(mod, ItemID.GoldBar, ItemID.TungstenBar, true);
			AddVariationSwap(mod, ItemID.DemoniteBar, ItemID.DemoniteBar, true);
			AddVariationSwap(mod, ItemID.CobaltBar, ItemID.PalladiumBar, true);
			AddVariationSwap(mod, ItemID.MythrilBar, ItemID.OrichalcumBar, true);
			AddVariationSwap(mod, ItemID.AdamantiteBar, ItemID.TitaniumBar, true);
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
		public static void AddVariationSwap(Mod mod, short ingredient, short result, bool mirror = false, int iStack = 1, int rStack = 1, string reqTile = null)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ingredient, iStack);
			if (reqTile != null)
				recipe.AddTile(null, reqTile);
			recipe.SetResult(result, rStack);
			recipe.AddRecipe();

			if (mirror)
			{
				ModRecipe recipe2 = new ModRecipe(mod);
				recipe2.AddIngredient(result, rStack);
				if (reqTile != null)
					recipe2.AddTile(null, reqTile);
				recipe2.SetResult(ingredient, iStack);
				recipe2.AddRecipe();
			}
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
		public static void AddSlimeStaff(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup(RecipeGroupID.Wood, 8);
			recipe.AddRecipeGroup("CompletionMod:IronLeadBar", 14);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.Blowpipe);
			recipe.AddRecipe();
		}
		public static void AddFlareGun(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup(RecipeGroupID.Wood, 8);
			recipe.AddRecipeGroup("CompletionMod:IronLeadBar", 14);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.Blowpipe);
			recipe.AddRecipe();
		}
		public static void AddBlowpipe(Mod mod)
		{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddRecipeGroup(RecipeGroupID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.Blowpipe);
				recipe.AddRecipe();
		}
		public static void AddMarrow(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bone, 150);
			recipe.AddRecipeGroup("CompletionMod:CobaltPalladiumBar", 12);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.Marrow);
			recipe.AddRecipe();
		}
		public static void AddChainGuillotines(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChainKnife);
			recipe.AddRecipeGroup("CompletionMod:CobaltPalladiumBar", 8);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.ChainGuillotines);
			recipe.AddRecipe();
		}
		public static void AddChainKnife(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Chain, 10);
			recipe.AddRecipeGroup("CompletionMod:IronLeadBar", 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ChainKnife);
			recipe.AddRecipe();
		}
		public static void AddIceBoomerang(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock, 20);
			recipe.AddIngredient(ItemID.EnchantedBoomerang);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.IceBoomerang);
			recipe.AddRecipe();
		}
		public static void AddEnchantedBoomerang(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup(RecipeGroupID.Wood, 5);
			recipe.AddIngredient(ItemID.WoodenBoomerang);
			recipe.AddIngredient(ItemID.EnchantedSword);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.EnchantedBoomerang);
			recipe.AddRecipe();
		}
		public static void AddBoomerang(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup(RecipeGroupID.Wood, 25);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.WoodenBoomerang);
			recipe.AddRecipe();
		}
		public static void AddTrident(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("CompletionMod:GoldPlatinumBar", 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Trident);
			recipe.AddRecipe();
		}
		public static void AddSpear(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("CompletionMod:IronLeadBar", 4);
			recipe.AddRecipeGroup(RecipeGroupID.Wood, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Spear);
			recipe.AddRecipe();
		}
		public static void AddHelFire(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("CompletionMod:CobaltPalladiumBar", 8);
			recipe.AddIngredient(ItemID.Cascade);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.HelFire);
			recipe.AddRecipe();
		}
		public static void AddYelets(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("CompletionMod:AdamantiteTitaniumBar", 8);
			recipe.AddIngredient(ItemID.JungleYoyo);
			recipe.AddIngredient(ItemID.SoulofMight, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.Yelets);
			recipe.AddRecipe();
		}
		public static void AddCascade(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Cascade);
			recipe.AddRecipe();
		}
		public static void AddRally(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("CompletionMod:IronLeadBar", 14);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Rally);
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