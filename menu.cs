using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void ChangeScenes(int whatScenes)
    {
        SceneManager.LoadScene(whatScenes);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
