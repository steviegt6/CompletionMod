using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CompletionMod.HelpersHandlersandUtils
{
    public static class RecipeHelper
    {
        public static void GuideVoodooDollRecplacement(Mod mod)
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
		}
    }
}