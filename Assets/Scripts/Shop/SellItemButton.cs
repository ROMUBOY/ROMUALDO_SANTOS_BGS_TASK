using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SellItemButton : MonoBehaviour
{
    public Item item;
    
    public TMP_Text nameText;
    public TMP_Text priceText;
    public Image icon;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = item.itemName;
        priceText.text = $"{item.itemPrice/2} coins";
        icon.sprite = item.itemIcon;
    }

    public void DestroyButton()
    {
        Destroy(this.gameObject);
    }
}
