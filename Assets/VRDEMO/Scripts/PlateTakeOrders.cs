using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this script let interact with the order to make
public class PlateTakeOrders : MonoBehaviour
{
    public List<int> ListActualOrder;
    private void Start()
    {
        ListActualOrder = new List<int>();
    }
    private void OnTriggerEnter(Collider other)
    {
        ProductProperties prop = other.gameObject.GetComponent<ProductProperties>();
        if (prop != null)
            MinigameManager.instance.AddToCurrentOrder(prop);
    }

    private void OnTriggerExit(Collider other)
    {
          ProductProperties prop = other.gameObject.GetComponent<ProductProperties>();
          if (prop != null)
            MinigameManager.instance.RemoveToCurrentOrder(prop);
    }
}
