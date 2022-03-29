using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    public void Onclick()
    {
        SceneManager.LoadScene("GameMap");
    }

    public void OnclickQuit()
    {
        Application.Quit();
    }
}
