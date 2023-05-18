using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGameScript : MonoBehaviour
{
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }
    public void Restart()
    {
            SceneManager.LoadScene("Game");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
