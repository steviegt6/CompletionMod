using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace CompletionMod
{
    public class CompletionModWorld : ModWorld
    {
        public static bool downedOgre;
        public static bool downedDarkMage;
        public static bool downedBetsy;
        public static bool downedEclipse;
        public static bool eclipse = false;
        public static bool downedLegion;
        public static bool legion = false;
        public static bool downedPumpkinMoon;
        public static bool pumpkin = false;
        public static bool downedFrostMoon;
        public static bool frost = false;
        public static bool downedPirateShip;
        public static bool downedDarkMageHard;
        public static bool downedOgreHard;
        
        public static float tick;

        public override void Initialize()
        {
            base.Initialize();
            downedOgre = false;
            downedDarkMage = false;
            downedBetsy = false;
            downedEclipse = false;
            downedLegion = false;
            downedPumpkinMoon = false;
            downedFrostMoon = false;
            downedPirateShip = false;
            downedDarkMageHard = false;
            downedOgreHard = false;
        }

        public override void Load(TagCompound tag)
        {
            var downed = tag.GetList<string>("downed");
            downedOgre = downed.Contains("Ogre");
            downedDarkMage = downed.Contains("DarkMage");
            downedBetsy = downed.Contains("Betsy");
            downedEclipse = downed.Contains("Eclipse");
            downedLegion = downed.Contains("Legion");
            downedPumpkinMoon = downed.Contains("PumpkinMoon");
            downedFrostMoon = downed.Contains("ForstMoon");
            downedPirateShip = downed.Contains("PirateShip");
            downedDarkMageHard = downed.Contains("DarkMageHard");
            downedOgreHard = downed.Contains("OgreHard");
        }

        public override TagCompound Save()
        {
            var downed = new List<string>();
            if (downedOgre)
                downed.Add("Ogre");
            if (downedDarkMage)
                downed.Add("DarkMage");
            if (downedBetsy)
                downed.Add("Betsy");
            if (downedEclipse)
                downed.Add("Eclipse");
            if (downedLegion)
                downed.Add("Legion");
            if (downedPumpkinMoon)
                downed.Add("PumpkinMoon");
            if (downedFrostMoon)
                downed.Add("FrostMoon");
            if (downedPirateShip)
                downed.Add("PirateShip");
            if (downedDarkMageHard)
                downed.Add("DarkMageHard");
            if (downedOgreHard)
                downed.Add("DownedOgreHard");
            return new TagCompound
            {
                ["downed"] = downed
            };
        }

        public override void LoadLegacy(BinaryReader reader)
        {
            int loadVersion = reader.ReadInt32();
            if (loadVersion == 0)
            {
                BitsByte flags = reader.ReadByte();
                BitsByte flags2 = reader.ReadByte();
                downedOgre = flags[0];
                downedDarkMage = flags[1];
                downedBetsy = flags[2];
                downedEclipse = flags[3];
                downedLegion = flags[4];
                downedPumpkinMoon = flags[5];
                downedFrostMoon = flags[6];
                downedPirateShip = flags[7]; //Note to Self: flags2
                downedDarkMageHard = flags2[0];
                downedOgreHard = flags2[1];
            }
            else
                mod.Logger.WarnFormat("CompletionMod: Unknown loadVersion: {0}", loadVersion);
        }

        public override void NetSend(BinaryWriter writer)
        {
            var flags = new BitsByte();
            var flags2 = new BitsByte();
            flags[0] = downedOgre;
            flags[1] = downedDarkMage;
            flags[2] = downedBetsy;
            flags[3] = downedEclipse;
            flags[4] = downedLegion;
            flags[5] = downedPumpkinMoon;
            flags[6] = downedFrostMoon;
            flags[7] = downedPirateShip;
            flags2[0] = downedDarkMageHard;
            flags2[1] = downedOgreHard;
        }

        public override void NetReceive(BinaryReader reader)
        {
            BitsByte flags = reader.ReadByte();
            BitsByte flags2 = reader.ReadByte();
            downedOgre = flags[0];
            downedDarkMage = flags[1];
            downedBetsy = flags[2];
            downedEclipse = flags[3];
            downedLegion = flags[4];
            downedPumpkinMoon = flags[5];
            downedFrostMoon = flags[6];
            downedPirateShip = flags[7];
            downedDarkMageHard = flags2[0];
            downedOgreHard = flags2[1];
        }

        public override void PostUpdate()
        {
            Player player = Main.player[Main.myPlayer];

            tick = Main.GameUpdateCount % 60 / 60f;

            if (Main.eclipse)
                eclipse = true;
            if (!Main.dayTime)
                if (eclipse)
                    downedEclipse = true;
            if (Main.invasionType == 2)
                legion = true;
            if (Main.invasionType == 0)
                if (legion)
                    downedLegion = true;
            if (Main.pumpkinMoon)
                pumpkin = true;
            if (Main.snowMoon)
                frost = true;
            if (Main.dayTime)
            {
                if (pumpkin)
                    downedPumpkinMoon = true;
                if (frost)
                    downedFrostMoon = true;
            }

            foreach (Item item in player.inventory)
            {
                if (Config.Instance.AutoConvert)
                {
                    switch (item.type)
                    {
                        case ItemID.GuideVoodooDoll:
                            if (Main.mouseItem.type != ItemID.GuideVoodooDoll)
                            {
                                int stack = item.stack;
                                item.TurnToAir();
                                Item.NewItem((int)player.position.X, (int)player.position.Y, player.width, player.height, mod.ItemType("ImprovedGuideVoodooDoll"), stack, true, 0, true);
                            }
                            break;
                        case ItemID.ClothierVoodooDoll:
                            if (Main.mouseItem.type != ItemID.ClothierVoodooDoll)
                            {
                                int stack = item.stack;
                                item.TurnToAir();
                                Item.NewItem((int)player.position.X, (int)player.position.Y, player.width, player.height, mod.ItemType("ImprovedClothierVoodooDoll"), stack, true, 0, true);
                            }
                            break;
                    }
                }
            }
            foreach (Item item in Main.item)
            {
                if (Config.Instance.AutoConvert)
                {
                    switch (item.type)
                    {
                        case ItemID.GuideVoodooDoll:
                            if (item.active)
                            {
                                int stack = item.stack;
                                item.TurnToAir();
                                Item.NewItem((int)item.position.X, (int)item.position.Y, item.width, item.height, mod.ItemType("ImprovedGuideVoodooDoll"), stack);
                            }
                            break;
                        case ItemID.ClothierVoodooDoll:
                            if (item.active)
                            {
                                int stack = item.stack;
                                item.TurnToAir();
                                Item.NewItem((int)item.position.X, (int)item.position.Y, item.width, item.height, mod.ItemType("ImprovedClothierVoodooDoll"), stack);
                            }
                            break;
                    }
                }
            }
        }
    }
}
