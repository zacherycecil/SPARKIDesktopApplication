using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace SPARKIDesktopApp
{
    class FileUtil
    {
        public static string[] GetMacroFileNames()
        {
            return GetFileNames("Macros");
        }

        public static string[] GetTriggerFileNames()
        {
            return GetFileNames("Triggers");
        }

        public static string[] GetProfileFileNames()
        {
            return GetFileNames("Profiles");
        }

        private static string[] GetFileNames(string fileType)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(fileType + "/");
            FileInfo[] files = directoryInfo.GetFiles("*.csv");
            if (files.Length == 0)
                return new[] { "<none>" };
            else
            {
                string[] profileNames = new string[files.Length];
                for (int i = 0; i < files.Length; i++)
                    profileNames[i] = files[i].Name;
                return profileNames;
            }
        }

        public static void SaveFESProfile(string profileName, string macro, string trigger)
        {
            // Get data from profile to save to CSV
            string data = "FES," + macro + "," + trigger;

            // Save data to csv file with profile name
            File.WriteAllText("Profiles/" + profileName + ".csv", data);
        }

        public static void SaveFreeRunProfile(string profileName, string macro)
        {
            // Get data from profile to save to CSV
            string data = "FES," + macro;

            // Save data to csv file with profile name
            File.WriteAllText("Profiles/" + profileName + ".csv", data);
        }

        public static void SaveTherapeuticProfile(string profileName)
        {
            // Get data from profile to save to CSV
            string data = "Therapeutic";

            // Save data to csv file with profile name
            File.WriteAllText("Profiles/" + profileName + ".csv", data);
        }

        public static string[] GetFESProfileData(string profileName)
        {
            return new[] { "h" };
        }
    }
}
