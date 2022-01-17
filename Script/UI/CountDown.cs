using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public GameObject countDown;

    void Start()
    {
        StartCoroutine("StartDelay");
    }
    private void Update()
    {
        
    }

    IEnumerator StartDelay()
    {
        Time.timeScale = 0;
        float pauseTime = Time.realtimeSinceStartup + 5f;
        while (Time.realtimeSinceStartup < pauseTime)
        {
            yield return 0;

            countDown.gameObject.SetActive(false);

            Time.timeScale = 1;
        }
    }
}
