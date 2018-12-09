using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenePerokokPasif : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }

    public void kembali()
    {
        SceneManager.LoadScene(3);
    }
}
