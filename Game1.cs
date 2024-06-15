using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Font_Size
{
	public class Game1 : Game
	{
		private GraphicsDeviceManager _graphics;
		private SpriteBatch _spriteBatch;

		Vector2 stringSize;
		Rectangle window = new Rectangle(0, 0, 800, 600);

		SpriteFont trekFont;

		public Game1()
		{
			_graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			IsMouseVisible = true;
		}

		protected override void Initialize()
		{
			// TODO: Add your initialization logic here
			_graphics.PreferredBackBufferWidth = window.Width;
			_graphics.PreferredBackBufferHeight = window.Height;	
			_graphics.ApplyChanges();
			base.Initialize();
			stringSize = trekFont.MeasureString("The Next Generation");
		}

		protected override void LoadContent()
		{
			_spriteBatch = new SpriteBatch(GraphicsDevice);

			// TODO: use this.Content to load your game content here
			trekFont = Content.Load<SpriteFont>("TrekFont");
		}

		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

			// TODO: Add your update logic here

			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.Black);

			// TODO: Add your drawing code here
			_spriteBatch.Begin();

			_spriteBatch.DrawString(trekFont, "The Next Generation", window.Center.ToVector2() - stringSize/2, new Color(0, 153, 246));

			_spriteBatch.End();

			base.Draw(gameTime);
		}
	}
}
