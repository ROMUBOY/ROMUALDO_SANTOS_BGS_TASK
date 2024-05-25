using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    public int money = 200;

    public void AddItem(Item newItem)
    {
        items.Add(newItem);
        // Atualizar UI do inventário
    }

    public void RemoveItem(Item itemToRemove)
    {
        items.Remove(itemToRemove);
        // Atualizar UI do inventário
    }
}
