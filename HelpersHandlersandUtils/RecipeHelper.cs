using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CompletionMod.HelpersHandlersandUtils
{
    public static class RecipeHelper
    {
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