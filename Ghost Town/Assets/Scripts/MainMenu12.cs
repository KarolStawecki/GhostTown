using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu12 : MonoBehaviour
{
   

    public void PlayGame()
    {
        SceneManager.LoadScene("Ghost Town");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
