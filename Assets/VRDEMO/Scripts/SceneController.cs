using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private bool called = false;
    public void LoadScene(int id)
    {
        if (!called)
        {
            called = true;
               StartCoroutine(LoadYourAsyncScene(id));
        }
    }
    IEnumerator LoadYourAsyncScene(int id)
     {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(id);
         while (!asyncLoad.isDone)
         {
            //TO DO: place a loading bar unityaction (float)
             yield return null;
         }
     }
}
