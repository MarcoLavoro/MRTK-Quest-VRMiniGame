using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameManager : MonoBehaviour
{
    //declarations----------------
    public List<ProductProperties> ListActualOrderProperties;
    public List<int> orderToTake;
    public static MinigameManager instance;
    [SerializeField]
    private UiControllerManager uiController;
    [SerializeField]
    private SceneController sceneController;
    //awake and start----------------
    private void Awake()
    {
        instance = this;
        InitVariables();

    }
   
    private void Start()
    {
        RandomizeOrdersAndInitTutorial();
    }

  //manage current order-------
    public void AddToCurrentOrder(ProductProperties prop)
    {
        ListActualOrderProperties.Add(prop);
    }
    public void RemoveToCurrentOrder(ProductProperties prop)
    {
        ListActualOrderProperties.Remove(prop);
    }

    //validation order
    public void ConfirmCurrentOrder()
    {
        ValidateOrder(PropertiesToIntList(ListActualOrderProperties));
    }

    public void ValidateOrder(List<int> ListActualOrder)
    {
        orderToTake.Sort();
        ListActualOrder.Sort();

        bool rightCombination = true;

        //they have the same lengh?
        if (orderToTake.Count != ListActualOrder.Count)
            rightCombination = false;

        //are the same combination?
        if (rightCombination)
            for (int i = 0; i < orderToTake.Count; i++)
                if (orderToTake[i] != ListActualOrder[i])
                    rightCombination = false;


        if (rightCombination)
        {
            uiController.SetUiEndGameState(true);
        }
        else
            uiController.ShowWrongCombinationPanel();

    }
    //externals request
    public void ReturnToMainMenu()
    {
        sceneController.LoadScene(0);
    }

    //--------------------inizialization and reset
    private void InitVariables()
    {
        ListActualOrderProperties = new List<ProductProperties>();
        orderToTake = new List<int>();
    }

    private void RandomizeOrdersAndInitTutorial()
    {
        int randomOrderCount = Random.Range(3, 7);
        for (int i = 0; i < randomOrderCount; i++)
            addRandomSingleOrder();

        uiController.InitTutorial(orderToTake);

    }

    public void Replaygame()
    {

        foreach (ProductProperties prop in ListActualOrderProperties)
            prop.gameObject.GetComponent<ResetPoseOnFall>().ResetPose();
        InitVariables();
        RandomizeOrdersAndInitTutorial();
        uiController.SetUiEndGameState(false);
    }
    //-------------internal logics
    private List<int> PropertiesToIntList(List<ProductProperties> propertyList)
    {
        List<int> intList = new List<int>();
        foreach (ProductProperties prop in propertyList)
            intList.Add(prop.productID);

        return intList;
    }

    private void addRandomSingleOrder()
    {
        orderToTake.Add(Random.Range(1, uiController.dessertsIconsSprites.Length));
    }
}
