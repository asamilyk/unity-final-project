using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item Item;

    void Pickup()
    {
        InventoryManager.Instance.Add(Item);
        Destroy(gameObject);
    }

    /// <summary>
    /// method to add objects to manager while clicking mouse
    /// </summary>
    private void OnMouseDown()
    {
        Pickup();
    }
}
