using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public List<Item> shopItems = new List<Item>();
    public Inventory playerInventory;
    public TMP_Text moneyText;

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
        moneyText.text = $"{playerInventory.money} coins";
        playerInventory.AddItem(itemToBuy);        
    }

    public void SellItem(Item itemToSell)
    {
        playerInventory.RemoveItem(itemToSell);
        playerInventory.money += itemToSell.itemPrice / 2;
        moneyText.text = $"{playerInventory.money} coins";        
    }
}
