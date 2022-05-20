using Nez;
using Nez.ImGuiTools;
using Nez.UI;
using NezTemplate.Scenes;

namespace NezTemplate
{
    public class GameRoot : Core
    {
        public GameRoot()
            : base(windowTitle: "NezTemplate")
        {
            Window.AllowUserResizing = false;
            PauseOnFocusLost = true;
        }

        protected override void Initialize()
        {
            base.Initialize();

            var imGuiManager = new ImGuiManager();
            RegisterGlobalManager(imGuiManager);

            Skin skin = Skin.CreateDefaultSkin();

            Services.AddService(skin);

            Scene = new BasicScene();
        }
    }
}
