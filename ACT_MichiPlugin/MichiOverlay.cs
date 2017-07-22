using RainbowMage.OverlayPlugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Web.Script.Serialization;
using System.IO;

namespace ACT_MichiPlugin
{
    public class MichiOverlay : OverlayBase<MichiOverlayConfig>
    {
        private bool suppress_log = false;
        private bool isDebug = false;


        public MichiOverlay(MichiOverlayConfig config) : base(config, config.Name)
        {
            LoadMichiMasterData();
        }

        public override void Dispose()
        {
            base.Dispose();
        }

        public void LoadMichiMasterData()
        {
            if (!CheckUrl(this.Config.XmlUrl))
            {
                return;
            }
            XmlSerializer serializer = new XmlSerializer(typeof(List<HervestObject>));
            System.IO.StreamReader sr = new System.IO.StreamReader(new Uri(this.Config.XmlUrl).LocalPath);
            this.Config.MichiMasterData = (List<HervestObject>)serializer.Deserialize(sr);
            sr.Close();
        }

        public void LogDebug(string format, params object[] args)
        {
            string prefix = isDebug ? "DEBUG: " : "";
            LogLevel level = isDebug ? LogLevel.Info : LogLevel.Debug;
            Log(level, prefix + format, args);
        }

        public void LogError(string format, params object[] args)
        {
            if (suppress_log == false)
            {
                Log(LogLevel.Error, format, args);
            }
        }

        public void LogWarning(string format, params object[] args)
        {
            if (suppress_log == false)
            {
                Log(LogLevel.Warning, format, args);
            }
        }



        protected override void Update()
        {
            try
            {
                string updateScript = CreateEventDispatcherScript();
                if (this.Overlay != null &&
                    this.Overlay.Renderer != null &&
                    this.Overlay.Renderer.Browser != null)
                {
                    this.Overlay.Renderer.Browser.GetMainFrame().ExecuteJavaScript(updateScript, null, 0);
                }
            }
            catch (Exception ex)
            {
                LogError("Update: {0} {1}", this.Name, ex.ToString());
            }

        }

        internal string CreateJsonData()
        {
            // シリアライザ
            var serializer = new JavaScriptSerializer();
            return serializer.Serialize(this.Config.MichiData);
        }

        private string CreateEventDispatcherScript()
            => "var ActXiv = { 'Michi': " + this.CreateJsonData() + ", 'IsPlaySound':" + (this.Config.IsPlaySound && this.Config.IsVisible).ToString().ToLower() +"};\n" +
               "document.dispatchEvent(new CustomEvent('onOverlayDataUpdate', { detail: ActXiv }));";


        private bool CheckUrl(string url)
        {
            try
            {
                var uri = new System.Uri(url);

                // ローカルファイルの場合はファイルが存在するかチェックし、存在しなければ警告を出力
                if (uri.Scheme == "file")
                {
                    if (!File.Exists(uri.LocalPath))
                    {
                        Log(LogLevel.Warning,
                            "InitializeOverlay: Local file {0} does not exist!",
                            uri.LocalPath);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                // URL パースエラー
                Log(LogLevel.Error,
                    "InitializeOverlay: URI parse error! Please reconfigure the URL. (Config.Url = {0}): {1}",
                    this.Config.Url,
                    ex);
                return false;
            }

            return true;
        }
    }


    
}
