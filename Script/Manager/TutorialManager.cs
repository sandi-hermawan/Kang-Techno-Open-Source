using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject panelTutorJump;
    public GameObject panelTutorSlide;
    public GameObject panelTutorPenjelasan;
    public GameObject panelTutorPenjelasan1;
    public GameObject panelTutorPenjelasan2;
    public GameObject pannelMulai;

    public GameObject PanelTutor;

    void Start()
    {
        Time.timeScale = 0;

    }

    void Update()
    {
        
    }

    public void showTutorSlide()
    {
        panelTutorJump.SetActive(false);
        panelTutorSlide.SetActive(true);
    }

    public void showTutorPenjelasan()
    {
        panelTutorSlide.SetActive(false);
        panelTutorPenjelasan.SetActive(true);
    }

    public void showTutorPenjelasan1()
    {
        panelTutorPenjelasan.SetActive(false);
        panelTutorPenjelasan1.SetActive(true);
    }
    public void showTutorPenjelasan2()
    {
        panelTutorPenjelasan1.SetActive(false);
        panelTutorPenjelasan2.SetActive(true);
    }

    public void showMulai()
    {
        panelTutorPenjelasan2.SetActive(false);
        pannelMulai.SetActive(true);
    }
    public void Hide()
    {
        pannelMulai.SetActive(false);
        PanelTutor.SetActive(false);
        Time.timeScale = 1;

    }
    public void SkipTutor()
    {
        pannelMulai.SetActive(true);
        panelTutorJump.SetActive(false);
        panelTutorSlide.SetActive(false);
        panelTutorPenjelasan.SetActive(false);
        panelTutorPenjelasan1.SetActive(false);
        panelTutorPenjelasan2.SetActive(false);
        Time.timeScale = 0;
    }
}
