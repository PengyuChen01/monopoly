using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using System;
using System.Diagnostics;

namespace monopoly
{
    public class Game1 : Game
    {
        Texture2D ballTexture;
        Vector2 ballPosition;
        float ballSpeed;
        // drawing
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private IGameSystem gameSystem;

        Texture2D gameBoard;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        public static float scale = 2.1f;
        public static Texture2D boardTexture = null;
        public static Texture2D hatTexture = null;
        public static Texture2D racecarTexture = null;
        public static Texture2D battleshipTexture = null;
        public static Texture2D thimbleTexture = null;

       

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            ballPosition = new Vector2(_graphics.PreferredBackBufferWidth / 2,
                _graphics.PreferredBackBufferHeight / 2);
            ballSpeed = 100f;
            gameSystem = new MonopolyGamesSystem();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            ballTexture = Content.Load<Texture2D>("ball");
            boardTexture = Content.Load<Texture2D>("monopoly");
            hatTexture = Content.Load<Texture2D>("hat");
            racecarTexture = Content.Load<Texture2D>("racecar");
            thimbleTexture = Content.Load<Texture2D>("thimble");
            battleshipTexture = Content.Load<Texture2D>("battleship");
            gameSystem.setUp();
        }

        protected override void Update(GameTime gameTime)
        {
            gameSystem.update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            gameSystem.draw(_spriteBatch);
            
            _spriteBatch.End();
            base.Draw(gameTime);
        }
        
    }
}