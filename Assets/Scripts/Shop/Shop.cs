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
            Debug.Log("Item já comprado");
            return;
        }
        
        // Adicionar lógica de pagamento
        playerInventory.AddItem(itemToBuy);
        // Atualizar UI da loja
    }

    public void SellItem(Item itemToSell)
    {
        playerInventory.RemoveItem(itemToSell);
        // Adicionar lógica de pagamento
        // Atualizar UI da loja
    }
}
