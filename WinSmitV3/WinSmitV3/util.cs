using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WinSmitV3
{
    static class  util
    {
        public static void saveProject(Project p, String filename)
        {
            Stream streamWrite = File.Create(filename);
            BinaryFormatter binaryWrite = new BinaryFormatter();
            binaryWrite.Serialize(streamWrite, p);
            streamWrite.Close();
        }
        public static Project loadProject(String filename)
        {
            Stream streamRead = File.OpenRead(filename);
            BinaryFormatter binaryRead = new BinaryFormatter();
            Project y = (Project)binaryRead.Deserialize(streamRead);
            streamRead.Close();
            return y;
        }
    }
}
