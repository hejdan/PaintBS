using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace WindowsGame1
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Fyrkant cube;

        List<Fyrkant> fyrkanter = new List<Fyrkant>();

        int mouseX = Mouse.GetState().X;
        int mouseY = Mouse.GetState().Y;

        public int color = 5;

        public Game game = new Game();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
   
        protected override void Initialize()
        {
            this.IsMouseVisible = true;
            this.Window.Title = "BS Paint: Black color selected";
            base.Initialize();
        }

        protected override void LoadContent()
        {
             spriteBatch = new SpriteBatch(GraphicsDevice);

            cube = new Fyrkant(Content.Load<Texture2D>("cube"), new Vector2(0, 0), true, new Rectangle(), 0);

            for (int i = 0; i < graphics.GraphicsDevice.Viewport.Width / 10; i++)
            {
                for (int j = 0; j < graphics.GraphicsDevice.Viewport.Height / 10; j++)
                {
                    fyrkanter.Add(new Fyrkant(Content.Load<Texture2D>("cube"), new Vector2(0 + i * 15, 0 + j * 15), true, new Rectangle(i * 15, j * 15, 15, 15), 0));
                }
            }

        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            if (game.IsActive) { 

                if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();


            if (Keyboard.GetState().IsKeyDown(Keys.D1))
            {
                color = 1;
                    this.Window.Title = "BS Paint: Red color selected";
            }

            if (Keyboard.GetState().IsKeyDown(Keys.D2))
            {
                color = 2;
                    this.Window.Title = "BS Paint: Green color selected";
                }

            if (Keyboard.GetState().IsKeyDown(Keys.D3))
            {
                color = 3;
                    this.Window.Title = "BS Paint: Blue color selected";
                }

            if (Keyboard.GetState().IsKeyDown(Keys.D4))
            {
                color = 4;
                    this.Window.Title = "BS Paint: Yellow color selected";
                }

            if (Keyboard.GetState().IsKeyDown(Keys.D5))
            {
                color = 5;
                    this.Window.Title = "BS Paint: Black color selected";
                }


            mouseX = Mouse.GetState().X;
            mouseY = Mouse.GetState().Y;

            
            
                 if (Mouse.GetState().LeftButton == ButtonState.Pressed)
                 {
                    foreach (Fyrkant fyrkant in fyrkanter)
                    {
                        if (fyrkant.hitbox.Contains(mouseX, mouseY))
                        {
                        fyrkant.cubeIsActive = true;
                        fyrkant.color = color;
                        }
                    }
                
                 }

            if (Mouse.GetState().RightButton == ButtonState.Pressed)
            {
                foreach (Fyrkant fyrkant in fyrkanter)
                {
                    if (fyrkant.hitbox.Contains(mouseX, mouseY))
                    {
                        fyrkant.cubeIsActive = false;
                        fyrkant.color = 0;

                    }
                }
            }

            }

            base.Update(gameTime);
        }

       protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);
            spriteBatch.Begin();

            foreach (Fyrkant fyrkant in fyrkanter)
            {
                fyrkant.Draw(spriteBatch);
            }
            spriteBatch.End();
             base.Draw(gameTime);
        }
    }
}
