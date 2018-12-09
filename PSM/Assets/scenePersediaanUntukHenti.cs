using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenePersediaanUntukHenti : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }

    public void kembali()
    {
        SceneManager.LoadScene(1);
    }

    public void mengawal_Mood()
    {
        SceneManager.LoadScene(9);
    }
    public void mengawal_Stress()
    {
        SceneManager.LoadScene(10);
    }
}
