using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }

    public void GoToSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void GoToLevelSelector()
    {
        SceneManager.LoadScene("Levels");
    }
}
