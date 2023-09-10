using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using System;
using System.Diagnostics;
using System.Net.Mime;

namespace monopoly
{
    public class Game1 : Game
    {
       
     
      
        // drawing
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private IGameSystem gameSystem;
        public static SpriteFont font;
        
        
        Texture2D gameBoard;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }
        // initialize the scale of board, sprites of board and player
        public static float scale = 0.75f; // 1404 (picture size) to 1080 (screen size) 
        public static Texture2D boardTexture = null;
        public static Texture2D hatTexture = null;
        public static Texture2D racecarTexture = null;
        public static Texture2D battleshipTexture = null;
        public static Texture2D thimbleTexture = null;


       

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.IsFullScreen = false;
            _graphics.PreferredBackBufferWidth = 1920; // window wideth
            _graphics.PreferredBackBufferHeight = 1080; // window height
            _graphics.ApplyChanges();

            gameSystem = new MonopolyGamesSystem();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
   
          //  boardTexture = Content.Load<Texture2D>("monopoly");
            boardTexture = Content.Load<Texture2D>("board");
            hatTexture = Content.Load<Texture2D>("hat");
            racecarTexture = Content.Load<Texture2D>("racecar");
            thimbleTexture = Content.Load<Texture2D>("thimble");
            battleshipTexture = Content.Load<Texture2D>("battleship");
            font = Content.Load<SpriteFont>("text");
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