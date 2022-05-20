using Microsoft.Xna.Framework;
using Nez;
using Nez.Sprites;
using Nez.Textures;
using NezTemplate.Components;

namespace NezTemplate.Scenes
{
    public class BasicScene : Scene
    {
        public const int ScreenSpaceRenderLayer = 999;

        public readonly int Width = 1600;
        public readonly int Height = 900;

        public BasicScene()
        {
            AddRenderer(new ScreenSpaceRenderer(100, ScreenSpaceRenderLayer));
            AddRenderer(new RenderLayerExcludeRenderer(0, ScreenSpaceRenderLayer));
        }

        public override void Initialize()
        {
            base.Initialize();

            ClearColor = Color.CornflowerBlue;

            SetDesignResolution(Width, Height, SceneResolutionPolicy.BestFit);
            Screen.SetSize(1920, 1080);

            var moonTexture = Content.LoadTexture(Nez.Content.Textures.Moon, true);
            var mainFont = Content.LoadBitmapFont(Nez.Content.Fonts.Main_font, true);

            var entity = new Entity("basic-entity");
            entity.AddComponent(new SpriteRenderer(new Sprite(moonTexture)));
            entity.AddComponent(new BasicComponent(mainFont));

            entity.Position = new Vector2(128, 128);

            AddEntity(entity);
        }
    }
}