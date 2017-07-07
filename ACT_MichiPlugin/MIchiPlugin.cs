using RainbowMage.OverlayPlugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ACT_MichiPlugin
{
    public class MichiPlugin : IOverlayAddon
    {
        // OverlayPluginのリソースフォルダ
        public static string ResourcesDirectory = String.Empty;
        public static string UpdateMessage = String.Empty;

        public MichiPlugin()
        {
            // OverlayPlugin.Coreを期待
            Assembly asm = System.Reflection.Assembly.GetCallingAssembly();
            if (asm.Location == null || asm.Location == "")
            {
                // 場所がわからないなら自分の場所にする
                asm = Assembly.GetExecutingAssembly();
            }
            ResourcesDirectory = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(asm.Location), "resources");
        }

        

        public string Name => "Michi";

        public string Description => "Show Michi point.";

        public Type OverlayType => typeof(MichiOverlay);

        public Type OverlayConfigType => typeof(MichiOverlayConfig);

        public Type OverlayConfigControlType => typeof(MichiOverlayConfigPanel);

        public IOverlay CreateOverlayInstance(IOverlayConfig config) => new MichiOverlay((MichiOverlayConfig)config);

        public IOverlayConfig CreateOverlayConfigInstance(string name) => new MichiOverlayConfig(name);

        public System.Windows.Forms.Control CreateOverlayConfigControlInstance(IOverlay overlay) => new MichiOverlayConfigPanel((MichiOverlay)overlay);

        public void Dispose() { }
    }
}
