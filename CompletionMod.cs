using CompletionMod.Content.Items;
using Terraria.ID;
using Terraria.ModLoader;

namespace CompletionMod
{
    public class CompletionMod : Mod
    {
        public static string GithubUserName => "Steviegt6";         // Mod Helper's Issue Handling
        public static string GithubProjectName => "CompletionMod";  // Mod Helper's Issue Handling

        /// <summary>
        /// Set to true on PostAddRecipes.
        /// </summary>
        public static bool CanAutosizeItems = false;

        // Boosts the player's maximum buffs to 100. The total amount that the player is allowed to be used can be configured. Other mods may raise the total cap further, though thanks to our code, it doesn't matter (see PreUpdateBuffs() in CompletionModPlayer).
        public override uint ExtraPlayerBuffSlots => 78;

        public override void Load()
        {
            AddEndlessItems()
        }

        public override void PostAddRecipes() => CanAutosizeItems = true;

        private void AddEndlessItems()
        {
            AddItem("EndlessWoodenArrow", new EndlessItem(ItemID.WoodenArrow));
            AddItem("EndlessFlamingArrow", new EndlessItem(ItemID.FlamingArrow));
            AddItem("EndlessUnholyArrow", new EndlessItem(ItemID.UnholyArrow));
            AddItem("EndlessJestersArrow", new EndlessItem(ItemID.JestersArrow));
            AddItem("EndlessHellfireArrow", new EndlessItem(ItemID.HellfireArrow));
            AddItem("EndlessHolyArrow", new EndlessItem(ItemID.HolyArrow));
            AddItem("EndlessCursedArrow", new EndlessItem(ItemID.CursedArrow));
            AddItem("EndlessFrostburnArrow", new EndlessItem(ItemID.FrostburnArrow));
            AddItem("EndlessChlorophyteArrow", new EndlessItem(ItemID.ChlorophyteArrow));
            AddItem("EndlessIchorArrow", new EndlessItem(ItemID.IchorArrow));
            AddItem("EndlessVenomArrow", new EndlessItem(ItemID.VenomArrow));
            AddItem("EndlessBoneArrow", new EndlessItem(ItemID.BoneArrow));
            AddItem("EndlessLuminiteArrow", new EndlessItem(ItemID.MoonlordArrow));
            AddItem("EndlessMusketBall", new EndlessItem(ItemID.MusketBall));
            AddItem("EndlessMeteorShot", new EndlessItem(ItemID.MeteorShot));
            AddItem("EndlessSilverBullet", new EndlessItem(ItemID.SilverBullet));
            AddItem("EndlessCrystalBullet", new EndlessItem(ItemID.CrystalBullet));
            AddItem("EndlessCursedBullet", new EndlessItem(ItemID.CursedBullet));
            AddItem("EndlessChlorophyteBullet", new EndlessItem(ItemID.ChlorophyteBullet));
            AddItem("EndlessHighVelocityBullet", new EndlessItem(ItemID.HighVelocityBullet));
            AddItem("EndlessIchorBullet", new EndlessItem(ItemID.IchorBullet));
            AddItem("EndlessVenomBullet", new EndlessItem(ItemID.VenomBullet));
            AddItem("EndlessPartyBullet", new EndlessItem(ItemID.PartyBullet));
            AddItem("EndlessNanoBullet", new EndlessItem(ItemID.NanoBullet));
            AddItem("EndlessExplodingBullet", new EndlessItem(ItemID.ExplodingBullet));
            AddItem("EndlessGoldenBullet", new EndlessItem(ItemID.GoldenBullet));
            AddItem("EndlessLuminiteBullet", new EndlessItem(ItemID.MoonlordBullet));
            AddItem("EndlessRocketI", new EndlessItem(ItemID.RocketI));
            AddItem("EndlessRocketII", new EndlessItem(ItemID.RocketII));
            AddItem("EndlessRocketIII", new EndlessItem(ItemID.RocketIII));
            AddItem("EndlessRocketIV", new EndlessItem(ItemID.RocketIV));
            AddItem("EndlessPoisonDart", new EndlessItem(ItemID.PoisonDart));
            AddItem("EndlessCrystalDart", new EndlessItem(ItemID.CrystalDart));
            AddItem("EndlessCursedDart", new EndlessItem(ItemID.CursedDart));
            AddItem("EndlessIchorDart", new EndlessItem(ItemID.IchorDart));
            AddItem("EndlessGreenSolution", new EndlessItem(ItemID.GreenSolution));
            AddItem("EndlessBlueSolution", new EndlessItem(ItemID.BlueSolution));
            AddItem("EndlessPurpleSolution", new EndlessItem(ItemID.PurpleSolution));
            AddItem("EndlessDarkBlueSolution", new EndlessItem(ItemID.DarkBlueSolution));
            AddItem("EndlessRedSolution", new EndlessItem(ItemID.RedSolution));
            AddItem("EndlessFallenStar", new EndlessItem(ItemID.FallenStar, 99));
            AddItem("EndlessGel", new EndlessItem(ItemID.Gel, 99));
            AddItem("EndlessSand", new EndlessItem(ItemID.SandBlock, 999));
            AddItem("EndlessEbonsand", new EndlessItem(ItemID.EbonsandBlock, 999));
            AddItem("EndlessPearlsand", new EndlessItem(ItemID.PearlsandBlock, 999));
            AddItem("EndlessCrimsand", new EndlessItem(ItemID.CrimsandBlock, 999));
            AddItem("EndlessSeed", new EndlessItem(ItemID.Bone, 99));
            AddItem("EndlessBone", new EndlessItem(ItemID.Seed, 999));
            AddItem("EndlessStyngerBolt", new EndlessItem(ItemID.StyngerBolt));
            AddItem("EndlessCandyCorn", new EndlessItem(ItemID.CandyCorn));
            AddItem("EndlessExplosiveJackOLantern", new EndlessItem(ItemID.ExplosiveJackOLantern));
            AddItem("EndlessStake", new EndlessItem(ItemID.Stake));
            AddItem("EndlessAle", new EndlessItem(ItemID.Ale, 30, TileID.Bottles));
            AddItem("EndlessFlare", new EndlessItem(ItemID.Flare, 99));
            AddItem("EndlessBlueFlare", new EndlessItem(ItemID.BlueFlare, 99));
            AddItem("EndlessSnowball", new EndlessItem(ItemID.Snowball, 999));
            AddItem("EndlessNail", new EndlessItem(ItemID.Nail));
        }
    }
}