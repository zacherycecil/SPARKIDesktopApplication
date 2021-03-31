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
            string data = "FES\n" + macro + "\n" + trigger;

            // Save data to csv file with profile name
            File.WriteAllText("Profiles/" + profileName + ".csv", data);
        }

        public static void SaveFreeRunProfile(string profileName, string macro)
        {
            // Get data from profile to save to CSV
            string data = "FreeRun\n" + macro;

            // Save data to csv file with profile name
            File.WriteAllText("Profiles/" + profileName + ".csv", data);
        }

        public static void SaveTherapeuticProfile(ProfileData data)
        {
            // Get data from profile to save to CSV
            string csvToWrite = "Therapeutic";

            foreach (Electrode e in data.electrodeList)
            {
                csvToWrite += "\n";
                foreach (int tVal in e.therapeuticValues)
                {
                    csvToWrite += tVal + ",";
                }
            }

            // Save data to csv file with profile name
            File.WriteAllText("Profiles/" + data.profileName + ".csv", csvToWrite);
        }

        public static List<Electrode> GetTherapeuticProfileData(string profileName)
        {
            List<Electrode> list = new List<Electrode>();
            int i=1;
            using (var reader = new StreamReader("Profiles/" + profileName + ".csv"))
            {
                reader.ReadLine(); // SKIP FIRST LINE
                
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    Electrode electrode = new Electrode("Electrode " + i);
                    int j = 0;
                    foreach (string value in values)
                    {
                        if (value != "")
                        {
                            Console.WriteLine(value);
                            electrode.therapeuticValues[j] = int.Parse(value);
                            j++;
                        }
                    }
                    list.Add(electrode);
                    i++;
                }
                reader.Close();
            }
            return list;
        }

        public static string GetFreeRunProfileData(string profileName)
        {
            string macro;
            using (var reader = new StreamReader("Profiles/" + profileName + ".csv"))
            {
                reader.ReadLine(); // SKIP FIRST LINE
                macro = reader.ReadLine().Split()[0];
                reader.Close();
            }
            return macro;
        }
        public static string[] GetFESProfileData(string profileName)
        {  
            string[] data = new string[2];
            var reader = new StreamReader("Profiles/" + profileName + ".csv");
            reader.ReadLine(); // SKIP FIRST LINE
            data[0] = reader.ReadLine().Split()[0];
            data[1] = reader.ReadLine().Split()[0];
            reader.Close();
            return data;
        }

        public static string GetFirstMacroFile()
        {
            return GetMacroFileNames()[0];
        }

        public static string GetFirstTriggerFile()
        {
            return GetTriggerFileNames()[0];
        }
    }
}
