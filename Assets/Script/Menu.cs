using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void GameFirst()
    {
        SceneManager.LoadScene("First");
    }
    
    public void GameSecond()
    {
        SceneManager.LoadScene("Second");
    }

    public void GameBullShit()
    {
        SceneManager.LoadScene("Strange");
    }

    public void GameMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
