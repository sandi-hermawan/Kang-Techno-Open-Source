using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btn_MoveScene : MonoBehaviour
{
    public string namaScene;
    public static int LevelScene;

    public void PindahScene()
    {
        
        Scene sceneIni = SceneManager.GetActiveScene();

        if(sceneIni.name != namaScene)
        {
            if(namaScene == "Level_1")
            {
                LevelScene = 1;
                Debug.Log("Level yang dipilih = " + LevelScene);
                Result.RealLevelResult = LevelScene;
                SceneManager.LoadScene(namaScene);
                Time.timeScale = 1;
            }
            if(namaScene == "Level_2")
            {
                LevelScene = 2;
                Debug.Log("Level yang dipilih = " + LevelScene);
                Result.RealLevelResult = LevelScene;
                SceneManager.LoadScene(namaScene);
                Time.timeScale = 1;
            }
            if(namaScene == "Level_3")
            {
                LevelScene = 3;
                Debug.Log("Level yang dipilih = " + LevelScene);

                Result.RealLevelResult = LevelScene;
                SceneManager.LoadScene(namaScene);
                Time.timeScale = 1;
            }
            if(namaScene == "Level_4")
            {
                LevelScene = 4;
                Debug.Log("Level yang dipilih = " + LevelScene);
                Result.RealLevelResult = LevelScene;
                SceneManager.LoadScene(namaScene);
                Time.timeScale = 1;
            }
            if (namaScene == "Level_5")
            {
                LevelScene = 5;

                Debug.Log("Level yang dipilih = " + LevelScene);
                Result.RealLevelResult = LevelScene;
                SceneManager.LoadScene(namaScene);
                Time.timeScale = 1;
            }
            
        }
    }

}

