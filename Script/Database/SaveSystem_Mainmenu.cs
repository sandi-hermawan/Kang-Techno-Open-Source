using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem_Mainmenu
{
    static string path = Application.persistentDataPath + "/MainMenudata.bin";

    public static void SavePlayer(MainMenu mainmenu)
    {
        MainMenuData data = new MainMenuData(mainmenu);
        BinaryFormatter formatter =new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Create);
        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static MainMenuData LoadPlayer()
    {
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            MainMenuData data = formatter.Deserialize(stream) as MainMenuData;
            stream.Close();
            return data;
        }
        else
        {
            Debug.Log("Data tidak ditemukan");
            return null;
        }
    }
}
