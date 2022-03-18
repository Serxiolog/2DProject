using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish_Flag : MonoBehaviour
{
    public bool flag = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (flag)
            SceneManager.LoadScene("Second");
        else
            SceneManager.LoadScene("Menu");
    }
}
