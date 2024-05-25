using UnityEngine;
using UnityEngine.UI;

public class SellUI : MonoBehaviour
{
    public Inventory inventory;
    public Shop shop;
    public GameObject sellItemPrefab;
    public Transform sellPanel;

    void OnEnable()
    {
        UpdateSellUI();        
    }

    public void UpdateSellUI()
    {        
        foreach (Transform child in sellPanel)
        {
            Destroy(child.gameObject);
        }
        
        foreach (Item item in inventory.items)
        {
            GameObject newShopItem = Instantiate(sellItemPrefab, sellPanel);

            SellItemButton newShopItemButton = newShopItem.GetComponent<SellItemButton>();

            newShopItemButton.item = item;
            newShopItem.GetComponent<Button>().onClick.AddListener(() => shop.SellItem(item));            
            newShopItem.GetComponent<Button>().onClick.AddListener(() => newShopItemButton.DestroyButton());
        }
    }
}
