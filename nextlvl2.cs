using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlvl2 : MonoBehaviour
{
    public string targetScene;

    private void OnTriggerEnter2D2(Collider2D other)
    {
        if (other.CompareTag("Player2"))
            {
                SceneManager.LoadScene(targetScene);
            }
    }
}
