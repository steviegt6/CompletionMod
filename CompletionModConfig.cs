using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace CompletionMod
{
    [Label("Completion Config")]
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        public static Config Instance;

        public override void OnLoaded()
        {
            Instance = this;
        }

        [Header("$Mods.CompletionMod.General")]
        [Label("$Mods.CompletionMod.AutoConvert")]
        [Tooltip("RELOAD THE MOD FOR CHANGES TO TAKE FULL EFFECT" +
            "\n" +
            "\nEnabling this auto-converts summoning items into their 'stackable' counterpart." +
            "\n(Stackable counterparts can be used to summon the same boss multiple times)" +
            "\nDisabling this allows you to craft summons into their stackable counterpart and vice-versa.")]
        //[ReloadRequired]
        [DefaultValue(true)]
        public bool AutoConvert;

        [Label("$Mods.CompletionMod.RainbowOutline")]
        //[ReloadRequired]
        [Tooltip("Enabling this will give summoning items a rainbow outline when their respective boss/invasion/event has been defeated.")]
        [DefaultValue(true)]
        public bool RainbowOutline;

        [Label("$Mods.CompletionMod.RecipeSwitch")]
        [Tooltip("Enabling this replaces various items with recipe groups so you can use that item or the item's variant." +
            "\n(i.e. use copper and tin bars instead of just copper)")]
        [ReloadRequired]
        [DefaultValue(true)]
        public bool RecipeSwitch;

        [Label("$Mods.CompletionMod.InfPotionsEnabled")]
        [DefaultValue(true)]
        //[ReloadRequired]
        public bool infPotions;

        [Label("$Mods.CompletionMod.PotionsNeeded")]
        [DefaultValue(30)]
        [Range(1, 60)]
        //[ReloadRequired]
        public int potionsNeeded;

        [Label("$Mods.CompletionMod.InfThrowingEnabled")]
        [DefaultValue(true)]
        //[ReloadRequired]
        public bool infThrowing;

        [Label("$Mods.CompletionMod.ThrowingNeeded")]
        [DefaultValue(999)]
        [Range(999, 3996)]
        //[ReloadRequired]
        public int throwingNeeded;

        [Label("$Mods.CompletionMod.InfAmmoEnabled")]
        [DefaultValue(true)]
        //[ReloadRequired]
        public bool infAmmo;

        [Label("$Mods.CompletionMod.AmmoNeeded")]
        [DefaultValue(3996)]
        [Range(999, 3996)]
        //[ReloadRequired]
        public int ammoNeeded;

        [Header("$Mods.CompletionMod.Misc")]
        [Label("$Mods.CompletionMod.MaxStack")]
        [Tooltip("I would recommend using Max Stack Plus Extra instead.")]
        [ReloadRequired]
        [DefaultValue(false)]
        public bool MaxStackEnabled;
    }
}