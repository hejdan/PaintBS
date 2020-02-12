using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace WindowsGame1
{
   public class Fyrkant
    {
        public Texture2D cubeTexure;
        public Vector2 cubePosition = new Vector2(0,0);
        public bool cubeIsActive = true;
        public Rectangle hitbox;
        public int color { get; set; }

        public Fyrkant(Texture2D texture, Vector2 position, bool isActive, Rectangle hitbox, int color)
        {
            this.cubeTexure = texture;
            this.cubePosition = position;
            this.cubeIsActive = isActive;
            this.hitbox = hitbox;
            this.color = color;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if(color == 1)
            {
                spriteBatch.Draw(cubeTexure, cubePosition, Color.Red);
            }
            else if (color == 2)
            {
                spriteBatch.Draw(cubeTexure, cubePosition, Color.Green);

            }
            else if (color == 3)
            {
                spriteBatch.Draw(cubeTexure, cubePosition, Color.Blue);

            }
            else if (color == 4)
            {
                spriteBatch.Draw(cubeTexure, cubePosition, Color.Yellow);

            }
            else if (color == 5)
            {
                spriteBatch.Draw(cubeTexure, cubePosition, Color.Black);

            }
            else spriteBatch.Draw(cubeTexure, cubePosition, Color.White);
        }
    }
}
