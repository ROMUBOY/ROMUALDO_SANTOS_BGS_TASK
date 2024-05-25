using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemButton : MonoBehaviour
{
    public Item item;
    
    public TMP_Text nameText;
    public TMP_Text priceText;
    public Image icon;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = item.itemName;
        priceText.text = $"{item.itemPrice} coins";
        icon.sprite = item.itemIcon;
    }
}
