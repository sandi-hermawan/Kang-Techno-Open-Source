using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem_Booster
{
    static string path = Application.persistentDataPath + "/BoosterData.bin";

    public static void SavePlayer(Booster booster)
    {
        BoosterData data = new BoosterData(booster);
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Create);
        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static BoosterData LoadPlayer()
    {
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            BoosterData data = formatter.Deserialize(stream) as BoosterData;
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
