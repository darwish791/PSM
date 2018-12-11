using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneMainMenu : MonoBehaviour {

    public void Modul_Henti_Rokok()
    {
        SceneManager.LoadScene(1);
    }

    public void Kad_Imbas()
    {
        SceneManager.LoadScene(2);
    }

    public void Quit()
    {
        Application.Quit();
    }




}
