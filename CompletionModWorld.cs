using System.Collections.Generic;
using System.IO;
using Terraria;
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

        public override void Initialize()
        {
            base.Initialize();
            downedOgre = false;
            downedDarkMage = false;
            downedBetsy = false;
            downedEclipse = false;
            downedLegion = false;
        }

        public override void Load(TagCompound tag)
        {
            var downed = tag.GetList<string>("downed");
            downedOgre = downed.Contains("Ogre");
            downedDarkMage = downed.Contains("DarkMage");
            downedBetsy = downed.Contains("Betsy");
            downedEclipse = downed.Contains("Eclipse");
            downedLegion = downed.Contains("Legion");
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
                downed.Add("Legion:");
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
                downedOgre = flags[0];
                downedDarkMage = flags[1];
                downedBetsy = flags[2];
                downedEclipse = flags[3];
                downedLegion = flags[4];
            }
            else
                mod.Logger.WarnFormat("CompletionMod: Unknown loadVersion: {0}", loadVersion);
        }

        public override void NetSend(BinaryWriter writer)
        {
            var flags = new BitsByte();
            flags[0] = downedOgre;
            flags[1] = downedDarkMage;
            flags[2] = downedBetsy;
            flags[3] = downedEclipse;
            flags[4] = downedLegion;
        }

        public override void NetReceive(BinaryReader reader)
        {
            BitsByte flags = reader.ReadByte();
            downedOgre = flags[0];
            downedDarkMage = flags[1];
            downedBetsy = flags[2];
            downedEclipse = flags[3];
            downedLegion = flags[4];
        }

        public override void PostUpdate()
        {
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
        }
    }
}
