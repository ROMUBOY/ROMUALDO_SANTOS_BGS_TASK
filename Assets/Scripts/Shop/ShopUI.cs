using UnityEngine;
using UnityEngine.UI;

public class ShopUI : MonoBehaviour
{
    public Shop shop;
    public GameObject shopItemPrefab;
    public Transform shopPanel;

    void Start()
    {
        UpdateShopUI();        
    }

    public void UpdateShopUI()
    {        
        foreach (Transform child in shopPanel)
        {
            Destroy(child.gameObject);
        }
        
        foreach (Item item in shop.shopItems)
        {
            GameObject newShopItem = Instantiate(shopItemPrefab, shopPanel);
            newShopItem.GetComponent<ItemButton>().item = item;
            newShopItem.GetComponent<Button>().onClick.AddListener(() => shop.BuyItem(item));
        }
    }
}
