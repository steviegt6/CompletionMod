using CompletionMod.HelpersHandlersandUtils;
using Terraria.ID;
using Terraria.ModLoader;

namespace CompletionMod
{
    public class CompletionMod : Mod
    {
        internal static CompletionMod Instance;

        public static string GithubUserName => "Steviegt6";
        public static string GithubProjectName => "CompletionMod";

        public override void Load()
        {
            Instance = this;

            AddToggle("General", "General", ItemID.WireKite, "2694CD"); //very funny hahah terraria devs funny name SHUT UP
            AddToggle("AutoConvert", "Auto-Convert Boss Summons", ItemID.SuspiciousLookingEye);
            AddToggle("RainbowOutline", "Add a Rainbow Outline to Summoning Items", ItemID.CelestialSigil);
            AddToggle("RecipeSwitch", "Add Extra Recipe Groups", ItemID.SoulofFlight);
            AddToggle("PotionsNeeded", "Potion Stack Needed", ItemID.TallyCounter);
            AddToggle("InfPotionsEnabled", "Get Potion Buff when You Have " + Config.Instance.potionsNeeded + "+ Potions", ItemID.RestorationPotion);
            AddToggle("ThrowingNeeded", "Throwing Item Stack Needed", ItemID.TallyCounter);
            AddToggle("InfThrowingEnabled", "Infinite throwing items when you have " + Config.Instance.throwingNeeded + "+ of an Item", ItemID.StarAnise);
            AddToggle("AmmoNeeded", "Ammo Stack Needed", ItemID.TallyCounter);
            AddToggle("InfAmmoEnabled", "Infinite ammo (bullets/arrows, etc.) when you have " + Config.Instance.ammoNeeded + "+ of an Item", ItemID.BoneArrow);

            AddToggle("Misc", "Miscellaneous", ItemID.SoulofMight, "4BABFF");
            AddToggle("MaxStack", "Max Stack Increase", ItemID.TallyCounter);
        }

        public override void Unload()
        {
            Instance = null;
        }

        // -- AddToggle Code taken from Fargo's Soul Mod (FargowiltasSouls)! All credit goes to Fargo & other contributors!

        //For modded items
        public void AddToggle(string toggle, string name, string item, string color = "FFFFFF")
        {
            ModTranslation text = CreateTranslation(toggle);
            text.SetDefault("[i:" + Instance.ItemType(item) + "][c/" + color + ": " + name + "]");
            AddTranslation(text);
        }

        //For Vanilla items
        public void AddToggle(string toggle, string name, int item, string color = "FFFFFF")
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