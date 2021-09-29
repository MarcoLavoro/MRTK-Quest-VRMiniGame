using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiControllerManager : MonoBehaviour
{
    [SerializeField]
    public Sprite[] dessertsIconsSprites;
    [SerializeField]
    private Transform parentIconTransform;
    [SerializeField]
    private GameObject prefabIcon;

    [SerializeField]
    private GameObject panelTutorial;

    [SerializeField]
    private GameObject panelEndGame;

    [SerializeField]
    private GameObject panelWrongCombination;

    public void InitTutorial(List<int> listDesserts)
    {

        DestroyAllChildren();
        //we supposed the icons sprites are placed in numerical order order
        foreach (int dessert in listDesserts)
        {
         GameObject icon=GameObject.Instantiate(prefabIcon, parentIconTransform);
            icon.GetComponent<Image>().sprite = dessertsIconsSprites[dessert - 1];
        }
    }


    public void ShowWrongCombinationPanel()
    {
        panelWrongCombination.SetActive(true);
    }
    public void SetUiEndGameState(bool endGame)
    {
        panelTutorial.SetActive(!endGame);
        panelEndGame.SetActive(endGame);
        panelWrongCombination.SetActive(false);
    }
    private void DestroyAllChildren()
    {
        foreach (Transform child in parentIconTransform)
            GameObject.Destroy(child.gameObject);
    }
}
