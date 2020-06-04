using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CompletionMod.Items.CandyCane
{
    internal class GreenCandyCaneHookItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Green Candy Cane Hook");
            //Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.noUseGraphic = true;
            item.damage = 0;
            item.knockBack = 7f;
            item.useStyle = 5;
            item.width = 18;
            item.height = 28;
            item.UseSound = SoundID.Item1;
            item.useAnimation = 20;
            item.useTime = 20;
            item.rare = 7;
            item.noMelee = true;
            item.value = Item.sellPrice(0, 4, 0, 0);
            //item.CloneDefaults(ItemID.CandyCaneHook);
            item.shootSpeed = 11.5f;
            item.shoot = ProjectileType<GreenCandyCaneHookProjectile>();
        }

        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GreenCandyCaneBlock, 85);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    internal class GreenCandyCaneHookProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Green Candy Cane Hook");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            projectile.netImportant = true;
            projectile.width = 18;
            projectile.height = 18;
            projectile.aiStyle = 7;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.tileCollide = false;
            projectile.timeLeft *= 10;
            //projectile.CloneDefaults(ProjectileID.CandyCaneHook);
        }

        public override bool? CanUseGrapple(Player player)
        {
            int hooksOut = 0;
            for (int l = 0; l < 1000; l++)
            {
                if (Main.projectile[l].active && Main.projectile[l].owner == Main.myPlayer && Main.projectile[l].type == projectile.type)
                {
                    hooksOut++;
                }
            }
            if (hooksOut > 1)
            {
                return false;
            }
            return true;
            //return base.CanUseGrapple(player);
        }

        public override float GrappleRange()
        {
            return 400f; //GrappleRange float = int*16 (amount of tiles multiplied by 16), I think...
            //return base.GrappleRange();
        }

        public override void NumGrappleHooks(Player player, ref int numHooks)
        {
            base.NumGrappleHooks(player, ref numHooks);
            numHooks = 1;
        }

        public override void GrappleRetreatSpeed(Player player, ref float speed)
        {
            speed = 11f;
            base.GrappleRetreatSpeed(player, ref speed);
        }

        public override void GrapplePullSpeed(Player player, ref float speed)
        {
            speed = 11f;
            base.GrapplePullSpeed(player, ref speed);
        }

        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            Vector2 playerCenter = Main.player[projectile.owner].MountedCenter;
            Vector2 center = projectile.Center;
            Vector2 distToProj = playerCenter - projectile.Center;
            float projRotation = distToProj.ToRotation() - 1.57f;
            float distance = distToProj.Length();
            while (distance > 30f && !float.IsNaN(distance))
            {
                distToProj.Normalize();                 //get unit vector
                distToProj *= 24f;                      //speed = 24
                center += distToProj;                   //update draw position
                distToProj = playerCenter - center;    //update distance
                distance = distToProj.Length();
                Color drawColor = lightColor;

                //Draw chain
                spriteBatch.Draw(mod.GetTexture("Items/CandyCane/GreenCandyCaneHookChain"), new Vector2(center.X - Main.screenPosition.X, center.Y - Main.screenPosition.Y),
                    new Rectangle(0, 0, Main.chain30Texture.Width, Main.chain30Texture.Height), drawColor, projRotation,
                    new Vector2(Main.chain30Texture.Width * 0.5f, Main.chain30Texture.Height * 0.5f), 1f, SpriteEffects.None, 0f);
            }
            return true;
            //return base.PreDraw(spriteBatch, lightColor);
        }
    }
}