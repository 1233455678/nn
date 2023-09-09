using System.Collections;

using UnityEngine;

using UnityEngine.SceneManagement;



public class SceneLoader : MonoBehaviour

{

    private void Start()

    {

        StartCoroutine(LoadNextSceneAfterTime(1));

    }



    IEnumerator LoadNextSceneAfterTime(float time)

    {

        yield return new WaitForSeconds(time);



        // ��������� ��������� �����  

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}