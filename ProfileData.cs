using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPARKIDesktopApp
{
    public class ProfileData
    {
        public List<Electrode> electrodeList = new List<Electrode>();
        public string profileName { get; set; }
        public string macro;
        public string trigger;

        public ProfileData(string profileName)
        {
            this.profileName = profileName;
            macro = FileUtil.GetFirstMacroFile();
            trigger = FileUtil.GetFirstTriggerFile();
            EmptyElectrodeList(4);
        }

        public ProfileData(string profileName, List<Electrode> electrodeList)
        {
            this.profileName = profileName;
            this.electrodeList = electrodeList;
        }

        public ProfileData(string profileName, string macro)
        {
            this.profileName = profileName;
            this.macro = macro;
        }

        public ProfileData(string profileName, string macro, string trigger)
        {
            this.profileName = profileName;
            this.macro = macro;
            this.trigger = trigger;
        }

        public void EmptyElectrodeList(int electrodes)
        {
            for (int i = 0; i < electrodes; i++)
            {
                Electrode el = new Electrode("Electrode " + (i + 1));
                electrodeList.Add(el);
            }
        }
    }
}
