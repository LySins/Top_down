using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public void NewGamePressed()
    {
        SceneManager.LoadScene("MainGame");
    }
    public void ExitGamePressed()
    {
        Application.Quit();
        Debug.Log("ExitPressed");
    }
}
