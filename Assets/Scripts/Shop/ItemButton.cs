using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

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

    // Update is called once per frame
    void Update()
    {
        
    }
}
