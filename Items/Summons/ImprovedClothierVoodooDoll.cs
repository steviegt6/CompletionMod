using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CompletionMod.Items.Summons
{
    public class ImprovedClothierVoodooDoll : ModItem
    {
        public override string Texture => "Terraria/Item_1307";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Clothier Voodoo Doll");
            Tooltip.SetDefault("Can summon Skeletron without killing the Clothier." +
                "\nUse during the day to summon a Dungeon Guardian.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ClothierVoodooDoll);
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.consumable = true;
            item.useAnimation = 45;
            item.useTime = 45;
            item.maxStack = 20;
            item.value = 15 * 100 * 100;
            item.accessory = false;
        }

        public override bool PreDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, ref float rotation, ref float scale, int whoAmI)
        {
            if (NPC.downedBoss3)
            {
                Texture2D texture = mod.GetTexture("Glowmasks/ClothierVoodooDoll");

                Vector2 position = item.position - Main.screenPosition + new Vector2(item.width / 2, item.height - texture.Height * 0.5f + 2f);

                for (int i = 0; i < 4; i++)
                {
                    Vector2 offsetPosition = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                    spriteBatch.Draw(texture, position + offsetPosition, null, Main.DiscoColor, rotation, texture.Size() * 0.5f, scale, SpriteEffects.None, 0f);
                }
            }
            return true;
        }

        public override bool PreDrawInInventory(SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale)
        {
            if (Main.hardMode)
            {
                Texture2D texture = mod.GetTexture("Glowmasks/ClothierVoodooDoll");

                for (int i = 0; i < 4; i++)
                {
                    Vector2 offsetPositon = Vector2.UnitY.RotatedBy(MathHelper.PiOver2 * i) * 2;
                    spriteBatch.Draw(texture, position + offsetPositon, null, Main.DiscoColor, 0, origin, scale, SpriteEffects.None, 0f);
                }
            }
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if ((!Main.dayTime && (!NPC.AnyNPCs(NPCID.SkeletronHead) || NPC.downedBoss3)) || (Main.dayTime || !NPC.AnyNPCs(NPCID.DungeonGuardian)))
                return true;
            else
                return false;
        }
        public override bool UseItem(Player player)
        {
            if (Main.dayTime)
                NPC.SpawnOnPlayer(player.whoAmI, NPCID.DungeonGuardian);
            if (!Main.dayTime)
                NPC.SpawnOnPlayer(player.whoAmI, NPCID.SkeletronHead);
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}