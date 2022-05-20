using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Nez;
using Nez.BitmapFonts;

namespace NezTemplate.Components
{
    public class BasicComponent : RenderableComponent, IUpdatable
    {
        public override float Width { get; }
        public override float Height { get; }

        public BitmapFont Font { get; }

        public BasicComponent(BitmapFont font)
        {
            Width = 400;
            Height = 400;

            Font = font;
        }

        public override void Render(Batcher batcher, Camera camera)
        {
            batcher.DrawString(Font, "Hello from NezTemplate!", Entity.Position, Color.White);
        }

        public void Update()
        {
            var speed = 4 * (Time.DeltaTime * 100);

            if (Input.IsKeyDown(Keys.Left))
            {
                Entity.Position -= Vector2.UnitX * speed;
            }
            if (Input.IsKeyDown(Keys.Right))
            {
                Entity.Position += Vector2.UnitX * speed;
            }
            if (Input.IsKeyDown(Keys.Up))
            {
                Entity.Position -= Vector2.UnitY * speed;
            }
            if (Input.IsKeyDown(Keys.Down))
            {
                Entity.Position += Vector2.UnitY * speed;
            }
        }
    }
}