using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public List<Item> shopItems = new List<Item>();
    public Inventory playerInventory;

    public void BuyItem(Item itemToBuy)
    {
        if (playerInventory.items.Contains(itemToBuy))
        {
            Debug.Log("Item already in your inventory.");
            return;
        }

        if(playerInventory.money < itemToBuy.itemPrice)
        {
            Debug.Log("Not enough money.");
            return;
        }
        
        playerInventory.money -= itemToBuy.itemPrice;
        playerInventory.AddItem(itemToBuy);        
    }

    public void SellItem(Item itemToSell)
    {
        playerInventory.RemoveItem(itemToSell);
        playerInventory.money += itemToSell.itemPrice / 2;
        // Atualizar UI da loja
    }
}
