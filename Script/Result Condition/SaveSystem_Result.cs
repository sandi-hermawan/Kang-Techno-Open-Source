using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem_Result 
{
    static string path = Application.persistentDataPath + "/ResultData.bin";

    public static void SavePlayer(Result result)
    {
        ResultData data = new ResultData(result);
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Create);
        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static ResultData LoadPlayer()
    {
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            ResultData data = formatter.Deserialize(stream) as ResultData;
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
