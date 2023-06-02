using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
            GameQuit();
    }
    public void GameQuit()
    {
        Application.Quit();
    }

}
