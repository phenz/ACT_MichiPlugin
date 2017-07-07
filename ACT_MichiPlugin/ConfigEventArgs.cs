using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_MichiPlugin
{
    public class MichiDataChangedEventArgs : EventArgs
    {
        public List<HervestObject> NewMichiData { get; private set; }
        public MichiDataChangedEventArgs(List<HervestObject> newMichiData)
        {
            this.NewMichiData = newMichiData;
        }
    }
}
