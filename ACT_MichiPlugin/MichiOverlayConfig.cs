using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RainbowMage.OverlayPlugin;
using System.Xml.Serialization;

namespace ACT_MichiPlugin
{
    [Serializable]
    public class MichiOverlayConfig : OverlayConfigBase
    {
        //public event EventHandler<MichiDataChangedEventArgs> MichiDataChanged;

        private String _xmlUrl;
        private List<HervestObject> _michiData = new List<HervestObject>();
        private List<HervestObject> _michiMasterData = new List<HervestObject>();
        private bool _isPlaySound = false;

        public MichiOverlayConfig(string name) : base(name)
        {
            this.Url = new Uri(System.IO.Path.Combine(MichiPlugin.ResourcesDirectory, "michi.html")).ToString();
            this.XmlUrl = new Uri(System.IO.Path.Combine(MichiPlugin.ResourcesDirectory, "michi.xml")).ToString();

        }

        private MichiOverlayConfig() : base(null)
        {
        }

        public override Type OverlayType => typeof(MichiOverlay);
        [XmlElement("XmlUrl")]
        public string XmlUrl
        {
            get => _xmlUrl;
            set
            {
                if (this._xmlUrl != value)
                {
                    this._xmlUrl = value;
                }
            }
         }
        [XmlElement("MichiData")]
        public List<HervestObject> MichiData
        {
            get => _michiData;
            set
            {
                _michiData = value;
            }
        }
        [XmlElement("MichiMasterData")]
        public List<HervestObject> MichiMasterData { get => _michiMasterData; set => _michiMasterData = value; }
        [XmlElement("IsPlaySound")]
        public bool IsPlaySound { get => _isPlaySound; set => _isPlaySound = value; }
    }
}
