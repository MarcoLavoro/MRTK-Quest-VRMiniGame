using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField]
    private SceneController sceneController;
    public void LoadGame()
    {
        sceneController.LoadScene(1);
    }
  
}
