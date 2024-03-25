using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemController : MonoBehaviour
{
    private Item item;
    public Button RemoveButton;
    public void RemoveItem()
    {
        InventoryManager.Instance.Remove(item);
        Destroy(gameObject);
    }

    /// <summary>
    /// adding item to panel
    /// </summary>
    /// <param name="newItem"></param>
    public void AddItem(Item newItem)
    {
        item = newItem;
    }

    /// <summary>
    /// using item and getting profit
    /// </summary>
    public void UseItem()
    {
        switch (item.itemType)
        {
            case Item.ItemType.Groot:
                Player.Instance.IncreaseHealth(item.value);
                Player.Instance.IncreaseExp(item.value);
                break;
            case Item.ItemType.Key:
                Player.Instance.IncreaseExp(item.value);
                break;
            case Item.ItemType.Vase:
                Player.Instance.IncreaseHealth(item.value);
                break;
        }
        RemoveItem();
    }
}
