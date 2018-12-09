using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneModulHentiRokok : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }

    public void kembali()
    {
        SceneManager.LoadScene(0);
    }

    public void kenapa_Perlu_Berhenti()
    {
        SceneManager.LoadScene(3);
    }

    public void persediaan_Untuk_Berhenti()
    {
        SceneManager.LoadScene(4);
    }

    public void mula()
    {
        SceneManager.LoadScene(5);
    }
}
