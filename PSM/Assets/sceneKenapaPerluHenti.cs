using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneKenapaPerluHenti : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }

    public void kembali()
    {
        SceneManager.LoadScene(1);
    }

    public void masalah_Kesihatan()
    {
        SceneManager.LoadScene(6);
    }

    public void berapa_Banyak_Wang_Boleh_Dijimatkan()
    {
        SceneManager.LoadScene(7);
    }

    public void perokok_Pasif()
    {
        SceneManager.LoadScene(8);
    }
}
