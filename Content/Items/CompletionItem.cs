using Terraria;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;

namespace CompletionMod.Content.Items
{
    /// <summary>
    /// Serves as a base for most non-endless items added by this mod. Just simplifies some stuff. :wegud:
    /// </summary>
    public abstract class CompletionItem : ModItem
    {
        /// <summary>
        /// If set to true, axe power will no longer by 5 times the amount you set it to.
        /// Defaults to false.
        /// </summary>
        public virtual bool UseConsistentAxePower => false;

        /// <summary>
        /// If set to true, your item's height and width will be set during PostAddRecipes, set it to false to set your own custom width and height.
        /// Defaults to true.
        /// </summary>
        public virtual bool AutosizeItem => true;

        public virtual Texture2D ItemTexture => Main.itemTexture[item.type];

        public sealed override void SetDefaults()
        {
            SetItemDefaults();

            if (UseConsistentAxePower) item.axe /= 5;

            if (CompletionMod.CanAutosizeItems && AutosizeItem && Main.itemAnimationsRegistered.Contains(item.type))
            {
                DrawAnimationVertical itemAnimation = (DrawAnimationVertical)Main.itemAnimations[item.type];
                item.Size = new Vector2(ItemTexture.Width / itemAnimation.FrameCount, ItemTexture.Height);
            }
        }

        /// <summary>
        /// Set the item's defaults here.
        /// Called at the beginning of SetDefaults(), before UseConsistentAxePower and Autosizing is done. If you don't want the item to be Autosized, set AutosizeItem to false.
        /// </summary>
        public virtual void SetItemDefaults()
        {
        }
    }
}