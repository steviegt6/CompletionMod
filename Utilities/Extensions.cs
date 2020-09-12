using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CompletionMod.Utilities
{
    public static class Extensions
    {
        /// <summary>
        /// Creates a copy of the Texture2D with all non-transparent pixels converted to the specified color.
        /// </summary>
        /// <param name="texture"></param>
        /// <param name="color">The flat color you want to turn this texture to.</param>
        /// <param name="graphicsDevice"></param>
        /// <returns></returns>
        public static Texture2D ToFlatColor(this Texture2D texture, Color color, GraphicsDevice graphicsDevice)
        {
            Texture2D newTexture = new Texture2D(graphicsDevice, texture.Width, texture.Height);
            Color[] data = new Color[texture.Width * texture.Height];
            int dataIndex = 0;

            texture.GetData(data);

            foreach (Color pixel in data)
            {
                if (pixel.A != 0)
                {
                    data[dataIndex] = new Color(color.R, color.G, color.B);
                }

                dataIndex++;
            }

            newTexture.SetData(data);

            return newTexture;
        }

        public static Vector2 ToVector2(this float fl) => new Vector2(fl, fl);
    }
}