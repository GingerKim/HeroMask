using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeSceneBtn()
    {
        switch (this.gameObject.name)
        {
            case "MarvelBtn":
                SceneManager.LoadScene("Marvel");
                break;
            case "DCBtn":
                SceneManager.LoadScene("DC");
                break;
        }
    }
}
