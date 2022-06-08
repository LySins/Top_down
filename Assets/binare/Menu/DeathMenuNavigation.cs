using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenuNavigation : MonoBehaviour
{
    public void RetryButtPressed()
    {
        SceneManager.LoadScene("MainGame");
    }
    public void ExitButtPressed()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
