using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return : MonoBehaviour
{
    public Menu _menu;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            _menu.GameMenu();
    }
}
