using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectorManager : MonoBehaviour
{
    public void GoToLevel1()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void GoToLevel2()
    {
        SceneManager.LoadScene("Level_2");
    }

    public void GoToLevel3()
    {
        SceneManager.LoadScene("Level_3");
    }
}
